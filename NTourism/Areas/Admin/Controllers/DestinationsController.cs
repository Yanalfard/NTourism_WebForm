using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTourism.Repositories.Impl;
using NTourism.Services.Impl;
using NTourism.Models.Regular;
using System.Net;
using NTourism.Models.ObjectClass;
using System.IO;

namespace NTourism.Areas.Admin.Controllers
{
    public class DestinationsController : Controller
    {
        private AttractionService _attractionService;
        public DestinationsController()
        {
            _attractionService = new AttractionService();
        }
        // GET: Admin/
        public ActionResult Index()
        {
            List<OcAttraction> attractions = new List<OcAttraction>();
            foreach (TblAttraction i in _attractionService.SelectAttractionByStatus(2))
            {
                attractions.Add(new OcAttraction(i, "", ""));
            }
            return View(attractions.OrderByDescending(i => i.id));
        }
        public ActionResult Create()
        {
            return View(new OcAttraction());
        }

        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ImageId,TextId,IsText,Text,CityId,OrderId,Status,Name,Title,Score,IsSelected,City,Text,Image,ImageName")] OcAttraction page, HttpPostedFileBase ImageFile)
        {

            string cityName = Request.Form["cityNames"].ToString();
            if (ModelState.IsValid)
            {
                if (ImageFile == null)
                {
                    return View(page);

                }
                page.Image = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.Image));
                page.Status = 2;
                page.OrderId = 1;
                TblText text = new TblText
                {
                    Text = page.Text
                };
                TblText textId = new TextService().AddText(text);
                TblImages image = new TblImages
                {
                    Image = page.Image,
                    Name = page.ImageName
                };
                TblImages imageId = new ImagesService().AddImage(image);
                TblCity SearchCityId = new CityService().SelectCityByName(cityName);
                TblCity city = new TblCity
                {
                    id = SearchCityId.id,
                    Name = cityName,
                    CountryId = 1
                };
                TblAttraction attraction = new TblAttraction
                {
                    Name = page.Name,
                    CityId = SearchCityId.id,
                    ImageId = imageId.id,
                    IsText = page.IsText,
                    IsSelected = page.IsSelected,
                    OrderId = page.OrderId,
                    Score = page.Score,
                    Status = page.Status,
                    TextId = textId.id,
                    Title = page.Title,

                };
                new AttractionService().AddAttraction(attraction);
                return RedirectToAction("Index");
            }

            return View(page);
        }

        // GET: Admin/Pages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblAttraction page = _attractionService.SelectAttractionById(id.Value);
            OcAttraction selectOcAttractionById = new OcAttraction
            {
                Name = page.Name,
                City = new CityService().SelectCityById(page.CityId).Name,
                id = page.id,
                CityId = page.CityId,
                Image = new ImagesService().SelectImageById(page.ImageId).Image,
                ImageId = page.ImageId,
                IsSelected = page.IsSelected,
                IsText = page.IsText,
                OrderId = page.OrderId,
                Score = page.Score,
                Status = page.Status,
                Text = new TextService().SelectTextById(page.TextId).Text,
                TextId = page.TextId,
                Title = page.Title,
                ImageName = new ImagesService().SelectImageById(page.ImageId).Name
            };
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcAttractionById);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ImageId,TextId,IsText,Text,CityId,OrderId,Status,Name,Title,Score,IsSelected,City,Text,Image,ImageName")] OcAttraction page, HttpPostedFileBase ImageFile)
        {
            string cityName = Request.Form["cityNames"].ToString();

            if (ModelState.IsValid)
            {

                TblText text = new TblText
                {
                    Text = page.Text
                };
                new TextService().UpdateText(text, page.TextId);
                if (ImageFile != null)
                {
                    if (page.Image != null)
                    {
                        System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.Image));
                    }
                    page.Image = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                    ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.Image));

                }
                TblImages image = new TblImages
                {
                    Image = page.Image,
                    Name = page.ImageName,
                };
                new ImagesService().UpdateImage(image, page.ImageId);
                TblCity SearchCityId = new CityService().SelectCityByName(cityName);
                TblCity city = new TblCity
                {
                    id = SearchCityId.id,
                    Name = cityName,
                    CountryId = 1
                };
                //new CityService().UpdateCity(city, page.CityId);
                TblAttraction attraction = new TblAttraction
                {
                    Name = page.Name,
                    CityId = SearchCityId.id,
                    ImageId = page.ImageId,
                    IsText = page.IsText,
                    IsSelected = page.IsSelected,
                    OrderId = page.OrderId,
                    Score = page.Score,
                    Status = page.Status,
                    TextId = page.TextId,
                    Title = page.Title,

                };
                _attractionService.UpdateAttraction(attraction, page.id);
                return RedirectToAction("Index");
            }
            return View(page);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblAttraction page = _attractionService.SelectAttractionById(id.Value);
            OcAttraction selectOcAttractionById = new OcAttraction
            {
                Name = page.Name,
                City = new CityService().SelectCityById(page.CityId).Name,
                id = page.id,
                CityId = page.CityId,
                Image = new ImagesService().SelectImageById(page.ImageId).Image,
                ImageId = page.ImageId,
                IsSelected = page.IsSelected,
                IsText = page.IsText,
                OrderId = page.OrderId,
                Score = page.Score,
                Status = page.Status,
                Text = new TextService().SelectTextById(page.TextId).Text,
                TextId = page.TextId,
                Title = page.Title,
                ImageName = new ImagesService().SelectImageById(page.ImageId).Name

            };

            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectOcAttractionById);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblAttraction page = _attractionService.SelectAttractionById(id);
            TblImages DeletImg = new ImagesService().SelectImageById(page.ImageId);
            if (DeletImg.Image != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + DeletImg.Image));
            }
            _attractionService.DeleteAttraction(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<OcAttraction> attractions = new List<OcAttraction>();
            foreach (TblAttraction i in _attractionService.SelectAttractionByStatus(2).Where(i => i.Name.ToLower().Contains(q) || i.Name == q))
            {
                attractions.Add(new OcAttraction(i, "", ""));
            }
            return View(attractions.OrderByDescending(i => i.id));

        }

    }
}
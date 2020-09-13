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
    public class CityController : Controller
    {
        private CityService _cityService;
        public CityController()
        {
            _cityService = new CityService();
        }
        // GET: Admin/City
        public ActionResult Index()
        {
            List<OcTblCity> citys = new List<OcTblCity>();
            foreach (TblCity i in _cityService.SelectAllCities().OrderByDescending(n => n.id))
            {
                citys.Add(new OcTblCity(i));
            }
            return View(citys);
        }
        public ActionResult Create()
        {
            return View(new OcTblCity());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Country,Data,MapLink,IsValid,MainImage")] OcTblCity page, HttpPostedFileBase ImageFile)
        {
            string CountryName = Request.Form["CountryNames"].ToString();
            page.Country = CountryName;
            if (ModelState.IsValid)
            {
                TblCity Testcity = new CityService().SelectCityByName(page.Name);
                if (Testcity.Name != null || Testcity.id != -1)
                {
                    ViewBag.Message = "Name is duplicate";
                    return View(page);
                }
                if (ImageFile != null)
                {
                    page.MainImage = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                    ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.MainImage));

                }
                
                
                TblCountry SearchCountryId = new CountryService().SelectCountryByName(CountryName);
                TblCountry country = new TblCountry
                {
                    id = SearchCountryId.id,
                    Name = CountryName,

                };
                TblCity city = new TblCity
                {
                    Name = page.Name,
                    CountryId = SearchCountryId.id,
                    IsValid = page.IsValid,
                    MapLink = page.MapLink,
                    Data = page.Data,
                    MainImage = page.MainImage

                };
                _cityService.AddCity(city);
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
            TblCity page = _cityService.SelectCityById(id.Value);
            OcTblCity selectOcTblCityById = new OcTblCity
            {
                id = page.id,
                Name = page.Name,
                Country = new CountryService().SelectCountryById(page.CountryId).Name,
                MapLink=page.MapLink,
                Data=page.Data,
                IsValid = page.IsValid,
                MainImage = page.MainImage


            };
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcTblCityById);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Country,Data,MapLink,IsValid,MainImage")] OcTblCity page, HttpPostedFileBase ImageFile)
        {
            string CountryName = Request.Form["CountryNames"].ToString();
            page.Country = CountryName;
            if (ModelState.IsValid)
            {
                if (ImageFile != null)
                {
                    if (page.MainImage != null)
                    {
                        System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.MainImage));
                    }
                    page.MainImage = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                    ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.MainImage));
                    TblImages image = new TblImages
                    {
                        Image = page.MainImage
                    };
                }
                var TestCity = new CityService().SelectAllCities().Where(i => i.id != page.id);
                foreach (var item in TestCity)
                {
                    if (item.Name == page.Name)
                    {
                        ViewBag.Message = "Name is duplicate";
                        return View(page);
                    }
                }
                TblCountry SearchCountryId = new CountryService().SelectCountryByName(CountryName);
                TblCountry country = new TblCountry
                {
                    id = SearchCountryId.id,
                    Name = CountryName
                };
                TblCity city = new TblCity
                {
                    id = page.id,
                    Name = page.Name,
                    CountryId = SearchCountryId.id,
                    MapLink = page.MapLink,
                    Data = page.Data,
                    IsValid = page.IsValid,
                    MainImage = page.MainImage

                };
                _cityService.UpdateCity(city, page.id);
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
            TblCity page = _cityService.SelectCityById(id.Value);
            OcTblCity selectOcTblCityById = new OcTblCity
            {
                id = page.id,
                Name = page.Name,
                Country = new CountryService().SelectCountryById(page.CountryId).Name,
                MapLink = page.MapLink,
                Data = page.Data,
                IsValid = page.IsValid,
                MainImage = page.MainImage


            };
            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectOcTblCityById);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblCity page = _cityService.SelectCityById(id);
            if (page.MainImage != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.MainImage));
            }
           _cityService.DeleteCity(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<OcTblCity> citys = new List<OcTblCity>();
            foreach (TblCity i in _cityService.SelectAllCities().Where(i => i.Name.ToLower().Contains(q) || i.Name == q).OrderByDescending(n => n.id))
            {
                citys.Add(new OcTblCity(i));
            }
            return View(citys);

        }
    }
}
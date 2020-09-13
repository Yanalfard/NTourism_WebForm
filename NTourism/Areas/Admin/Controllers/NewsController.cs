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
    public class NewsController : Controller
    {
        private NewsService _newsService;
        public NewsController()
        {
            _newsService = new NewsService();
        }
        // GET: Admin/
        public ActionResult Index()
        {
            List<OcNews> news = new List<OcNews>();
            foreach (TblNews i in _newsService.SelectAllNews())
            {
                news.Add(new OcNews(i));
            }
            return View(news.OrderByDescending(i => i.id));
        }
        public ActionResult Create()
        {
            return View(new OcNews());
        }
        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,ImageId,TextId,IsText,Text,CityId,OrderId,Status,Name,Title,Score,Let,Lun,IsSelected,City,Text,Image,IsPinned,ImageName")] OcNews page, HttpPostedFileBase ImageFile)
        {

            if (ImageFile == null)
            {
                return View(page);
            }

            if (ModelState.IsValid)
            {
                page.OrderId = 1;
                page.IsSelected = true;
                page.IsText = true;
                List<TblNews> Testnews = new NewsService().SelectNewsByName(page.Name);
                foreach (var item in Testnews)
                {
                    if (item.Name == page.Name)
                    {
                        ViewBag.Message = "Name is duplicate";
                        return View(page);
                    }
                }
                TblText text = new TblText
                {
                    Text = page.Text
                };
                TblText textId = new TextService().AddText(text);
                page.Image = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.Image));
                TblImages image = new TblImages
                {
                    Image = page.Image,
                    Name = page.ImageName
                };
                TblImages imageId = new ImagesService().AddImage(image);

                TblNews news = new TblNews
                {
                    Name = page.Name,
                    Title = page.Title,
                    OrderId = page.OrderId,
                    TextId = textId.id,
                    ImageId = imageId.id,
                    IsText = page.IsText,
                    IsSelected = page.IsSelected,
                    IsPinned = page.IsPinned,


                };
                new NewsService().AddNews(news);
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
            TblNews page = _newsService.SelectNewsById(id.Value);
            OcNews selectOcNewsById = new OcNews
            {
                id = page.id,
                Name = page.Name,
                Image = new ImagesService().SelectImageById(page.ImageId).Image,
                ImageId = page.ImageId,
                IsSelected = page.IsSelected,
                IsText = page.IsText,
                OrderId = page.OrderId,
                Text = new TextService().SelectTextById(page.TextId).Text,
                TextId = page.TextId,
                Title = page.Title,
                IsPinned = page.IsPinned,
                ImageName = new ImagesService().SelectImageById(page.ImageId).Name
            };
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcNewsById);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,ImageId,TextId,IsText,Text,CityId,OrderId,Status,Name,Title,Score,Let,Lun,IsSelected,City,Text,Image,IsPinned,ImageName")] OcNews page, HttpPostedFileBase ImageFile)
        {
            if (ModelState.IsValid)
            {


                var TestNews = new NewsService().SelectAllNews().Where(i => i.id != page.id);
                foreach (var item in TestNews)
                {
                    if (item.Name == page.Name)
                    {
                        ViewBag.Message = "Name is duplicate";
                        return View(page);
                    }
                }

                var TestText = new TextService().SelectTextById(page.TextId);
                if (TestText.Text != "")
                {
                    //CODE
                    //string main = TestText.Text;
                    //string[] stp1 = main.Split(new string[] { "<img alt=\"\" src=\"/Resources/UploadEditor/" }, StringSplitOptions.None);
                    //string[] final = new string[stp1.Length - 1];
                    //for (int i = 1; i < stp1.Length; i++)
                    //{
                    //    final[i - 1] = stp1[i].Split('\"')[0];
                    //    var NameImage = final;
                    //    System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + final));
                    //}

                }

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
                    Name = page.ImageName
                };
                new ImagesService().UpdateImage(image, page.ImageId);
                TblNews news = new TblNews
                {
                    Name = page.Name,
                    ImageId = page.ImageId,
                    IsText = page.IsText,
                    IsSelected = page.IsSelected,
                    OrderId = page.OrderId,
                    TextId = page.TextId,
                    Title = page.Title,
                    IsPinned = page.IsPinned


                };
                _newsService.UpdateNews(news, page.id);
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
            TblNews page = _newsService.SelectNewsById(id.Value);
            OcNews selectOcNewsById = new OcNews
            {
                id = page.id,
                Name = page.Name,
                Image = new ImagesService().SelectImageById(page.ImageId).Image,
                ImageId = page.ImageId,
                IsSelected = page.IsSelected,
                IsText = page.IsText,
                OrderId = page.OrderId,
                Text = new TextService().SelectTextById(page.TextId).Text,
                TextId = page.TextId,
                Title = page.Title,
                IsPinned = page.IsPinned,
                ImageName = new ImagesService().SelectImageById(page.ImageId).Name


            };
            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectOcNewsById);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblNews page = _newsService.SelectNewsById(id);
            TblImages DeletImg = new ImagesService().SelectImageById(page.ImageId);
            if (DeletImg.Image != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + DeletImg.Image));
            }
            _newsService.DeleteNews(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<OcNews> news = new List<OcNews>();
            foreach (TblNews i in _newsService.SelectAllNews().Where(i => i.Name.ToLower().Contains(q) || i.Name == q))
            {
                news.Add(new OcNews(i));
            }
            return View(news.OrderByDescending(i => i.id));
        }
        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            string vImagePath = String.Empty;
            string vMessage = String.Empty;
            string vFilePath = String.Empty;
            string vOutput = String.Empty;
            try
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    var vFileName = DateTime.Now.ToString("yyyyMMdd-HHMMssff") +
                                    Path.GetExtension(upload.FileName).ToLower();
                    var vFolderPath = Server.MapPath("/Resources/UploadEditor/");
                    if (!Directory.Exists(vFolderPath))
                    {
                        Directory.CreateDirectory(vFolderPath);
                    }
                    vFilePath = Path.Combine(vFolderPath, vFileName);
                    upload.SaveAs(vFilePath);
                    vImagePath = Url.Content("/Resources/UploadEditor/" + vFileName);
                    vMessage = "Image is Upload";
                }
            }
            catch
            {
                vMessage = "There was an issue uploading";
            }
            vOutput = @"<html><body><script>window.parent.CKEDITOR.tools.callFunction(" + CKEditorFuncNum + ", \"" + vImagePath + "\", \"" + vMessage + "\");</script></body></html>";
            return Content(vOutput);
        }
        [HttpPost]
        public JsonResult AjaxPostCall(TblImages employeeData)
        {
            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + employeeData.Name));
            return Json("True");
        }
    }


}
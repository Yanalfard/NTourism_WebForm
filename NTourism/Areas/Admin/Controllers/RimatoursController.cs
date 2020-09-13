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
    public class RimatoursController : Controller
    {
        private TourGuideService _tourGuide;
        public RimatoursController()
        {
            _tourGuide = new TourGuideService();
        }
        // GET: Admin/Rimatours
        public ActionResult Index()
        {
            List<OcRimatours> tourGuid = new List<OcRimatours>();
            foreach (TblTourGuide i in _tourGuide.SelectAllTourGuides())
            {
                tourGuid.Add(new OcRimatours(i));
            }
            return View(tourGuid.OrderByDescending(i => i.id));
        }
        public ActionResult Create()
        {
            return View(new OcRimatours());
        }
        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,TellNo,Email,MainImage,Description,Username,Password,City,Rate,Discount,Price")] OcRimatours page, HttpPostedFileBase ImageFile, HttpPostedFileBase FileImages1, HttpPostedFileBase FileImages2, HttpPostedFileBase FileImages3, HttpPostedFileBase FileImages4, HttpPostedFileBase FileImages5, HttpPostedFileBase FileImages6)
        {
            string cityName = Request.Form["cityNames"].ToString();
            if (ModelState.IsValid)
            {
                TblTourGuide TestEmail = new TourGuideService().SelectTourGuideByEmail(page.Email);
                if (TestEmail.Description != null || TestEmail.id != -1)
                {
                    ViewBag.Message = "Email is duplicate";
                    return View(page);
                }
                TblTourGuide TestUsername = new TourGuideService().SelectTourGuideByUsername(page.Username);
                if (TestUsername.Description != null || TestUsername.id != -1)
                {
                    ViewBag.Message = "Username is duplicate";
                    return View(page);
                }
                List<TblImages> listOfImages = new List<TblImages>();

                if (FileImages1 != null && Request.Form["ImageNameKey1"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages1.FileName);
                    string ImageNameKey1 = Request.Form["ImageNameKey1"].ToString();
                    FileImages1.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey1
                    };

                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }
                if (FileImages2 != null && Request.Form["ImageNameKey2"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages2.FileName);
                    string ImageNameKey2 = Request.Form["ImageNameKey1"].ToString();
                    FileImages2.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey2
                    };
                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }
                if (FileImages3 != null && Request.Form["ImageNameKey3"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages3.FileName);
                    string ImageNameKey3 = Request.Form["ImageNameKey1"].ToString();
                    FileImages3.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey3
                    };
                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }
                if (FileImages4 != null && Request.Form["ImageNameKey4"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages4.FileName);
                    string ImageNameKey4 = Request.Form["ImageNameKey1"].ToString();
                    FileImages4.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey4
                    };
                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }
                if (FileImages5 != null && Request.Form["ImageNameKey5"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages5.FileName);
                    string ImageNameKey5 = Request.Form["ImageNameKey1"].ToString();
                    FileImages5.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey5
                    };
                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }
                if (FileImages6 != null && Request.Form["ImageNameKey6"] != "")
                {
                    var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages6.FileName);
                    string ImageNameKey6 = Request.Form["ImageNameKey1"].ToString();
                    FileImages6.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                    TblImages imagesName = new TblImages
                    {
                        Image = InputFileName,
                        Name = ImageNameKey6
                    };
                    TblImages imageId = new ImagesService().AddImage(imagesName);
                    listOfImages.Add(imageId);
                }


                if (ImageFile == null)
                {
                    return View(page);

                }
                page.MainImage = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.MainImage));

                TblCity SearchCityId = new CityService().SelectCityByName(cityName);
                TblTourGuide tourGuide = new TblTourGuide
                {
                    FirstName = page.FirstName,
                    LastName = page.LastName,
                    Email = page.Email,
                    MainImage = page.MainImage,
                    Description = page.Description,
                    Username = page.Username,
                    Password = page.Password,
                    TellNo = page.TellNo,
                    CityId = SearchCityId.id,
                    Discount=page.Discount,
                    Rate=page.Rate,
                    Price=page.Price
                    

                };
                TblTourGuide guide = new TourGuideService().AddTourGuide(tourGuide);
                //if (guide.id == -1)
                //{
                //    ViewBag.Message = "Successfully Registration Done";
                //    return View(page);
                //}
                foreach (TblImages i in listOfImages)
                {
                    if (i != null)
                    {
                        new TourGuideImagesRelService().AddTourGuideImagesRel(new TblTourGuideImagesRel(guide.id, i.id));
                    }
                }
                return RedirectToAction("Index");
            }
            return View(page);
        }

        //// GET: Admin/Pages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTourGuide page = _tourGuide.SelectTourGuideById(id.Value);
            OcRimatours selectOcRimatoursById = new OcRimatours
            {
                FirstName = page.FirstName,
                City = new CityService().SelectCityById(page.CityId).Name,
                id = page.id,
                CityId = page.CityId,
                Description = page.Description,
                Email = page.Email,
                LastName = page.LastName,
                MainImage = page.MainImage,
                Password = page.Password,
                TellNo = page.TellNo,
                Username = page.Username,
                Discount = page.Discount,
                Rate = page.Rate,
                Price = page.Price,
                

            };
            List<TblImages> images = new TourGuideService().SelectImagesByTourGuide(page.id);
            ViewBag.CityName = selectOcRimatoursById.City;
            selectOcRimatoursById.Images = new List<string>();
            selectOcRimatoursById.ImagesId = new List<int>();
            selectOcRimatoursById.ImagesName = new List<string>();

            foreach (TblImages i in images)
            {
                selectOcRimatoursById.Images.Add(i.Image);
                selectOcRimatoursById.ImagesId.Add(i.id);
                selectOcRimatoursById.ImagesName.Add(i.Name);

            }
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcRimatoursById);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FirstName,LastName,TellNo,Email,MainImage,Description,Username,Password,City,Rate,Discount,Price")] OcRimatours page, HttpPostedFileBase ImageFile, HttpPostedFileBase FileImages1, HttpPostedFileBase FileImages2, HttpPostedFileBase FileImages3, HttpPostedFileBase FileImages4, HttpPostedFileBase FileImages5, HttpPostedFileBase FileImages6)
        {

            int Images1Input1 = 0;
            int Images1Input2 = 0;
            int Images1Input3 = 0;
            int Images1Input4 = 0;
            int Images1Input5 = 0;
            int Images1Input6 = 0;
            string cityName = Request.Form["cityNames"].ToString();
            if (ModelState.IsValid)
            {
                var TestEmailAndUser = new TourGuideService().SelectAllTourGuides().Where(i => i.id != page.id);
                foreach (var item in TestEmailAndUser)
                {
                    if (item.Email == page.Email)
                    {
                        List<TblImages> images = new TourGuideService().SelectImagesByTourGuide(page.id);
                        ViewBag.CityName = cityName;
                        page.Images = new List<string>();
                        page.ImagesName = new List<string>();
                        page.ImagesId = new List<int>();
                        foreach (TblImages i in images)
                        {
                            page.Images.Add(i.Image);
                            page.ImagesName.Add(i.Name);
                            page.ImagesId.Add(i.id);
                        }
                        ViewBag.Message = "Email is duplicate";
                        return View(page);
                    }
                }
                foreach (var item in TestEmailAndUser)
                {
                    if (item.Username == page.Username)
                    {
                        List<TblImages> images = new TourGuideService().SelectImagesByTourGuide(page.id);
                        ViewBag.CityName = cityName;
                        page.Images = new List<string>();
                        page.ImagesName = new List<string>();
                        page.ImagesId = new List<int>();
                        foreach (TblImages i in images)
                        {
                            page.Images.Add(i.Image);
                            page.ImagesName.Add(i.Name);
                            page.ImagesId.Add(i.id);
                        }
                        ViewBag.Message = "Username is duplicate";
                        return View(page);
                    }
                }
                List<TblImages> listOfImagesAdd = new List<TblImages>();
                List<int> listOfImagesUpdate = new List<int>();


                if (FileImages1 != null && Request.Form["ImageNameKey1"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey1 = Request.Form["ImageNameKey1"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input1"]) != 0)
                    {
                        Images1Input1 = Convert.ToInt32(Request.Form["Images1Input1"]);
                        image = new ImagesService().SelectImageById(Images1Input1);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages1.FileName);
                        FileImages1.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey1
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages1.FileName);
                        FileImages1.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey1
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }
                if (FileImages2 != null && Request.Form["ImageNameKey2"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey2 = Request.Form["ImageNameKey2"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input2"]) != 0)
                    {
                        Images1Input2 = Convert.ToInt32(Request.Form["Images1Input2"]);
                        image = new ImagesService().SelectImageById(Images1Input2);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages2.FileName);
                        FileImages2.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey2
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages2.FileName);
                        FileImages2.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey2
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }
                if (FileImages3 != null && Request.Form["ImageNameKey3"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey3 = Request.Form["ImageNameKey3"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input3"]) != 0)
                    {
                        Images1Input3 = Convert.ToInt32(Request.Form["Images1Input3"]);
                        image = new ImagesService().SelectImageById(Images1Input3);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages3.FileName);
                        FileImages3.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey3
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages3.FileName);
                        FileImages3.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey3
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }
                if (FileImages4 != null && Request.Form["ImageNameKey4"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey4 = Request.Form["ImageNameKey4"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input4"]) != 0)
                    {
                        Images1Input4 = Convert.ToInt32(Request.Form["Images1Input4"]);
                        image = new ImagesService().SelectImageById(Images1Input4);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages4.FileName);
                        FileImages4.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey4
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages4.FileName);
                        FileImages4.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey4
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }
                if (FileImages5 != null && Request.Form["ImageNameKey5"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey5 = Request.Form["ImageNameKey5"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input5"]) != 0)
                    {
                        Images1Input5 = Convert.ToInt32(Request.Form["Images1Input5"]);
                        image = new ImagesService().SelectImageById(Images1Input5);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages5.FileName);
                        FileImages5.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey5
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages5.FileName);
                        FileImages5.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey5
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }
                if (FileImages6 != null && Request.Form["ImageNameKey6"] != "")
                {
                    TblImages image = new TblImages();
                    string ImageNameKey6 = Request.Form["ImageNameKey6"].ToString();
                    if (Convert.ToInt32(Request.Form["Images1Input6"]) != 0)
                    {
                        Images1Input6 = Convert.ToInt32(Request.Form["Images1Input6"]);
                        image = new ImagesService().SelectImageById(Images1Input6);
                        if (image.Image != "")
                        {
                            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + image.Image));
                        }
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages6.FileName);
                        FileImages6.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey6
                        };
                        new ImagesService().UpdateImage(imagesName, image.id);
                        listOfImagesUpdate.Add(image.id);
                    }
                    else
                    {
                        var InputFileName = Guid.NewGuid() + Path.GetExtension(FileImages6.FileName);
                        FileImages6.SaveAs(Server.MapPath("/Resources/Imges/" + InputFileName));
                        TblImages imagesName = new TblImages
                        {
                            Image = InputFileName,
                            Name = ImageNameKey6
                        };
                        TblImages imageId = new ImagesService().AddImage(imagesName);
                        listOfImagesAdd.Add(imageId);
                    }
                }




                if (Request.Form["IsFullImageOrEmpty1"] == "1" && Convert.ToInt32(Request.Form["Images1Input1"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input1"]);
                    new ImagesService().DeleteImage(removeImages1);
                }
                if (Request.Form["IsFullImageOrEmpty2"] == "1" && Convert.ToInt32(Request.Form["Images1Input2"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input2"]);
                    new ImagesService().DeleteImage(removeImages1);
                }
                if (Request.Form["IsFullImageOrEmpty3"] == "1" && Convert.ToInt32(Request.Form["Images1Input3"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input3"]);
                    new ImagesService().DeleteImage(removeImages1);
                }
                if (Request.Form["IsFullImageOrEmpty4"] == "1" && Convert.ToInt32(Request.Form["Images1Input4"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input4"]);
                    new ImagesService().DeleteImage(removeImages1);
                }
                if (Request.Form["IsFullImageOrEmpty5"] == "1" && Convert.ToInt32(Request.Form["Images1Input5"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input5"]);
                    new ImagesService().DeleteImage(removeImages1);
                }
                if (Request.Form["IsFullImageOrEmpty6"] == "1" && Convert.ToInt32(Request.Form["Images1Input6"]) != 0)
                {
                    int removeImages1 = Convert.ToInt32(Request.Form["Images1Input6"]);
                    new ImagesService().DeleteImage(removeImages1);
                }



                if (ImageFile != null)
                {
                    if (page.MainImage != null)
                    {
                        System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.MainImage));
                    }
                    page.MainImage = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                    ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.MainImage));

                }
                TblCity SearchCityId = new CityService().SelectCityByName(cityName);
                TblTourGuide tourGuide = new TblTourGuide
                {
                    id = page.id,
                    FirstName = page.FirstName,
                    LastName = page.LastName,
                    Description = page.Description,
                    Email = page.Email,
                    MainImage = page.MainImage,
                    Password = page.Password,
                    TellNo = page.TellNo,
                    Username = page.Username,
                    CityId = SearchCityId.id,
                    Discount = page.Discount,
                    Rate = page.Rate,
                    Price = page.Price
                };
                bool guide = new TourGuideService().UpdateTourGuide(tourGuide, page.id);
                foreach (TblImages i in listOfImagesAdd)
                {
                    if (i != null)
                    {
                        new TourGuideImagesRelService().AddTourGuideImagesRel(new TblTourGuideImagesRel(page.id, i.id));
                    }
                }
                _tourGuide.UpdateTourGuide(tourGuide, page.id);
                return RedirectToAction("Index");

            }
            List<TblImages> images2 = new TourGuideService().SelectImagesByTourGuide(page.id);
            ViewBag.CityName = cityName;
            page.Images = new List<string>();
            page.ImagesName = new List<string>();
            page.ImagesId = new List<int>();
            foreach (TblImages i in images2)
            {
                page.Images.Add(i.Image);
                page.ImagesName.Add(i.Name);
                page.ImagesId.Add(i.id);
            }
            return View(page);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTourGuide page = _tourGuide.SelectTourGuideById(id.Value);
            OcRimatours selectOcRimatoursById = new OcRimatours
            {
                FirstName = page.FirstName,
                City = new CityService().SelectCityById(page.CityId).Name,
                id = page.id,
                CityId = page.CityId,
                Description = page.Description,
                Email = page.Email,
                LastName = page.LastName,
                MainImage = page.MainImage,
                Password = page.Password,
                TellNo = page.TellNo,
                Username = page.Username,
                Discount = page.Discount,
                Rate = page.Rate,
                Price = page.Price
            };

            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectOcRimatoursById);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblTourGuide page = _tourGuide.SelectTourGuideById(id);
            if (page.MainImage != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.MainImage));
            }
            List<TblImages> images = new TourGuideService().SelectImagesByTourGuide(page.id);
            foreach (TblImages i in images)
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + i.Image));
            }
            _tourGuide.DeleteTourGuide(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<OcRimatours> tourGuid = new List<OcRimatours>();
            foreach (TblTourGuide i in _tourGuide.SelectAllTourGuides().Where(i => i.Username.ToLower().Contains(q) || i.Username == q || i.Email.ToLower().Contains(q) || i.Email == q).Distinct())
            {
                tourGuid.Add(new OcRimatours(i));
            }
            return View(tourGuid.OrderByDescending(i => i.id));
        }
    }
}
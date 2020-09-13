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
using System.Text;

namespace NTourism.Areas.Admin.Controllers
{
    public class OurServicesController : Controller
    {
        private RoomHomeService _roomHomeService;
        public OurServicesController()
        {
            _roomHomeService = new RoomHomeService();
        }
        // GET: Admin/OurServices
        public ActionResult Index()
        {

            List<OcServices> services = new List<OcServices>();
            foreach (TblRoomHome i in _roomHomeService.SelectAllRoomHomes().OrderByDescending(i => i.id))
            {
                services.Add(new OcServices(i));
            }
            return View(services);
        }
        public ActionResult Create()
        {

            OcServices createServices = new OcServices();
            List<TblFacility> facility = new FacilityService().SelectAllFacilities();
            createServices.Facility = new List<SelectListItem>();
            createServices.FacilityId = new List<int>();
            foreach (TblFacility i in facility)
            {
                SelectListItem c = new SelectListItem();
                c.Text = i.Name;
                c.Selected = true;
                c.Value = i.id.ToString();
                //c.Value = i.Name;
                createServices.Facility.Add(c);
                createServices.FacilityId.Add(i.id);

            }
            return View(createServices);
        }
        // POST: Admin/Pages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,MainImage,Client,PriceNormal,PriceWeekend,DaysOccupaid,OccupaidFrom,OccupaidTo,IsReserved,,IsSelected,City,Description,Comments")] OcServices page, IEnumerable<string> Facility, HttpPostedFileBase ImageFile, HttpPostedFileBase FileImages1, HttpPostedFileBase FileImages2, HttpPostedFileBase FileImages3, HttpPostedFileBase FileImages4, HttpPostedFileBase FileImages5, HttpPostedFileBase FileImages6)
        {
            OcServices createServices = new OcServices();
            List<TblFacility> facility = new FacilityService().SelectAllFacilities();
            createServices.Facility = new List<SelectListItem>();
            createServices.FacilityId = new List<int>();
            foreach (TblFacility i in facility)
            {
                SelectListItem c = new SelectListItem();
                c.Text = i.Name;
                c.Selected = true;
                c.Value = i.id.ToString();
                //c.Value = i.Name;
                createServices.Facility.Add(c);
                createServices.FacilityId.Add(i.id);

            }

            string cityName = Request.Form["cityNames"].ToString();
            string UseNames = Request.Form["UseNames"].ToString();
            if (ModelState.IsValid)
            {
                

                TblRoomHome TestName = new RoomHomeService().SelectRoomHomeByName(page.Name);
                if (TestName.Name != null || TestName.id != -1)
                {
                    ViewBag.Message = "Name is duplicate";
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
                    return View(createServices);

                }
                page.MainImage = Guid.NewGuid() + Path.GetExtension(ImageFile.FileName);
                ImageFile.SaveAs(Server.MapPath("/Resources/Imges/" + page.MainImage));

                TblCity SearchCityId = new CityService().SelectCityByName(cityName);
                TblClient SearchClientId = new ClientService().SelectClientByUsername(UseNames);
                TblRoomHome RoomHome = new TblRoomHome
                {
                    Name = page.Name,
                    MainImage = page.MainImage,
                    ClientId = SearchClientId.id,
                    PriceNormal = page.PriceNormal,
                    PriceWeekend = page.PriceWeekend,
                    DaysOccupaid = page.DaysOccupaid,
                    OccupaidFrom = page.OccupaidFrom,
                    OccupaidTo = page.OccupaidTo,
                    IsReserved = page.IsReserved,
                    CityId = SearchCityId.id,
                    Description=page.Description,
                    IsSelected=page.IsSelected,
                    
                };
                TblRoomHome guide = new RoomHomeService().AddRoomHome(RoomHome);
                foreach (TblImages i in listOfImages)
                {
                    if (i != null)
                    {
                        new RoomHomeImageRelService().AddRoomHomeImageRel(new TblRoomHomeImageRel(guide.id, i.id));

                    }
                }

                List<string> ids = new List<string>();
                if (Facility == null)
                {
                }
                else
                {
                    ids = Facility.Cast<string>().ToList();
                }
                RoomHomeFacilityRelService rels = new RoomHomeFacilityRelService();
                foreach (string i in ids)
                {
                    rels.AddRoomHomeFacilityRel(new TblRoomHomeFacilityRel(guide.id, Convert.ToInt32(i)));
                }

                return RedirectToAction("Index");
            }

            return View(createServices);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblRoomHome page = _roomHomeService.SelectRoomHomeById(id.Value);
            OcServices selectOcServicesById = new OcServices
            {

                id = page.id,
                Name = page.Name,
                MainImage = page.MainImage,
                ClientId = page.ClientId,
                PriceNormal = page.PriceNormal,
                PriceWeekend = page.PriceWeekend,
                DaysOccupaid = page.DaysOccupaid,
                OccupaidFrom = page.OccupaidFrom,
                OccupaidTo = page.OccupaidTo,
                IsReserved = page.IsReserved,
                CityId = page.CityId,
                Description = page.Description,
                IsSelected = page.IsSelected,
                City = new CityService().SelectCityById(page.CityId).Name,
                Client = new ClientService().SelectClientById(page.ClientId),


            };
            List<TblImages> images = new RoomHomeService().SelectImagesByRoomHome(page.id);
            ViewBag.CityName = selectOcServicesById.City;

            ViewBag.Client = selectOcServicesById.Client.Username;

            selectOcServicesById.Images = new List<string>();
            selectOcServicesById.ImagesId = new List<int>();
            selectOcServicesById.ImagesName = new List<string>();
            foreach (TblImages i in images)
            {
                selectOcServicesById.Images.Add(i.Image);
                selectOcServicesById.ImagesName.Add(i.Name);
                selectOcServicesById.ImagesId.Add(i.id);

            }

            //OcServices createServices = new OcServices();
            List<TblFacility> facility = new FacilityService().SelectAllFacilities();
            selectOcServicesById.Facility = new List<SelectListItem>();
            selectOcServicesById.FacilityId = new List<int>();
            foreach (TblFacility i in facility)
            {
                SelectListItem c = new SelectListItem();
                c.Text = i.Name;
                c.Selected = true;
                c.Value = i.id.ToString();
                //c.Value = i.Name;
                selectOcServicesById.Facility.Add(c);
                selectOcServicesById.FacilityId.Add(i.id);

            }
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcServicesById);
        }



        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name, MainImage, Client, PriceNormal, PriceWeekend, DaysOccupaid, OccupaidFrom, OccupaidTo, IsReserved,, IsSelected, City, Description, Comments")] OcServices page, IEnumerable<string> Facility, HttpPostedFileBase ImageFile, HttpPostedFileBase FileImages1, HttpPostedFileBase FileImages2, HttpPostedFileBase FileImages3, HttpPostedFileBase FileImages4, HttpPostedFileBase FileImages5, HttpPostedFileBase FileImages6)
        {
           
            int Images1Input1 = 0;
            int Images1Input2 = 0;
            int Images1Input3 = 0;
            int Images1Input4 = 0;
            int Images1Input5 = 0;
            int Images1Input6 = 0;
            string cityName = Request.Form["cityNames"].ToString();
            string UseNames = Request.Form["UseNames"].ToString();

            if (ModelState.IsValid)
            {
                var TestName = new RoomHomeService().SelectAllRoomHomes().Where(i => i.id != page.id);
                foreach (var item in TestName)
                {
                    if (item.Name == page.Name)
                    {
                        List<TblFacility> facility = new FacilityService().SelectAllFacilities();
                        page.Facility = new List<SelectListItem>();
                        page.FacilityId = new List<int>();
                        foreach (TblFacility i in facility)
                        {
                            SelectListItem c = new SelectListItem();
                            c.Text = i.Name;
                            c.Selected = true;
                            c.Value = i.id.ToString();
                            //c.Value = i.Name;
                            page.Facility.Add(c);
                            page.FacilityId.Add(i.id);

                        }
                        List<TblImages> images = new TourGuideService().SelectImagesByTourGuide(page.id);
                        ViewBag.CityName = cityName;
                        ViewBag.Client = UseNames;
                        page.Images = new List<string>();
                        page.ImagesName = new List<string>();
                        page.ImagesId = new List<int>();
                        foreach (TblImages i in images)
                        {
                            page.Images.Add(i.Image);
                            page.ImagesName.Add(i.Name);
                            page.ImagesId.Add(i.id);
                        }
                        ViewBag.Message = "Name is duplicate";
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
                TblClient SearchClient = new ClientService().SelectClientByUsername(UseNames);
                TblRoomHome servies = new TblRoomHome
                {
                    id = page.id,
                    Description = page.Description,
                    CityId = SearchCityId.id,
                    ClientId= SearchClient.id,
                    DaysOccupaid=page.DaysOccupaid,
                    IsReserved=page.IsReserved,
                    IsSelected=page.IsSelected,
                    MainImage=page.MainImage,
                    Name=page.Name,
                    OccupaidFrom=page.OccupaidFrom,
                    OccupaidTo=page.OccupaidTo,
                    PriceNormal=page.PriceNormal,
                    PriceWeekend=page.PriceWeekend,

                };
                bool guide = new RoomHomeService().UpdateRoomHome(servies, page.id);
                foreach (TblImages i in listOfImagesAdd)
                {
                    if (i != null)
                    {
                        new RoomHomeImageRelService().AddRoomHomeImageRel(new TblRoomHomeImageRel(page.id, i.id));
                    }
                }
                foreach (TblRoomHomeFacilityRel v in new RoomHomeFacilityRelService().SelectRoomHomeFacilityRelByRoomHomeId(page.id))
                {
                    new RoomHomeFacilityRelService().DeleteRoomHomeFacilityRel(v.id);

                }
                List<string> ids = new List<string>();
                if (Facility == null)
                {
                }
                else
                {
                    ids = Facility.Cast<string>().ToList();
                }
                RoomHomeFacilityRelService rels = new RoomHomeFacilityRelService();
                foreach (string i in ids)
                {
                    rels.AddRoomHomeFacilityRel(new TblRoomHomeFacilityRel(page.id, Convert.ToInt32(i)));
                }
                _roomHomeService.UpdateRoomHome(servies, page.id);
                return RedirectToAction("Index");

            }
            List<TblFacility> facility2 = new FacilityService().SelectAllFacilities();
            page.Facility = new List<SelectListItem>();
            page.FacilityId = new List<int>();
            foreach (TblFacility i in facility2)
            {
                SelectListItem c = new SelectListItem();
                c.Text = i.Name;
                c.Selected = true;
                c.Value = i.id.ToString();
                //c.Value = i.Name;
                page.Facility.Add(c);
                page.FacilityId.Add(i.id);

            }
            List<TblImages> images2 = new TourGuideService().SelectImagesByTourGuide(page.id);
            ViewBag.CityName = cityName;
            ViewBag.Client = UseNames;
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
            TblRoomHome page = _roomHomeService.SelectRoomHomeById(id.Value);
            OcServices selectOcServicesById = new OcServices
            {
                ClientId = page.ClientId,
                Client = new ClientService().SelectClientById(page.ClientId),
                CityId = page.ClientId,
                Description = page.Description,
                DaysOccupaid = page.ClientId,
                id = page.ClientId,
                IsReserved = page.IsReserved,
                IsSelected = page.IsSelected,
                Name = page.Name,
                MainImage = page.MainImage,
                City = new CityService().SelectCityById(page.CityId).Name,
                
            };

            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectOcServicesById);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TblRoomHome page = _roomHomeService.SelectRoomHomeById(id);
            if (page.MainImage != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + page.MainImage));
            }
            List<TblImages> images = new RoomHomeService().SelectImagesByRoomHome(page.id);
            foreach (TblImages i in images)
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + i.Image));
            }
            foreach (TblRoomHomeFacilityRel v in new RoomHomeFacilityRelService().SelectRoomHomeFacilityRelByRoomHomeId(page.id))
            {
                new RoomHomeFacilityRelService().DeleteRoomHomeFacilityRel(v.id);

            }
            _roomHomeService.DeleteRoomHome(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<OcServices> services = new List<OcServices>();
            foreach (TblRoomHome i in _roomHomeService.SelectAllRoomHomes().OrderByDescending(i => i.id))
            {
                services.Add(new OcServices(i));
            }
            return View(services.Where(i => i.Name.ToLower().Contains(q) || i.Client.Username.ToLower().Contains(q) || i.Client.Username == q).Distinct());
        }
    }
}
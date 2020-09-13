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
using System.Net.Mail;

namespace NTourism.Areas.Admin.Controllers
{
    public class MedicalController : Controller
    {
        private MedicalServiceRepo _medicalServiceRepo;
        public MedicalController()
        {
            _medicalServiceRepo = new MedicalServiceRepo();
        }
        // GET: Admin/Medical
        public ActionResult Index()
        {
            List<OcMedical> medical = new List<OcMedical>();
            foreach (TblMedicalService i in _medicalServiceRepo.SelectAllMedicalServices())
            {
                medical.Add(new OcMedical(i));
            }
            return View(medical.OrderByDescending(n => n.id));
        }
        public ActionResult Show(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMedicalService page = _medicalServiceRepo.SelectMedicalServiceById(id.Value);
            OcMedical selectOcMedicalById = new OcMedical
            {
                id = page.id,
                FirstName = page.FirstName,
                LastName= page.LastName,
                PassNo= page.PassNo,
                SicknessDesc= page.SicknessDesc,
                SicknessName= page.SicknessName,
                ImageName = new ImagesService().SelectImageById(page.PassportImageId).Image,
                PassportImageId=page.PassportImageId,
                
            };
            List<TblImages> images = new MedicalServiceService().SelectImagessByMedicalServiceId(page.id);
            selectOcMedicalById.Images = new List<string>();
            selectOcMedicalById.ImagesId = new List<int>();
            foreach (TblImages i in images)
            {
                selectOcMedicalById.Images.Add(i.Image);
                selectOcMedicalById.ImagesId.Add(i.id);

            }
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(selectOcMedicalById);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblMedicalService page = _medicalServiceRepo.SelectMedicalServiceById(id.Value);
            OcMedical selectOcTblCityById = new OcMedical
            {
                id = page.id,
                FirstName = page.FirstName,
                LastName = page.LastName,
                SicknessDesc = page.SicknessDesc,
                PassNo = page.PassNo,
                ImageName = new ImagesService().SelectImageById(page.PassportImageId).Image,
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
            TblMedicalService page = _medicalServiceRepo.SelectMedicalServiceById(id);
            TblImages DeletImg = new ImagesService().SelectImageById(page.PassportImageId);
            if (DeletImg.Image != "")
            {
                System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + DeletImg.Image));
            }
            _medicalServiceRepo.DeleteMedicalService(id);
            return RedirectToAction("Index");
        }
    }
}
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
using NTourism.Utilities;

namespace NTourism.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private MainProvider _AboutServices;
        public HomeController()
        {
            _AboutServices = new MainProvider();
        }
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ads()
        {
            return View();
        }
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult DeletImage(string Id12)
        {
            string v1 = Id12;
            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + Id12));
            return View();
        }
        [HttpPost]
        public JsonResult AjaxPostCall(TblImages employeeData)
        {
            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + employeeData.Name));
            return Json("True");
        }


        public ActionResult Edit()
        {
            Tbl4Services page = _AboutServices.Select4ServicesByStatus(4)[0];
            return View(page);
        }
        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Status,Title,Text")] Tbl4Services page)
        {
            if (ModelState.IsValid)
            {
                _AboutServices.Update(page, page.id);
                return RedirectToAction("AboutUs");
            }
            return View(page);
        }
    }
}
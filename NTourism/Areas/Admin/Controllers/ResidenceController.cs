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
    public class ResidenceController : Controller
    {
        // GET: Admin/Residence
        private MainProvider _Residence;
        public ResidenceController()
        {
            _Residence = new MainProvider();
        }
        public ActionResult Index()
        {
            string[] files = System.IO.Directory.GetFiles(Server.MapPath("~/Resources/Residence/"));
            return View(files.ToList());
        }
        public ActionResult DownloadFile(string filename)
        {
            string fullpath = Path.Combine(Server.MapPath("/Resources/Residence/"), filename);
            return File(fullpath, "Resources/Residence/pdf");
        }
        public ActionResult Delete(string filename)
        {
            System.IO.File.Delete(Server.MapPath("/Resources/Residence/" + filename));
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {

            Tbl4Services page = _Residence.Select4ServicesByStatus(3)[0];
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
                _Residence.Update(page, page.id);
                return RedirectToAction("Index");
            }
            return View(page);
        }
    }
}
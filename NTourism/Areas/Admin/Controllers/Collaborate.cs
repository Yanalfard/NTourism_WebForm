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
    public class CollaborateController : Controller
    {
        // GET: Admin/Collaborate
        private MainProvider _Collaborate;
        public CollaborateController()
        {
            _Collaborate = new MainProvider();
        }
        public ActionResult Index()
        {
            string[] files = System.IO.Directory.GetFiles(Server.MapPath("~/Resources/Collaborate/"));
            return View(files.ToList());
        }
        public ActionResult DownloadFile(string filename)
        {
            string fullpath = Path.Combine(Server.MapPath("/Resources/Collaborate/"), filename);
            return File(fullpath, "Resources/Collaborate/pdf");
        }
        public ActionResult Delete(string filename)
        {
            System.IO.File.Delete(Server.MapPath("/Resources/Collaborate/" + filename));
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {

            Tbl4Services page = _Collaborate.Select4ServicesByStatus(2)[0];
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
                _Collaborate.Update(page, page.id);
                return RedirectToAction("Index");
            }
            return View(page);
        }
    }
}
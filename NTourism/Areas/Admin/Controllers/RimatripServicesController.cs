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
    public class RimatripServicesController : Controller
    {
        private MainProvider _rimatripServices;
        public RimatripServicesController()
        {
            _rimatripServices = new MainProvider();
        }
        // GET: Admin/RimatripServices
        public ActionResult Index()
        {
            List<Tbl4Services> services = _rimatripServices.Select4ServicesByStatus(1);
            return View(services);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tbl4Services page = (Tbl4Services)_rimatripServices.SelectById(MainProvider.Tables.Services4, id.Value);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }
        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Status,Title,Text")] Tbl4Services page)
        {
            if (ModelState.IsValid)
            {
                _rimatripServices.Update(page, page.id);
                return RedirectToAction("Index");
            }
            return View(page);
        }
    }
}
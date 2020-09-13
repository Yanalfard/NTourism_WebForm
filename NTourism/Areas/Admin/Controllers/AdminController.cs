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
using System.Web.Security;

namespace NTourism.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private ClientRepo clientRepo;
        public AdminController()
        {
            clientRepo = new ClientRepo();
        }
        // GET: Admin/User
        public ActionResult Index()
        {
            List<TblClient> clients = clientRepo.SelectAllClients();
            return View(clients.Where(i => i.Status == 10));
        }

       
        public ActionResult Login()
        {
            return View();
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblClient page = clientRepo.SelectClientById(id.Value);
            if (page == null)
            {
                return HttpNotFound();
            }
            if (page.Status != 10)
            {
                return HttpNotFound();
            }
            return View(page);
        }

        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,TellNo,Email,Username,Password,Status")] TblClient page, HttpPostedFileBase imgUp)
        {
            if (ModelState.IsValid)
            {
                var TestEmailAndUser = new ClientService().SelectAllClients().Where(i => i.id != page.id);
                foreach (var item in TestEmailAndUser)
                {
                    if (item.Email == page.Email)
                    {
                        ViewBag.Message = "Email is duplicate";
                        return View(page);
                    }
                }
                foreach (var item in TestEmailAndUser)
                {
                    if (item.Username == page.Username)
                    {
                        ViewBag.Message = "Username is duplicate";
                        return View(page);
                    }
                }
                clientRepo.UpdateClient(page, page.id);
                return RedirectToAction("Index");
            }
            return View(page);
        }

       
    }
}
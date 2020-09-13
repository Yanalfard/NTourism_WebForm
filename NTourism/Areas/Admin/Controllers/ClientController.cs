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
    public class ClientController : Controller
    {
        private ClientRepo clientRepo;
        public ClientController()
        {
            clientRepo = new ClientRepo();
        }
        // GET: Admin/User
        public ActionResult Index()
        {
            List<TblClient> clients = clientRepo.SelectAllClients();
            return View(clients.OrderByDescending(n => n.id));
        }

        public ActionResult Create()
        {
            return View(new TblClient());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName,TellNo,Email,Username,Password,Status")] TblClient page)
        {
            if (ModelState.IsValid)
            {
                TblClient TestEmail = new ClientService().SelectClientByEmail(page.Email);
                if (TestEmail.Email != null || TestEmail.id != -1)
                {
                    ViewBag.Message = "Email is duplicate";
                    return View(page);
                }
                TblClient TestUsername = new ClientService().SelectClientByUsername(page.Username);
                if (TestUsername.Username != null || TestUsername.id != -1)
                {
                    ViewBag.Message = "Username is duplicate";
                    return View(page);
                }
                page.Status = 0;
                clientRepo.AddClient(page);
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
            TblClient page = clientRepo.SelectClientById(id.Value);
            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(page);
        }

        // POST: Admin/Pages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var page = clientRepo.SelectClientById(id);
            clientRepo.DeleteClient(id);
            return RedirectToAction("Index");
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

        public ActionResult Search(string q)
        {
            List<TblClient> clients = clientRepo.SelectAllClients();
            return View(clients.OrderByDescending(n => n.id).Where(i => i.Username.ToLower().Contains(q) || i.Username == q || i.Email.ToLower().Contains(q) || i.Email == q).Distinct());
        }
    }
}
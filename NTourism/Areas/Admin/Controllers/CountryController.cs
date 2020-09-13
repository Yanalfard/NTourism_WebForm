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
    public class CountryController : Controller
    {
        // GET: Admin/Country
        private CountryService _country;
        public CountryController()
        {
            _country = new CountryService();
        }
        public ActionResult Index()
        {
            List<TblCountry> countries = _country.SelectAllCountries();
            return View(countries.OrderByDescending(n=>n.id));
        }
        public ActionResult Create()
        {
            return PartialView(new TblCountry());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name")]TblCountry page)
        {
            if (ModelState.IsValid)
            {
                TblCountry TestCountry = new CountryService().SelectCountryByName(page.Name);
                if (TestCountry.Name != null || TestCountry.id != -1)
                {
                    ViewBag.Message = "Name is duplicate";
                    return View(page);
                }
                
                _country.AddCountry(page);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblCountry page = _country.SelectCountryById(id.Value);
            if (page == null)
            {
                return HttpNotFound();
            }
            return PartialView(page);
        }
        // POST: Admin/Pages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name")] TblCountry page)
        {
            if (ModelState.IsValid)
            {
                var TestCountry = new CountryService().SelectAllCountries().Where(i => i.id != page.id);
                foreach (var item in TestCountry)
                {
                    if (item.Name == page.Name)
                    {
                        ViewBag.Message = "Name is duplicate";
                        return View(page);
                    }
                }
                _country.UpdateCountry(page, page.id);
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
            TblCountry page = _country.SelectCountryById(id.Value);
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
            var page = _country.SelectCountryById(id);
            _country.DeleteCountry(id);
            return RedirectToAction("Index");
        }
        public ActionResult Search(string q)
        {
            List<TblCountry> countries = _country.SelectAllCountries();
            return View(countries.OrderByDescending(n => n.id).Where(i => i.Name.ToLower().Contains(q) || i.Name == q ).Distinct());
        }
    }
}
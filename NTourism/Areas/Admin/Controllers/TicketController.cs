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
    public class TicketController : Controller
    {
        private TicketService _ticketService;
        public TicketController()
        {
            _ticketService = new TicketService();
        }

        // GET: Admin/Ticket
        public ActionResult Index()
        {
            List<TblTicket> tickets = _ticketService.SelectTicketByReciverId(1);
            return View(tickets.OrderByDescending(n=>n.id));
        }

        public ActionResult Replay(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTicket page = _ticketService.SelectTicketById(id.Value);
            if (page == null)
            {
                return HttpNotFound();
            }
            return View(page);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TblTicket page = _ticketService.SelectTicketById(id.Value);
            TblTicket selectOcTblCityById = new TblTicket
            {
                id = page.id,
                Name = page.Name,
                Email = page.Email,
                Title = page.Title,
                DateSended = page.DateSended

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
            var page = _ticketService.DeleteTicket(id);
            return RedirectToAction("Index");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using NTourism.Models.Dto;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Controllers
{
    [RoutePrefix("api/TicketCore")]
    public class TicketController : ApiController
    {
        [Route("AddTicket")]
        [HttpPost]
        public IHttpActionResult AddTicket(TblTicket ticket)
        {
            var task = Task.Run(() => new TicketService().AddTicket(ticket));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteTicket")]
        [HttpPost]
        public IHttpActionResult DeleteTicket(int id)
        {
            var task = Task.Run(() => new TicketService().DeleteTicket(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateTicket")]
        [HttpPost]
        public IHttpActionResult UpdateTicket(List<object> ticketLogId)
        {
            TblTicket ticket = JsonConvert.DeserializeObject<TblTicket>(ticketLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(ticketLogId[1].ToString());
            var task = Task.Run(() => new TicketService().UpdateTicket(ticket, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllTickets")]
        [HttpGet]
        public IHttpActionResult SelectAllTickets()
        {
            var task = Task.Run(() => new TicketService().SelectAllTickets());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTicket> dto = new List<DtoTblTicket>();
                    foreach (TblTicket obj in task.Result)
                        dto.Add(new DtoTblTicket(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTicketById")]
        [HttpPost]
        public IHttpActionResult SelectTicketById(int id)
        {
            var task = Task.Run(() => new TicketService().SelectTicketById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTicket(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTicketBySenderId")]
        [HttpPost]
        public IHttpActionResult SelectTicketBySenderId(int senderId)
        {
            var task = Task.Run(() => new TicketService().SelectTicketBySenderId(senderId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTicket> dto = new List<DtoTblTicket>();
                    foreach (TblTicket obj in task.Result)
                        dto.Add(new DtoTblTicket(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTicketByReciverId")]
        [HttpPost]
        public IHttpActionResult SelectTicketByReciverId(int reciverId)
        {
            var task = Task.Run(() => new TicketService().SelectTicketByReciverId(reciverId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTicket> dto = new List<DtoTblTicket>();
                    foreach (TblTicket obj in task.Result)
                        dto.Add(new DtoTblTicket(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTicketByTitle")]
        [HttpPost]
        public IHttpActionResult SelectTicketByTitle(string title)
        {
            var task = Task.Run(() => new TicketService().SelectTicketByTitle(title));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTicket(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

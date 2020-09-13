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
    [RoutePrefix("api/AttractionCore")]
    public class AttractionController : ApiController
    {
        [Route("AddAttraction")]
        [HttpPost]
        public IHttpActionResult AddAttraction(TblAttraction Attraction)
        {
            var task = Task.Run(() => new AttractionService().AddAttraction(Attraction));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteAttraction")]
        [HttpPost]
        public IHttpActionResult DeleteAttraction(int id)
        {
            var task = Task.Run(() => new AttractionService().DeleteAttraction(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateAttraction")]
        [HttpPost]
        public IHttpActionResult UpdateAttraction(List<object> AttractionLogId)
        {
            TblAttraction Attraction = JsonConvert.DeserializeObject<TblAttraction>(AttractionLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(AttractionLogId[1].ToString());
            var task = Task.Run(() => new AttractionService().UpdateAttraction(Attraction, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllAttractions")]
        [HttpGet]
        public IHttpActionResult SelectAllAttractions()
        {
            var task = Task.Run(() => new AttractionService().SelectAllAttractions());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllEvents")]
        [HttpGet]
        public IHttpActionResult SelectAllEvents()
        {
            var task = Task.Run(() => new AttractionService().SelectAllEvents());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        
        [Route("SelectAllTripStories")]
        [HttpGet]
        public IHttpActionResult SelectAllTripStories()
        {
            var task = Task.Run(() => new AttractionService().SelectAllTripStories());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionById")]
        [HttpPost]
        public IHttpActionResult SelectAttractionById(int id)
        {
            var task = Task.Run(() => new AttractionService().SelectAttractionById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblAttraction(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionByName")]
        [HttpPost]
        public IHttpActionResult SelectAttractionByName(string name)
        {
            var task = Task.Run(() => new AttractionService().SelectAttractionByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCommentsByAttraction")]
        [HttpPost]
        public IHttpActionResult SelectCommentsByAttraction(int AttractionId)
        {
            var task = Task.Run(() => new AttractionService().SelectCommentsByAttraction(AttractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblComments> dto = new List<DtoTblComments>();
                    foreach (TblComments obj in task.Result)
                        dto.Add(new DtoTblComments(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAAttraction")]
        [HttpPost]
        public IHttpActionResult SelectAAttraction(string name)
        {
            var task = Task.Run(() => new AttractionService().SelectAAttraction(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectEquipmentByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectEquipmentByAttractionId(int AttractionId)
        {
            var task = Task.Run(() => new AttractionService().SelectEquipmentsByAttraction(AttractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblEquipment> dto = new List<DtoTblEquipment>();
                    foreach (TblEquipment obj in task.Result)
                        dto.Add(new DtoTblEquipment(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectPollByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectPollByAttractionId(int AttractionId)
        {
            var task = Task.Run(() => new AttractionService().SelectPollsByAttraction(AttractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblPoll> dto = new List<DtoTblPoll>();
                    foreach (TblPoll obj in task.Result)
                        dto.Add(new DtoTblPoll(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionByIsSelected")]
        [HttpPost]
        public IHttpActionResult SelectAttractionByIsSelected(bool isSelected)
        {
            var task = Task.Run(() => new AttractionService().SelectAttractionByIsSelected(isSelected));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectEventsByIsSelected")]
        [HttpPost]
        public IHttpActionResult SelectEventsByIsSelected(bool isSelected)
        {
            var task = Task.Run(() => new AttractionService().SelectEventsByIsSelected(isSelected));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTripStoriesByIsSelected")]
        [HttpPost]
        public IHttpActionResult SelectTripStoriesByIsSelected(bool isSelected)
        {
            var task = Task.Run(() => new AttractionService().SelectTripStoriesByIsSelected(isSelected));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAttractionByCityId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionByCityId(int cityId)
        {
            var task = Task.Run(() => new AttractionService().SelectAttractionByCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectEventsByCityId")]
        [HttpPost]
        public IHttpActionResult SelectEventsByCityId(int cityId)
        {
            var task = Task.Run(() => new AttractionService().SelectEventsByCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTripStoriesByCityId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoriesByCityId(int cityId)
        {
            var task = Task.Run(() => new AttractionService().SelectTripStoriesByIsCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionByStatus")]
        [HttpPost]
        public IHttpActionResult SelectAttractionByStatus(int status)
        {
            var task = Task.Run(() => new AttractionService().SelectAttractionByStatus(status));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

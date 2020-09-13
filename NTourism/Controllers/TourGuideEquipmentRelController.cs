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
    [RoutePrefix("api/TourGuideEquipmentRelCore")]
    public class TourGuideEquipmentRelController : ApiController
    {
        [Route("AddTourGuideEquipmentRel")]
        [HttpPost]
        public IHttpActionResult AddTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel)
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().AddTourGuideEquipmentRel(tourGuideEquipmentRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteTourGuideEquipmentRel")]
        [HttpPost]
        public IHttpActionResult DeleteTourGuideEquipmentRel(int id)
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().DeleteTourGuideEquipmentRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateTourGuideEquipmentRel")]
        [HttpPost]
        public IHttpActionResult UpdateTourGuideEquipmentRel(List<object> tourGuideEquipmentRelLogId)
        {
            TblTourGuideEquipmentRel tourGuideEquipmentRel = JsonConvert.DeserializeObject<TblTourGuideEquipmentRel>(tourGuideEquipmentRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tourGuideEquipmentRelLogId[1].ToString());
            var task = Task.Run(() => new TourGuideEquipmentRelService().UpdateTourGuideEquipmentRel(tourGuideEquipmentRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllTourGuideEquipmentRels")]
        [HttpGet]
        public IHttpActionResult SelectAllTourGuideEquipmentRels()
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().SelectAllTourGuideEquipmentRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideEquipmentRel> dto = new List<DtoTblTourGuideEquipmentRel>();
                    foreach (TblTourGuideEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideEquipmentRelById")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideEquipmentRelById(int id)
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuideEquipmentRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideEquipmentRelByEquipmentId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideEquipmentRelByEquipmentId(int equipmentId)
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelByEquipmentId(equipmentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideEquipmentRel> dto = new List<DtoTblTourGuideEquipmentRel>();
                    foreach (TblTourGuideEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideEquipmentRelByTourGuideId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideEquipmentRelByTourGuideId(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideEquipmentRelService().SelectTourGuideEquipmentRelByTourGuideId(tourGuideId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideEquipmentRel> dto = new List<DtoTblTourGuideEquipmentRel>();
                    foreach (TblTourGuideEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

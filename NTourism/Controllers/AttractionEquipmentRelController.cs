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
    [RoutePrefix("api/AttractionEquipmentRelCore")]
    public class AttractionEquipmentRelController : ApiController
    {
        [Route("AddAttractionEquipmentRel")]
        [HttpPost]
        public IHttpActionResult AddAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel)
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().AddAttractionEquipmentRel(AttractionEquipmentRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteAttractionEquipmentRel")]
        [HttpPost]
        public IHttpActionResult DeleteAttractionEquipmentRel(int id)
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().DeleteAttractionEquipmentRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateAttractionEquipmentRel")]
        [HttpPost]
        public IHttpActionResult UpdateAttractionEquipmentRel(List<object> AttractionEquipmentRelLogId)
        {
            TblAttractionEquipmentRel AttractionEquipmentRel = JsonConvert.DeserializeObject<TblAttractionEquipmentRel>(AttractionEquipmentRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(AttractionEquipmentRelLogId[1].ToString());
            var task = Task.Run(() =>
                new AttractionEquipmentRelService().UpdateAttractionEquipmentRel(AttractionEquipmentRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllAttractionEquipmentRels")]
        [HttpGet]
        public IHttpActionResult SelectAllAttractionEquipmentRels()
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().SelectAllAttractionEquipmentRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionEquipmentRel> dto = new List<DtoTblAttractionEquipmentRel>();
                    foreach (TblAttractionEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblAttractionEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionEquipmentRelById")]
        [HttpPost]
        public IHttpActionResult SelectAttractionEquipmentRelById(int id)
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().SelectAttractionEquipmentRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblAttractionEquipmentRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionEquipmentRelByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionEquipmentRelByAttractionId(int ractionId)
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().SelectAttractionEquipmentRelByAttractionId(ractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionEquipmentRel> dto = new List<DtoTblAttractionEquipmentRel>();
                    foreach (TblAttractionEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblAttractionEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionEquipmentRelByEquipmentId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionEquipmentRelByEquipmentId(int ipmentId)
        {
            var task = Task.Run(() => new AttractionEquipmentRelService().SelectAttractionEquipmentRelByEquipmentId(ipmentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionEquipmentRel> dto = new List<DtoTblAttractionEquipmentRel>();
                    foreach (TblAttractionEquipmentRel obj in task.Result)
                        dto.Add(new DtoTblAttractionEquipmentRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }


    }
}

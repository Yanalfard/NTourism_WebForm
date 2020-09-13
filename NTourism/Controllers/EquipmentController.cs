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
    [RoutePrefix("api/EquipmentCore")]
    public class EquipmentController : ApiController
    {
        [Route("AddEquipment")]
        [HttpPost]
        public IHttpActionResult AddEquipment(TblEquipment equipment)
        {
            var task = Task.Run(() => new EquipmentService().AddEquipment(equipment));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteEquipment")]
        [HttpPost]
        public IHttpActionResult DeleteEquipment(int id)
        {
            var task = Task.Run(() => new EquipmentService().DeleteEquipment(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateEquipment")]
        [HttpPost]
        public IHttpActionResult UpdateEquipment(List<object> equipmentLogId)
        {
            TblEquipment equipment = JsonConvert.DeserializeObject<TblEquipment>(equipmentLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(equipmentLogId[1].ToString());
            var task = Task.Run(() => new EquipmentService().UpdateEquipment(equipment, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllEquipments")]
        [HttpGet]
        public IHttpActionResult SelectAllEquipments()
        {
            var task = Task.Run(() => new EquipmentService().SelectAllEquipments());
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

        [Route("SelectEquipmentById")]
        [HttpPost]
        public IHttpActionResult SelectEquipmentById(int id)
        {
            var task = Task.Run(() => new EquipmentService().SelectEquipmentById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblEquipment(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectEquipmentByName")]
        [HttpPost]
        public IHttpActionResult SelectEquipmentByName(string name)
        {
            var task = Task.Run(() => new EquipmentService().SelectEquipmentByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblEquipment(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

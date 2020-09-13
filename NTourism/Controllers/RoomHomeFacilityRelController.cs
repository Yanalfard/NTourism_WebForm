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
    [RoutePrefix("api/RoomHomeFacilityRelCore")]
    public class RoomHomeFacilityRelController : ApiController
    {
        [Route("AddRoomHomeFacilityRel")]
        [HttpPost]
        public IHttpActionResult AddRoomHomeFacilityRel(TblRoomHomeFacilityRel hotelFacilityRel)
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().AddRoomHomeFacilityRel(hotelFacilityRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteRoomHomeFacilityRel")]
        [HttpPost]
        public IHttpActionResult DeleteRoomHomeFacilityRel(int id)
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().DeleteRoomHomeFacilityRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateRoomHomeFacilityRel")]
        [HttpPost]
        public IHttpActionResult UpdateRoomHomeFacilityRel(List<object> hotelFacilityRelLogId)
        {
            TblRoomHomeFacilityRel hotelFacilityRel = JsonConvert.DeserializeObject<TblRoomHomeFacilityRel>(hotelFacilityRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(hotelFacilityRelLogId[1].ToString());
            var task = Task.Run(() => new RoomHomeFacilityRelService().UpdateRoomHomeFacilityRel(hotelFacilityRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllRoomHomeFacilityRels")]
        [HttpGet]
        public IHttpActionResult SelectAllRoomHomeFacilityRels()
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().SelectAllRoomHomeFacilityRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeFacilityRel> dto = new List<DtoTblRoomHomeFacilityRel>();
                    foreach (TblRoomHomeFacilityRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeFacilityRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeFacilityRelById")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeFacilityRelById(int id)
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().SelectRoomHomeFacilityRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblRoomHomeFacilityRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeFacilityRelByFacilityId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeFacilityRelByFacilityId(int facility)
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().SelectRoomHomeFacilityRelByFacilityId(facility));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeFacilityRel> dto = new List<DtoTblRoomHomeFacilityRel>();
                    foreach (TblRoomHomeFacilityRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeFacilityRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeFacilityRelByRoomHomeId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeFacilityRelByRoomHomeId(int roomHomeId)
        {
            var task = Task.Run(() => new RoomHomeFacilityRelService().SelectRoomHomeFacilityRelByRoomHomeId(roomHomeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeFacilityRel> dto = new List<DtoTblRoomHomeFacilityRel>();
                    foreach (TblRoomHomeFacilityRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeFacilityRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

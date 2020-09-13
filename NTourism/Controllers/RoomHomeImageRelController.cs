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
    [RoutePrefix("api/RoomHomeImageRelCore")]
    public class RoomHomeImageRelController : ApiController
    {
        [Route("AddRoomHomeImageRel")]
        [HttpPost]
        public IHttpActionResult AddRoomHomeImageRel(TblRoomHomeImageRel roomHomeImageRel)
        {
            var task = Task.Run(() => new RoomHomeImageRelService().AddRoomHomeImageRel(roomHomeImageRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteRoomHomeImageRel")]
        [HttpPost]
        public IHttpActionResult DeleteRoomHomeImageRel(int id)
        {
            var task = Task.Run(() => new RoomHomeImageRelService().DeleteRoomHomeImageRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateRoomHomeImageRel")]
        [HttpPost]
        public IHttpActionResult UpdateRoomHomeImageRel(List<object> roomHomeImageRelLogId)
        {
            TblRoomHomeImageRel roomHomeImageRel = JsonConvert.DeserializeObject<TblRoomHomeImageRel>(roomHomeImageRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(roomHomeImageRelLogId[1].ToString());
            var task = Task.Run(() => new RoomHomeImageRelService().UpdateRoomHomeImageRel(roomHomeImageRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllRoomHomeImageRels")]
        [HttpGet]
        public IHttpActionResult SelectAllRoomHomeImageRels()
        {
            var task = Task.Run(() => new RoomHomeImageRelService().SelectAllRoomHomeImageRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeImageRel> dto = new List<DtoTblRoomHomeImageRel>();
                    foreach (TblRoomHomeImageRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeImageRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeImageRelById")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeImageRelById(int id)
        {
            var task = Task.Run(() => new RoomHomeImageRelService().SelectRoomHomeImageRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblRoomHomeImageRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeImageRelByImageId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeImageRelByImageId(int imageId)
        {
            var task = Task.Run(() => new RoomHomeImageRelService().SelectRoomHomeImageRelByImageId(imageId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeImageRel> dto = new List<DtoTblRoomHomeImageRel>();
                    foreach (TblRoomHomeImageRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeImageRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeImageRelByRoomHomeId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeImageRelByRoomHomeId(int roomHomeId)
        {
            var task = Task.Run(() => new RoomHomeImageRelService().SelectRoomHomeImageRelByRoomHomeId(roomHomeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeImageRel> dto = new List<DtoTblRoomHomeImageRel>();
                    foreach (TblRoomHomeImageRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeImageRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

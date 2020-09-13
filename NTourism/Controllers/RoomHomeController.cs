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
    [RoutePrefix("api/RoomHomeCore")]
    public class RoomHomeController : ApiController
    {
        [Route("AddRoomHome")]
        [HttpPost]
        public IHttpActionResult AddRoomHome(TblRoomHome roomHome)
        {
            var task = Task.Run(() => new RoomHomeService().AddRoomHome(roomHome));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteRoomHome")]
        [HttpPost]
        public IHttpActionResult DeleteRoomHome(int id)
        {
            var task = Task.Run(() => new RoomHomeService().DeleteRoomHome(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateRoomHome")]
        [HttpPost]
        public IHttpActionResult UpdateRoomHome(List<object> roomHomeLogId)
        {
            TblRoomHome roomHome = JsonConvert.DeserializeObject<TblRoomHome>(roomHomeLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(roomHomeLogId[1].ToString());
            var task = Task.Run(() => new RoomHomeService().UpdateRoomHome(roomHome, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllRoomHomes")]
        [HttpGet]
        public IHttpActionResult SelectAllRoomHomes()
        {
            var task = Task.Run(() => new RoomHomeService().SelectAllRoomHomes());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHome> dto = new List<DtoTblRoomHome>();
                    foreach (TblRoomHome obj in task.Result)
                        dto.Add(new DtoTblRoomHome(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeById")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeById(int id)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblRoomHome(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeByName")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeByName(string name)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblRoomHome(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeByCityId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeByCityId(int cityId)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeByClientId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHome> dto = new List<DtoTblRoomHome>();
                    foreach (TblRoomHome obj in task.Result)
                        dto.Add(new DtoTblRoomHome(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeByIsReserved")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeByIsReserved(bool isReserved)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeByIsReserved(isReserved));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHome> dto = new List<DtoTblRoomHome>();
                    foreach (TblRoomHome obj in task.Result)
                        dto.Add(new DtoTblRoomHome(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectRoomHomeByClientId")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeByClientId(int clientId)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeByClientId(clientId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHome> dto = new List<DtoTblRoomHome>();
                    foreach (TblRoomHome obj in task.Result)
                        dto.Add(new DtoTblRoomHome(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFacilitiesByRoomHome")]
        [HttpPost]
        public IHttpActionResult SelectFacilitiesByRoomHome(int roomHomeId)
        {
            var task = Task.Run(() => new RoomHomeService().SelectFacilitiesByRoomHome(roomHomeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblFacility> dto = new List<DtoTblFacility>();
                    foreach (TblFacility obj in task.Result)
                        dto.Add(new DtoTblFacility(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectImagesByRoomHome")]
        [HttpPost]
        public IHttpActionResult SelectImagesByRoomHome(int roomHomeId)
        {
            var task = Task.Run(() => new RoomHomeService().SelectImagesByRoomHome(roomHomeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblImages> dto = new List<DtoTblImages>();
                    foreach (TblImages obj in task.Result)
                        dto.Add(new DtoTblImages(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCommentsByRoomHome")]
        [HttpPost]
        public IHttpActionResult SelectCommentsByRoomHome(int roomHomeId)
        {
            var task = Task.Run(() => new RoomHomeService().SelectCommentsByRoomHome(roomHomeId));
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

        [Route("SelectRoomHomeByIsSelected")]
        [HttpPost]
        public IHttpActionResult SelectRoomHomeByIsSelected(bool isSelected)
        {
            var task = Task.Run(() => new RoomHomeService().SelectRoomHomeByIsSelected(isSelected));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHome> dto = new List<DtoTblRoomHome>();
                    foreach (TblRoomHome obj in task.Result)
                        dto.Add(new DtoTblRoomHome(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Controllers
{
    [RoutePrefix("api/RoomHomeCommentsRelCore")]
    public class RoomHomeCommentsRelController : ApiController
    {
        [Route("AddHotelCommentsRel")]
        [HttpPost]
        public IHttpActionResult AddHotelCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().AddRoomHomeCommentsRel(hotelCommentsRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteHotelCommentsRel")]
        [HttpPost]
        public IHttpActionResult DeleteHotelCommentsRel(int id)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().DeleteRoomHomeCommentsRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateHotelCommentsRel")]
        [HttpPost]
        public IHttpActionResult UpdateHotelCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, int logId)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().UpdateRoomHomeCommentsRel(hotelCommentsRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllHotelCommentsRels")]
        [HttpGet]
        public IHttpActionResult SelectAllHotelCommentsRels()
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().SelectAllRoomHomeCommentsRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeCommentsRel> dto = new List<DtoTblRoomHomeCommentsRel>();
                    foreach (TblRoomHomeCommentsRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectHotelCommentsRelById")]
        [HttpPost]
        public IHttpActionResult SelectHotelCommentsRelById(int id)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblRoomHomeCommentsRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectHotelCommentsRelByHotelId")]
        [HttpPost]
        public IHttpActionResult SelectHotelCommentsRelByHotelId(int hotelId)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelByRoomHomeId(hotelId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeCommentsRel> dto = new List<DtoTblRoomHomeCommentsRel>();
                    foreach (TblRoomHomeCommentsRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectHotelCommentsRelByCommentId")]
        [HttpPost]
        public IHttpActionResult SelectHotelCommentsRelByCommentId(int commentId)
        {
            var task = Task.Run(() => new RoomHomeCommentsRelService().SelectRoomHomeCommentsRelByCommentId(commentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblRoomHomeCommentsRel> dto = new List<DtoTblRoomHomeCommentsRel>();
                    foreach (TblRoomHomeCommentsRel obj in task.Result)
                        dto.Add(new DtoTblRoomHomeCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

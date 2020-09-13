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
    [RoutePrefix("api/TripStoryCommentRelCore")]
    public class TripStoryCommentRelController : ApiController
    {
        [Route("AddTripStoryCommentRel")]
        [HttpPost]
        public IHttpActionResult AddTripStoryCommentRel(TblTripStoryCommentRel tripStoryCommentRel)
        {
            var task = Task.Run(() => new TripStoryCommentRelService().AddTripStoryCommentRel(tripStoryCommentRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteTripStoryCommentRel")]
        [HttpPost]
        public IHttpActionResult DeleteTripStoryCommentRel(int id)
        {
            var task = Task.Run(() => new TripStoryCommentRelService().DeleteTripStoryCommentRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateTripStoryCommentRel")]
        [HttpPost]
        public IHttpActionResult UpdateTripStoryCommentRel(List<object> tripStoryCommentRelLogId)
        {
            TblTripStoryCommentRel tripStoryCommentRel = JsonConvert.DeserializeObject<TblTripStoryCommentRel>(tripStoryCommentRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tripStoryCommentRelLogId[1].ToString());
            var task = Task.Run(() => new TripStoryCommentRelService().UpdateTripStoryCommentRel(tripStoryCommentRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllTripStoryCommentRels")]
        [HttpGet]
        public IHttpActionResult SelectAllTripStoryCommentRels()
        {
            var task = Task.Run(() => new TripStoryCommentRelService().SelectAllTripStoryCommentRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStoryCommentRel> dto = new List<DtoTblTripStoryCommentRel>();
                    foreach (TblTripStoryCommentRel obj in task.Result)
                        dto.Add(new DtoTblTripStoryCommentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryCommentRelById")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryCommentRelById(int id)
        {
            var task = Task.Run(() => new TripStoryCommentRelService().SelectTripStoryCommentRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTripStoryCommentRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryCommentRelByTripStoryId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryCommentRelByTripStoryId(int pStoryId)
        {
            var task = Task.Run(() => new TripStoryCommentRelService().SelectTripStoryCommentRelByTripStoryId(pStoryId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStoryCommentRel> dto = new List<DtoTblTripStoryCommentRel>();
                    foreach (TblTripStoryCommentRel obj in task.Result)
                        dto.Add(new DtoTblTripStoryCommentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryCommentRelByCommentId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryCommentRelByCommentId(int commentId)
        {
            var task = Task.Run(() => new TripStoryCommentRelService().SelectTripStoryCommentRelByCommentId(commentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStoryCommentRel> dto = new List<DtoTblTripStoryCommentRel>();
                    foreach (TblTripStoryCommentRel obj in task.Result)
                        dto.Add(new DtoTblTripStoryCommentRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

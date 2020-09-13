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
    [RoutePrefix("api/TripStoryCore")]
    public class TripStoryController : ApiController
    {
        [Route("AddTripStory")]
        [HttpPost]
        public IHttpActionResult AddTripStory(TblTripStory tripStory)
        {
            var task = Task.Run(() => new TripStoryService().AddTripStory(tripStory));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteTripStory")]
        [HttpPost]
        public IHttpActionResult DeleteTripStory(int id)
        {
            var task = Task.Run(() => new TripStoryService().DeleteTripStory(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateTripStory")]
        [HttpPost]
        public IHttpActionResult UpdateTripStory(List<object> tripStoryLogId)
        {
            TblTripStory tripStory = JsonConvert.DeserializeObject<TblTripStory>(tripStoryLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tripStoryLogId[1].ToString());
            var task = Task.Run(() => new TripStoryService().UpdateTripStory(tripStory, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllTripStories")]
        [HttpGet]
        public IHttpActionResult SelectAllTripStories()
        {
            var task = Task.Run(() => new TripStoryService().SelectAllTripStorys());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStory> dto = new List<DtoTblTripStory>();
                    foreach (TblTripStory obj in task.Result)
                        dto.Add(new DtoTblTripStory(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryById")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryById(int id)
        {
            var task = Task.Run(() => new TripStoryService().SelectTripStoryById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTripStory(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryByTitle")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryByTitle(string title)
        {
            var task = Task.Run(() => new TripStoryService().SelectTripStoryByTitle(title));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTripStory(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryByCityId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryByCityId(int cityId)
        {
            var task = Task.Run(() => new TripStoryService().SelectTripStoryByCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStory> dto = new List<DtoTblTripStory>();
                    foreach (TblTripStory obj in task.Result)
                        dto.Add(new DtoTblTripStory(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryByTextId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryByTextId(int textId)
        {
            var task = Task.Run(() => new TripStoryService().SelectTripStoryByTextId(textId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStory> dto = new List<DtoTblTripStory>();
                    foreach (TblTripStory obj in task.Result)
                        dto.Add(new DtoTblTripStory(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectTripStoryByImageId")]
        [HttpPost]
        public IHttpActionResult SelectTripStoryByImageId(int imageId)
        {
            var task = Task.Run(() => new TripStoryService().SelectTripStoryByImageId(imageId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTripStory> dto = new List<DtoTblTripStory>();
                    foreach (TblTripStory obj in task.Result)
                        dto.Add(new DtoTblTripStory(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCommentByTripStoryId")]
        [HttpPost]
        public IHttpActionResult SelectCommentByTripStoryId(int tripStoryId)
        {
            var task = Task.Run(() => new TripStoryService().SelectCommentsByTripStory(tripStoryId));
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
    }
}

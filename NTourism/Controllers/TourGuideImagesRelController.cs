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
    [RoutePrefix("api/TourGuideImagesRelCore")]
    public class TourGuideImagesRelController : ApiController
    {
        [Route("AddTourGuideImagesRel")]
        [HttpPost]
        public IHttpActionResult AddTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel)
        {
            var task = Task.Run(() => new TourGuideImagesRelService().AddTourGuideImagesRel(tourGuideImagesRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteTourGuideImagesRel")]
        [HttpPost]
        public IHttpActionResult DeleteTourGuideImagesRel(int id)
        {
            var task = Task.Run(() => new TourGuideImagesRelService().DeleteTourGuideImagesRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateTourGuideImagesRel")]
        [HttpPost]
        public IHttpActionResult UpdateTourGuideImagesRel(List<object> tourGuideImagesRelLogId)
        {
            TblTourGuideImagesRel tourGuideImagesRel = JsonConvert.DeserializeObject<TblTourGuideImagesRel>(tourGuideImagesRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tourGuideImagesRelLogId[1].ToString());
            var task = Task.Run(() => new TourGuideImagesRelService().UpdateTourGuideImagesRel(tourGuideImagesRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllTourGuideImagesRels")]
        [HttpGet]
        public IHttpActionResult SelectAllTourGuideImagesRels()
        {
            var task = Task.Run(() => new TourGuideImagesRelService().SelectAllTourGuideImagesRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideImagesRel> dto = new List<DtoTblTourGuideImagesRel>();
                    foreach (TblTourGuideImagesRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideImagesRelById")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideImagesRelById(int id)
        {
            var task = Task.Run(() => new TourGuideImagesRelService().SelectTourGuideImagesRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuideImagesRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideImagesRelByImageId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideImagesRelByImageId(int imageId)
        {
            var task = Task.Run(() => new TourGuideImagesRelService().SelectTourGuideImagesRelByImageId(imageId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideImagesRel> dto = new List<DtoTblTourGuideImagesRel>();
                    foreach (TblTourGuideImagesRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideImagesRelByTourGuideId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideImagesRelByTourGuideId(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideImagesRelService().SelectTourGuideImagesRelByTourGuideId(tourGuideId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideImagesRel> dto = new List<DtoTblTourGuideImagesRel>();
                    foreach (TblTourGuideImagesRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

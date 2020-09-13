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
    [RoutePrefix("api/TourGuideResumeRelCore")]
    public class TourGuideResumeRelController : ApiController
    {
        [Route("AddTourGuideResumeRel")]
        [HttpPost]
        public IHttpActionResult AddTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel)
        {
            var task = Task.Run(() => new TourGuideResumeRelService().AddTourGuideResumeRel(tourGuideResumeRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteTourGuideResumeRel")]
        [HttpPost]
        public IHttpActionResult DeleteTourGuideResumeRel(int id)
        {
            var task = Task.Run(() => new TourGuideResumeRelService().DeleteTourGuideResumeRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateTourGuideResumeRel")]
        [HttpPost]
        public IHttpActionResult UpdateTourGuideResumeRel(List<object> tourGuideResumeRelLogId)
        {
            TblTourGuideResumeRel tourGuideResumeRel = JsonConvert.DeserializeObject<TblTourGuideResumeRel>(tourGuideResumeRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tourGuideResumeRelLogId[1].ToString());
            var task = Task.Run(() => new TourGuideResumeRelService().UpdateTourGuideResumeRel(tourGuideResumeRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllTourGuideResumeRels")]
        [HttpGet]
        public IHttpActionResult SelectAllTourGuideResumeRels()
        {
            var task = Task.Run(() => new TourGuideResumeRelService().SelectAllTourGuideResumeRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideResumeRel> dto = new List<DtoTblTourGuideResumeRel>();
                    foreach (TblTourGuideResumeRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideResumeRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideResumeRelById")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideResumeRelById(int id)
        {
            var task = Task.Run(() => new TourGuideResumeRelService().SelectTourGuideResumeRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuideResumeRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideResumeRelByResumeId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideResumeRelByResumeId(int resumeId)
        {
            var task = Task.Run(() => new TourGuideResumeRelService().SelectTourGuideResumeRelByResumeId(resumeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideResumeRel> dto = new List<DtoTblTourGuideResumeRel>();
                    foreach (TblTourGuideResumeRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideResumeRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideResumeRelByTourGuideId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideResumeRelByTourGuideId(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideResumeRelService().SelectTourGuideResumeRelByTourGuideId(tourGuideId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuideResumeRel> dto = new List<DtoTblTourGuideResumeRel>();
                    foreach (TblTourGuideResumeRel obj in task.Result)
                        dto.Add(new DtoTblTourGuideResumeRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

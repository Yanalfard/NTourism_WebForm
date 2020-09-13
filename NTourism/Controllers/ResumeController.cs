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
    [RoutePrefix("api/ResumeCore")]
    public class ResumeController : ApiController
    {
        [Route("AddResume")]
        [HttpPost]
        public IHttpActionResult AddResume(TblResume resume)
        {
            var task = Task.Run(() => new ResumeService().AddResume(resume));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteResume")]
        [HttpPost]
        public IHttpActionResult DeleteResume(int id)
        {
            var task = Task.Run(() => new ResumeService().DeleteResume(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateResume")]
        [HttpPost]
        public IHttpActionResult UpdateResume(List<object> resumeLogId)
        {
            TblResume text = JsonConvert.DeserializeObject<TblResume>(resumeLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(resumeLogId[1].ToString());
            var task = Task.Run(() => new ResumeService().UpdateResume(text, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllResumes")]
        [HttpGet]
        public IHttpActionResult SelectAllResumes()
        {
            var task = Task.Run(() => new ResumeService().SelectAllResumes());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblResume> dto = new List<DtoTblResume>();
                    foreach (TblResume obj in task.Result)
                        dto.Add(new DtoTblResume(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectResumeById")]
        [HttpPost]
        public IHttpActionResult SelectResumeById(int id)
        {
            var task = Task.Run(() => new ResumeService().SelectResumeById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblResume(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectResumeByName")]
        [HttpPost]
        public IHttpActionResult SelectResumeByName(string name)
        {
            var task = Task.Run(() => new ResumeService().SelectResumeByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblResume(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

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
    [RoutePrefix("api/PollCore")]
    public class PollController : ApiController
    {
        [Route("AddPoll")]
        [HttpPost]
        public IHttpActionResult AddPoll(TblPoll poll)
        {
            var task = Task.Run(() => new PollService().AddPoll(poll));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeletePoll")]
        [HttpPost]
        public IHttpActionResult DeletePoll(int id)
        {
            var task = Task.Run(() => new PollService().DeletePoll(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdatePoll")]
        [HttpPost]
        public IHttpActionResult UpdatePoll(List<object> pollLogId)
        {
            TblPoll poll = JsonConvert.DeserializeObject<TblPoll>(pollLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(pollLogId[1].ToString());
            var task = Task.Run(() => new PollService().UpdatePoll(poll, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllPolls")]
        [HttpGet]
        public IHttpActionResult SelectAllPolls()
        {
            var task = Task.Run(() => new PollService().SelectAllPolls());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblPoll> dto = new List<DtoTblPoll>();
                    foreach (TblPoll obj in task.Result)
                        dto.Add(new DtoTblPoll(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectPollById")]
        [HttpPost]
        public IHttpActionResult SelectPollById(int id)
        {
            var task = Task.Run(() => new PollService().SelectPollById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblPoll(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectPollByName")]        [HttpPost]
        public IHttpActionResult SelectPollByName(string name)
        {
            var task = Task.Run(() => new PollService().SelectPollByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblPoll(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

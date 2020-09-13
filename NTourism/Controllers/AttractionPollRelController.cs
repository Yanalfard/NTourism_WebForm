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
    [RoutePrefix("api/AttractionPollRelCore")]
    public class AttractionPollRelController : ApiController
    {
        [Route("AddAttractionPollRel")]
        [HttpPost]
        public IHttpActionResult AddAttractionPollRel(TblAttractionPollRel AttractionPollRel)
        {
            var task = Task.Run(() => new AttractionPollRelService().AddAttractionPollRel(AttractionPollRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteAttractionPollRel")]
        [HttpPost]
        public IHttpActionResult DeleteAttractionPollRel(int id)
        {
            var task = Task.Run(() => new AttractionPollRelService().DeleteAttractionPollRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateAttractionPollRel")]
        [HttpPost]
        public IHttpActionResult UpdateAttractionPollRel(List<object> AttractionPollRelLogId)
        {
            TblAttractionPollRel AttractionPollRel = JsonConvert.DeserializeObject<TblAttractionPollRel>(AttractionPollRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(AttractionPollRelLogId[1].ToString());
            var task = Task.Run(() => new AttractionPollRelService().UpdateAttractionPollRel(AttractionPollRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllAttractionPollRels")]
        [HttpGet]
        public IHttpActionResult SelectAllAttractionPollRels()
        {
            var task = Task.Run(() => new AttractionPollRelService().SelectAllAttractionPollRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionPollRel> dto = new List<DtoTblAttractionPollRel>();
                    foreach (TblAttractionPollRel obj in task.Result)
                        dto.Add(new DtoTblAttractionPollRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionPollRelById")]
        [HttpPost]
        public IHttpActionResult SelectAttractionPollRelById(int id)
        {
            var task = Task.Run(() => new AttractionPollRelService().SelectAttractionPollRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblAttractionPollRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionPollRelByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionPollRelByAttractionId(int ractionId)
        {
            var task = Task.Run(() => new AttractionPollRelService().SelectAttractionPollRelByAttractionId(ractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionPollRel> dto = new List<DtoTblAttractionPollRel>();
                    foreach (TblAttractionPollRel obj in task.Result)
                        dto.Add(new DtoTblAttractionPollRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionPollRelByPollId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionPollRelByPollId(int lId)
        {
            var task = Task.Run(() => new AttractionPollRelService().SelectAttractionPollRelByPollId(lId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionPollRel> dto = new List<DtoTblAttractionPollRel>();
                    foreach (TblAttractionPollRel obj in task.Result)
                        dto.Add(new DtoTblAttractionPollRel(obj, HttpStatusCode.OK));
                    return Ok(task.Result);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }


    }
}

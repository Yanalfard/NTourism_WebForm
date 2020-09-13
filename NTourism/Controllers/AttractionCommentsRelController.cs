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
    [RoutePrefix("api/AttractionCommentsRelCore")]
    public class AttractionCommentsRelController : ApiController
    {
        [Route("AddAttractionCommentsRel")]
        [HttpPost]
        public IHttpActionResult AddAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel)
        {
            var task = Task.Run(() => new AttractionCommentsRelService().AddAttractionCommentsRel(AttractionCommentsRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteAttractionCommentsRel")]
        [HttpPost]
        public IHttpActionResult DeleteAttractionCommentsRel(int id)
        {
            var task = Task.Run(() => new AttractionCommentsRelService().DeleteAttractionCommentsRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateAttractionCommentsRel")]
        [HttpPost]
        public IHttpActionResult UpdateAttractionCommentsRel(List<object> AttractionCommentsRelLogId)
        {
            TblAttractionCommentsRel AttractionCommentsRel = JsonConvert.DeserializeObject<TblAttractionCommentsRel>(AttractionCommentsRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(AttractionCommentsRelLogId[1].ToString());
            var task = Task.Run(() => new AttractionCommentsRelService().UpdateAttractionCommentsRel(AttractionCommentsRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllAttractionCommentsRels")]
        [HttpGet]
        public IHttpActionResult SelectAllAttractionCommentsRels()
        {
            var task = Task.Run(() => new AttractionCommentsRelService().SelectAllAttractionCommentsRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionCommentsRel> dto = new List<DtoTblAttractionCommentsRel>();
                    foreach (TblAttractionCommentsRel obj in task.Result)
                        dto.Add(new DtoTblAttractionCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionCommentsRelById")]
        [HttpPost]
        public IHttpActionResult SelectAttractionCommentsRelById(int id)
        {
            var task = Task.Run(() => new AttractionCommentsRelService().SelectAttractionCommentsRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblAttractionCommentsRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionCommentsRelByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionCommentsRelByAttractionId(int AttractionId)
        {
            var task = Task.Run(() => new AttractionCommentsRelService().SelectAttractionCommentsRelByAttractionId(AttractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionCommentsRel> dto = new List<DtoTblAttractionCommentsRel>();
                    foreach (TblAttractionCommentsRel obj in task.Result)
                        dto.Add(new DtoTblAttractionCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAttractionCommentsRelByCommentId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionCommentsRelByCommentId(int commentId)
        {
            var task = Task.Run(() => new AttractionCommentsRelService().SelectAttractionCommentsRelByCommentId(commentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttractionCommentsRel> dto = new List<DtoTblAttractionCommentsRel>();
                    foreach (TblAttractionCommentsRel obj in task.Result)
                        dto.Add(new DtoTblAttractionCommentsRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

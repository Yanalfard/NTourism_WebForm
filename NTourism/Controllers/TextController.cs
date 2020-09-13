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
    [RoutePrefix("api/TextCore")]
    public class TextController : ApiController
    {
        [Route("AddClient")]
        [HttpPost]
        public IHttpActionResult AddText(TblText text)
        {
            var task = Task.Run(() => new TextService().AddText(text));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteText")]
        [HttpPost]
        public IHttpActionResult DeleteText(int id)
        {
            var task = Task.Run(() => new TextService().DeleteText(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateText")]
        [HttpPost]
        public IHttpActionResult UpdateText(List<object> textLogId)
        {
            TblText text = JsonConvert.DeserializeObject<TblText>(textLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(textLogId[1].ToString());
            var task = Task.Run(() => new TextService().UpdateText(text, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllTexts")]
        [HttpGet]
        public IHttpActionResult SelectAllTexts()
        {
            var task = Task.Run(() => new TextService().SelectAllTexts());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblText> dto = new List<DtoTblText>();
                    foreach (TblText obj in task.Result)
                        dto.Add(new DtoTblText(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTextById")]
        [HttpPost]
        public IHttpActionResult SelectTextById(int id)
        {
            var task = Task.Run(() => new TextService().SelectTextById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblText(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

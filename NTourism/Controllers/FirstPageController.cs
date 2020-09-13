using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using NTourism.Models.Dto;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Controllers
{
    [RoutePrefix("api/FirstPageCore")]
    public class FirstPageController : ApiController
    {
        [Route("AddFirstPage")]
        [HttpPost]
        public IHttpActionResult AddFirstPage(TblFirstPage firstPage)
        {
            var task = Task.Run(() => new FirstPageService().AddFirstPage(firstPage));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblFirstPage(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteFirstPage")]
        [HttpPost]
        public IHttpActionResult DeleteFirstPage(int id)
        {
            var task = Task.Run(() => new FirstPageService().DeleteFirstPage(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateFirstPage")]
        [HttpPost]
        public IHttpActionResult UpdateFirstPage(List<object> firstPageLogId)
        {
            TblFirstPage firstPage = JsonConvert.DeserializeObject<TblFirstPage>(firstPageLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(firstPageLogId[1].ToString());
            var task = Task.Run(() => new FirstPageService().UpdateFirstPage(firstPage, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllFirstPages")]
        [HttpGet]
        public IHttpActionResult SelectAllFirstPages()
        {
            var task = Task.Run(() => new FirstPageService().SelectAllFirstPages());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblFirstPage> dto = new List<DtoTblFirstPage>();
                    foreach (TblFirstPage obj in task.Result)
                        dto.Add(new DtoTblFirstPage(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFirstPageById")]
        [HttpPost]
        public IHttpActionResult SelectFirstPageById(int id)
        {
            var task = Task.Run(() => new FirstPageService().SelectFirstPageById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblFirstPage(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFirstPageByImage")]
        [HttpPost]
        public IHttpActionResult SelectFirstPageByImage(string image)
        {
            var task = Task.Run(() => new FirstPageService().SelectFirstPageByImage(image));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblFirstPage(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFirstPageByIsText")]
        [HttpPost]
        public IHttpActionResult SelectFirstPageByIsText(bool isText)
        {
            var task = Task.Run(() => new FirstPageService().SelectFirstPageByIsText(isText));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblFirstPage> dto = new List<DtoTblFirstPage>();
                    foreach (TblFirstPage obj in task.Result)
                        dto.Add(new DtoTblFirstPage(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }


    }
}

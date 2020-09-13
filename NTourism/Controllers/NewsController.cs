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
    [RoutePrefix("api/NewsCore")]
    public class NewsController : ApiController
    {
        [Route("AddNews")]
        [HttpPost]
        public IHttpActionResult AddNews(TblNews news)
        {
            var task = Task.Run(() => new NewsService().AddNews(news));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteNews")]
        [HttpPost]
        public IHttpActionResult DeleteNews(int id)
        {
            var task = Task.Run(() => new NewsService().DeleteNews(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateNews")]
        [HttpPost]
        public IHttpActionResult UpdateNews(List<object> newsLogId)
        {
            TblNews text = JsonConvert.DeserializeObject<TblNews>(newsLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(newsLogId[1].ToString());
            var task = Task.Run(() => new NewsService().UpdateNews(text, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllNews")]
        [HttpGet]
        public IHttpActionResult SelectAllNews()
        {
            var task = Task.Run(() => new NewsService().SelectAllNews());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsById")]
        [HttpPost]
        public IHttpActionResult SelectNewsById(int id)
        {
            var task = Task.Run(() => new NewsService().SelectNewsById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblNews(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsByName")]
        [HttpPost]
        public IHttpActionResult SelectNewsByName(string name)
        {
            var task = Task.Run(() => new NewsService().SelectNewsByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsByOrder")]
        [HttpPost]
        public IHttpActionResult SelectNewsByOrder(string name)
        {
            var task = Task.Run(() => new NewsService().SelectNewsByOrder(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsByTextId")]
        [HttpPost]
        public IHttpActionResult SelectNewsByTextId(int textId)
        {
            var task = Task.Run(() => new NewsService().SelectNewsByTextId(textId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsByImageId")]
        [HttpPost]
        public IHttpActionResult SelectNewsByImageId(int imageId)
        {
            var task = Task.Run(() => new NewsService().SelectNewsByImageId(imageId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectANews")]
        [HttpPost]
        public IHttpActionResult SelectANews(string name)
        {
            var task = Task.Run(() => new NewsService().SelectANews(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectNewsByIsSelected")]
        [HttpPost]
        public IHttpActionResult SelectNewsByIsSelected(bool isSelected)
        {
            var task = Task.Run(() => new NewsService().SelectNewsByIsSelected(isSelected));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTopRandomNews")]
        [HttpPost]
        public IHttpActionResult SelectTopRandomNews(int count)
        {
            var task = Task.Run(() => new NewsService().SelectTopRandomNews(count));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblNews> dto = new List<DtoTblNews>();
                    foreach (TblNews obj in task.Result)
                        dto.Add(new DtoTblNews(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

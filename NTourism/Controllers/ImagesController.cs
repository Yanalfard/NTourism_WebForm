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
    [RoutePrefix("api/ImagesCore")]
    public class ImagesController : ApiController
    {
        [Route("AddImage")]
        [HttpPost]
        public IHttpActionResult AddImage(TblImages image)
        {
            var task = Task.Run(() => new ImagesService().AddImage(image));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(task.Result);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteImage")]
        [HttpPost]
        public IHttpActionResult DeleteImage(int id)
        {
            var task = Task.Run(() => new ImagesService().DeleteImage(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
                
        [Route("UpdateImage")]
        [HttpPost]
        public IHttpActionResult UpdateImage(List<object> imageLogId)
        {
            TblImages image = JsonConvert.DeserializeObject<TblImages>(imageLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(imageLogId[1].ToString());
            var task = Task.Run(() => new ImagesService().UpdateImage(image, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllImages")]
        [HttpGet]
        public IHttpActionResult SelectAllImages()
        {
            var task = Task.Run(() => new ImagesService().SelectAllImages());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblImages> dto = new List<DtoTblImages>();
                    foreach (TblImages obj in task.Result)
                        dto.Add(new DtoTblImages(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectImageById")]
        [HttpPost]
        public IHttpActionResult SelectImageById(int id)
        {
            var task = Task.Run(() => new ImagesService().SelectImageById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblImages(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        
        [Route("SelectImagesByName")]
        [HttpPost]
        public IHttpActionResult SelectImagesByName(string name)
        {
            var task = Task.Run(() => new ImagesService().SelectImagesByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblImages> dto = new List<DtoTblImages>();
                    foreach (TblImages obj in task.Result)
                        dto.Add(new DtoTblImages(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

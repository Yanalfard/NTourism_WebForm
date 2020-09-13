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
    [RoutePrefix("api/AdCore")]
    public class AdController : ApiController
    {
        [Route("AddAd")]
        [HttpPost]
        public IHttpActionResult AddAd(TblAd ad)
        {
            var task = Task.Run(() => new AdService().AddAd(ad));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteAd")]
        [HttpPost]
        public IHttpActionResult DeleteAd(int id)
        {
            var task = Task.Run(() => new AdService().DeleteAd(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateAd")]
        [HttpPost]
        public IHttpActionResult UpdateAd(List<object> adLogId)
        {
            TblAd ad = JsonConvert.DeserializeObject<TblAd>(adLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(adLogId[1].ToString());
            var task = Task.Run(() => new AdService().UpdateAd(ad, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllAds")]
        [HttpGet]
        public IHttpActionResult SelectAllAds()
        {
            var task = Task.Run(() => new AdService().SelectAllAds());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAd> dto = new List<DtoTblAd>();
                    foreach (TblAd obj in task.Result)
                        dto.Add(new DtoTblAd(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAdById")]
        [HttpPost]
        public IHttpActionResult SelectAdById(int id)
        {
            var task = Task.Run(() => new AdService().SelectAdById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblAd(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAdByImage")]
        [HttpPost]
        public IHttpActionResult SelectAdByImage(string image)
        {
            var task = Task.Run(() => new AdService().SelectAdByImage(image));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblAd(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAdByPositionId")]
        [HttpPost]
        public IHttpActionResult SelectAdByPositionId(int positionId)
        {
            var task = Task.Run(() => new AdService().SelectAdByPositionId(positionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAd> dto = new List<DtoTblAd>();
                    foreach (TblAd obj in task.Result)
                        dto.Add(new DtoTblAd(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAdByIsAvailable")]
        [HttpPost]
        public IHttpActionResult SelectAdByIsAvailable(bool isAvailable)
        {
            var task = Task.Run(() => new AdService().SelectAdByIsAvailable(isAvailable));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAd> dto = new List<DtoTblAd>();
                    foreach (TblAd obj in task.Result)
                        dto.Add(new DtoTblAd(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

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
    [RoutePrefix("api/CityAttractionRelCore")]
    public class CityAttractionRelController : ApiController
    {
        [Route("AddCityAttractionRel")]
        [HttpPost]
        public IHttpActionResult AddCityAttractionRel(TblCityAttractionRel cityAttractionRel)
        {
            var task = Task.Run(() => new CityAttractionRelService().AddCityAttractionRel(cityAttractionRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCityAttractionRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteCityAttractionRel")]
        [HttpPost]
        public IHttpActionResult DeleteCityAttractionRel(int id)
        {
            var task = Task.Run(() => new CityAttractionRelService().DeleteCityAttractionRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateCityAttractionRel")]
        [HttpPost]
        public IHttpActionResult UpdateCityAttractionRel(List<object> cityAttractionRelLogId)
        {
            TblCityAttractionRel cityAttractionRel = JsonConvert.DeserializeObject<TblCityAttractionRel>(cityAttractionRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(cityAttractionRelLogId[1].ToString());
            var task = Task.Run(() => new CityAttractionRelService().UpdateCityAttractionRel(cityAttractionRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllCityAttractionRels")]
        [HttpGet]
        public IHttpActionResult SelectAllCityAttractionRels()
        {
            var task = Task.Run(() => new CityAttractionRelService().SelectAllCityAttractionRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCityAttractionRel> dto = new List<DtoTblCityAttractionRel>();
                    foreach (TblCityAttractionRel obj in task.Result)
                        dto.Add(new DtoTblCityAttractionRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCityAttractionRelById")]
        [HttpPost]
        public IHttpActionResult SelectCityAttractionRelById(int id)
        {
            var task = Task.Run(() => new CityAttractionRelService().SelectCityAttractionRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblCityAttractionRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCityAttractionRelByAttractionId")]
        [HttpPost]
        public IHttpActionResult SelectCityAttractionRelByAttractionId(int ractionId)
        {
            var task = Task.Run(() => new CityAttractionRelService().SelectCityAttractionRelByAttractionId(ractionId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCityAttractionRel> dto = new List<DtoTblCityAttractionRel>();
                    foreach (TblCityAttractionRel obj in task.Result)
                        dto.Add(new DtoTblCityAttractionRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCityAttractionRelByRoomHomeId")]
        [HttpPost]
        public IHttpActionResult SelectCityAttractionRelByRoomHomeId(int mHomeId)
        {
            var task = Task.Run(() => new CityAttractionRelService().SelectCityAttractionRelByRoomHomeId(mHomeId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCityAttractionRel> dto = new List<DtoTblCityAttractionRel>();
                    foreach (TblCityAttractionRel obj in task.Result)
                        dto.Add(new DtoTblCityAttractionRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectCityAttractionRelByCityId")]
        [HttpPost]
        public IHttpActionResult SelectCityAttractionRelByCityId(int yId)
        {
            var task = Task.Run(() => new CityAttractionRelService().SelectCityAttractionRelByCityId(yId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCityAttractionRel> dto = new List<DtoTblCityAttractionRel>();
                    foreach (TblCityAttractionRel obj in task.Result)
                        dto.Add(new DtoTblCityAttractionRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

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
    [RoutePrefix("api/CityCore")]
    public class CityController : ApiController
    {
        [Route("helloCore")]
        [HttpGet]
        public string Hello()
        {
            return "hello";
        }

        [Route("AddCity")]
        [HttpPost]
        public IHttpActionResult AddCity(TblCity city)
        {
            var task = Task.Run(() => new CityService().AddCity(city));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteCity")]
        [HttpPost]
        public IHttpActionResult DeleteCity(int id)
        {
            var task = Task.Run(() => new CityService().DeleteCity(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateCity")]
        [HttpPost]
        public IHttpActionResult UpdateCity(List<object> cityLogId)
        {
            TblCity city = JsonConvert.DeserializeObject<TblCity>(cityLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(cityLogId[1].ToString());
            var task = Task.Run(() => new CityService().UpdateCity(city, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        
        [Route("SelectAllCities")]
        [HttpGet]
        public IHttpActionResult SelectAllCities()
        {
            var task = Task.Run(() => new CityService().SelectAllCities());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCity> dto = new List<DtoTblCity>();
                    foreach (TblCity obj in task.Result)
                        dto.Add(new DtoTblCity(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCityById")]
        [HttpPost]
        public IHttpActionResult SelectCityById(int id)
        {
            var task = Task.Run(() => new CityService().SelectCityById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblCity(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCityByName")]
        [HttpPost]
        public IHttpActionResult SelectCityByName(string name)
        {
            var task = Task.Run(() => new CityService().SelectCityByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblCity(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCityByCountryId")]
        [HttpPost]
        public IHttpActionResult SelectCityByCountryId(int countryId)
        {
            var task = Task.Run(() => new CityService().SelectCityByCountryId(countryId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblCity> dto = new List<DtoTblCity>();
                    foreach (TblCity obj in task.Result)
                        dto.Add(new DtoTblCity(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAttractionByCityId")]
        [HttpPost]
        public IHttpActionResult SelectAttractionByCityId(int cityId)
        {
            var task = Task.Run(() => new CityService().SelectAttractionsByCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblAttraction> dto = new List<DtoTblAttraction>();
                    foreach (TblAttraction obj in task.Result)
                        dto.Add(new DtoTblAttraction(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

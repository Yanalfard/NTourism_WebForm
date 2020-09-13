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
    [RoutePrefix("api/FacilityCore")]
    public class FacilityController : ApiController
    {
        [Route("AddFacility")]
        [HttpPost]
        public IHttpActionResult AddFacility(TblFacility facility)
        {
            var task = Task.Run(() => new FacilityService().AddFacility(facility));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteFacility")]
        [HttpPost]
        public IHttpActionResult DeleteFacility(int id)
        {
            var task = Task.Run(() => new FacilityService().DeleteFacility(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateFacility")]
        [HttpPost]
        public IHttpActionResult UpdateFacility(List<object> facilityLogId)
        {
            TblFacility facility = JsonConvert.DeserializeObject<TblFacility>(facilityLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(facilityLogId[1].ToString());
            var task = Task.Run(() => new FacilityService().UpdateFacility(facility, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllFacilities")]
        [HttpGet]
        public IHttpActionResult SelectAllFacilities()
        {
            var task = Task.Run(() => new FacilityService().SelectAllFacilities());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblFacility> dto = new List<DtoTblFacility>();
                    foreach (TblFacility obj in task.Result)
                        dto.Add(new DtoTblFacility(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFacilityById")]
        [HttpPost]
        public IHttpActionResult SelectFacilityById(int id)
        {
            var task = Task.Run(() => new FacilityService().SelectFacilityById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblFacility(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectFacilityByName")]
        [HttpPost]
        public IHttpActionResult SelectFacilityByName(string name)
        {
            var task = Task.Run(() => new FacilityService().SelectFacilityByName(name));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblFacility(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

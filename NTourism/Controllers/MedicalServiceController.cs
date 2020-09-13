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
    [RoutePrefix("api/MedicalServiceCore")]
    public class MedicalServiceController : ApiController
    {
        [Route("AddMedicalService")]
        [HttpPost]
        public IHttpActionResult AddMedicalService(TblMedicalService medicalService)
        {
            var task = Task.Run(() => new MedicalServiceService().AddMedicalService(medicalService));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteMedicalService")]
        [HttpPost]
        public IHttpActionResult DeleteMedicalService(int id)
        {
            var task = Task.Run(() => new MedicalServiceService().DeleteMedicalService(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateMedicalService")]
        [HttpPost]
        public IHttpActionResult UpdateMedicalService(List<object> medicalServiceLogId)
        {
            TblMedicalService medicalService = JsonConvert.DeserializeObject<TblMedicalService>(medicalServiceLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(medicalServiceLogId[1].ToString());
            var task = Task.Run(() => new MedicalServiceService().UpdateMedicalService(medicalService, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllMedicalServices")]
        [HttpGet]
        public IHttpActionResult SelectAllMedicalServices()
        {
            var task = Task.Run(() => new MedicalServiceService().SelectAllMedicalServices());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblMedicalService> dto = new List<DtoTblMedicalService>();
                    foreach (TblMedicalService obj in task.Result)
                        dto.Add(new DtoTblMedicalService(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceById")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceById(int id)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectMedicalServiceById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblMedicalService(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceByFirstName")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceByFirstName(string firstName)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectMedicalServiceByFirstName(firstName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblMedicalService(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceByLastName")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceByLastName(string lastName)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectMedicalServiceByLastName(lastName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblMedicalService(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceBySicknessName")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceBySicknessName(string sicknessName)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectMedicalServiceBySicknessName(sicknessName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblMedicalService(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceByPassportImageId")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceByPassportImageId(int passportImageId)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectMedicalServiceByPassportImageId(passportImageId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblMedicalService> dto = new List<DtoTblMedicalService>();
                    foreach (TblMedicalService obj in task.Result)
                        dto.Add(new DtoTblMedicalService(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectImagesByMedicalServiceId")]
        [HttpPost]
        public IHttpActionResult SelectImagesByMedicalServiceId(int medicalServiceId)
        {
            var task = Task.Run(() => new MedicalServiceService().SelectImagessByMedicalServiceId(medicalServiceId));
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

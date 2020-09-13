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
    [RoutePrefix("api/MedicalServiceImagesRelCore")]
    public class MedicalServiceImagesRelController : ApiController
    {
        [Route("AddMedicalServiceImagesRel")]
        [HttpPost]
        public IHttpActionResult AddMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel)
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().AddMedicalServiceImagesRel(medicalServiceImagesRel));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("DeleteMedicalServiceImagesRel")]
        [HttpPost]
        public IHttpActionResult DeleteMedicalServiceImagesRel(int id)
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().DeleteMedicalServiceImagesRel(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("UpdateMedicalServiceImagesRel")]
        [HttpPost]
        public IHttpActionResult UpdateMedicalServiceImagesRel(List<object> medicalServiceImagesRelLogId)
        {
            TblMedicalServiceImagesRel medicalServiceImagesRel = JsonConvert.DeserializeObject<TblMedicalServiceImagesRel>(medicalServiceImagesRelLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(medicalServiceImagesRelLogId[1].ToString());
            var task = Task.Run(() => new MedicalServiceImagesRelService().UpdateMedicalServiceImagesRel(medicalServiceImagesRel, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAllMedicalServiceImagesRels")]
        [HttpGet]
        public IHttpActionResult SelectAllMedicalServiceImagesRels()
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().SelectAllMedicalServiceImagesRels());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblMedicalServiceImagesRel> dto = new List<DtoTblMedicalServiceImagesRel>();
                    foreach (TblMedicalServiceImagesRel obj in task.Result)
                        dto.Add(new DtoTblMedicalServiceImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceImagesRelById")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceImagesRelById(int id)
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().SelectMedicalServiceImagesRelById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblMedicalServiceImagesRel(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceImagesRelsByMedicalServiceId")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceImagesRelByMedicalServiceId(int icalServiceId)
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().SelectMedicalServiceImagesRelByMedicalServiceId(icalServiceId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblMedicalServiceImagesRel> dto = new List<DtoTblMedicalServiceImagesRel>();
                    foreach (TblMedicalServiceImagesRel obj in task.Result)
                        dto.Add(new DtoTblMedicalServiceImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectMedicalServiceImagesRelsByImageId")]
        [HttpPost]
        public IHttpActionResult SelectMedicalServiceImagesRelByImageId(int geId)
        {
            var task = Task.Run(() => new MedicalServiceImagesRelService().SelectMedicalServiceImagesRelByImageId(geId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblMedicalServiceImagesRel> dto = new List<DtoTblMedicalServiceImagesRel>();
                    foreach (TblMedicalServiceImagesRel obj in task.Result)
                        dto.Add(new DtoTblMedicalServiceImagesRel(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

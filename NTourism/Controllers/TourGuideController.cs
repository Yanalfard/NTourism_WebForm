using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;
using NTourism.Services.Impl;
using System.Linq;
using Newtonsoft.Json;

namespace NTourism.Controllers
{
    [RoutePrefix("api/TourGuideCore")]
    public class TourGuideController : ApiController
    {
        [Route("AddTourGuide")]
        [HttpPost]
        public IHttpActionResult AddTourGuide(TblTourGuide tourGuide)
        {
            var task = Task.Run(() => new TourGuideService().AddTourGuide(tourGuide));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteTourGuide")]
        [HttpPost]
        public IHttpActionResult DeleteTourGuide(int id)
        {
            var task = Task.Run(() => new TourGuideService().DeleteTourGuide(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateTourGuide")]
        [HttpPost]
        public IHttpActionResult UpdateTourGuide(List<object> tourGuideLogId)
        {
            TblTourGuide tourGuide = JsonConvert.DeserializeObject<TblTourGuide>(tourGuideLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(tourGuideLogId[1].ToString());
            var task = Task.Run(() => new TourGuideService().UpdateTourGuide(tourGuide, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllTourGuides")]
        [HttpGet]
        public IHttpActionResult SelectAllTourGuides()
        {
            var task = Task.Run(() => new TourGuideService().SelectAllTourGuides());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuide> dto = new List<DtoTblTourGuide>();
                    foreach (TblTourGuide obj in task.Result)
                        dto.Add(new DtoTblTourGuide(obj, HttpStatusCode.OK));
                    try
                    {
                        List<DtoTblTourGuide> dbj = dto.OrderBy(i => Convert.ToDouble(i.Description.Split(':')[1])).ToList();
                        return Ok(dbj);
                    }
                    catch
                    {
                        return Ok(task.Result);
                    }
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideById")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideById(int id)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(new DtoTblTourGuide(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideByTellNo")]
        [HttpPost]
        public IHttpActionResult SelectResumeByTellNo(string tellNo)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideByTellNo(tellNo));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuide(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideByUsername")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideByUsername(string username)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideByUsername(username));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuide(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideByCityId")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideByUsername(int cityId)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideByCityId(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(task.Result);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectTourGuideByEmail")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideByEmail(string email)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideByEmail(email));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblTourGuide(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectEquipmentsByTourGuide")]
        [HttpPost]
        public IHttpActionResult SelectEquipmentsByTourGuide(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideService().SelectEquipmentsByTourGuide(tourGuideId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblEquipment> dto = new List<DtoTblEquipment>();
                    foreach (TblEquipment obj in task.Result)
                        dto.Add(new DtoTblEquipment(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectImagesByTourGuide")]
        [HttpPost]
        public IHttpActionResult SelectImagesByTourGuide(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideService().SelectImagesByTourGuide(tourGuideId));
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

        [Route("SelectTourGuideByDiscount")]
        [HttpPost]
        public IHttpActionResult SelectTourGuideByDiscount(int cityId)
        {
            var task = Task.Run(() => new TourGuideService().SelectTourGuideByDiscount(cityId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblTourGuide> dto = new List<DtoTblTourGuide>();
                    foreach (TblTourGuide obj in task.Result)
                        dto.Add(new DtoTblTourGuide(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectResumesByTourGuide")]
        [HttpPost]
        public IHttpActionResult SelectResumesByTourGuide(int tourGuideId)
        {
            var task = Task.Run(() => new TourGuideService().SelectResumesByTourGuide(tourGuideId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblResume> dto = new List<DtoTblResume>();
                    foreach (TblResume obj in task.Result)
                        dto.Add(new DtoTblResume(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

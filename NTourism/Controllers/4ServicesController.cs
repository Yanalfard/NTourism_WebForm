using Newtonsoft.Json;
using NTourism.Models.Dto;
using NTourism.Models.Regular;
using NTourism.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace NTourism.Controllers
{
    [RoutePrefix("api/Services4")]
    public class Services4Controller : ApiController
    {
        [Route("Update4Services")]
        [HttpPost]
        public IHttpActionResult UpdateTbl4Services(List<object> servicesLogId)
        {
            Tbl4Services services = JsonConvert.DeserializeObject<Tbl4Services>(servicesLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(servicesLogId[1].ToString());
            var task = Task.Run(() => new MainProvider().Update(services, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
        [Route("SelectAll4Services")]
        [HttpGet]
        public IHttpActionResult SelectAllAds()
        {
            var task = Task.Run(() => new MainProvider().SelectAll(MainProvider.Tables.Services4));
            var c = task.Result.Cast<Tbl4Services>().ToList();
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (c.Count != 0)
                {
                    List<DtoTbl4Services> dto = new List<DtoTbl4Services>();
                    foreach (Tbl4Services obj in task.Result)
                        dto.Add(new DtoTbl4Services(obj));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

    }
}

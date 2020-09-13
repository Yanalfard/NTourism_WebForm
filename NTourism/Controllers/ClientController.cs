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
    [RoutePrefix("api/ClientCore")]
    public class ClientController : ApiController
    {
        [Route("AddClient")]
        [HttpPost]
        public IHttpActionResult AddClient(TblClient client)
        {
            var task = Task.Run(() => new ClientService().AddClient(client));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(task.Result);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteClient")]
        [HttpPost]
        public IHttpActionResult DeleteClient(int id)
        {
            var task = Task.Run(() => new ClientService().DeleteClient(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateClient")]
        [HttpPost]
        public IHttpActionResult UpdateClient(List<object> clientLogId)
        {
            TblClient client = JsonConvert.DeserializeObject<TblClient>(clientLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(clientLogId[1].ToString());
            var task = Task.Run(() => new ClientService().UpdateClient(client, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllClients")]
        [HttpGet]
        public IHttpActionResult SelectAllClients()
        {
            var task = Task.Run(() => new ClientService().SelectAllClients());
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblClient> dto = new List<DtoTblClient>();
                    foreach (TblClient obj in task.Result)
                        dto.Add(new DtoTblClient(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientById")]
        [HttpPost]
        public IHttpActionResult SelectClientById(int id)
        {
            var task = Task.Run(() => new ClientService().SelectClientById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientByFirstName")]
        [HttpPost]
        public IHttpActionResult SelectClientByFirstName(string firstName)
        {
            var task = Task.Run(() => new ClientService().SelectClientByFirstName(firstName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientByLastName")]
        [HttpPost]
        public IHttpActionResult SelectClientByLastName(string lastName)
        {
            var task = Task.Run(() => new ClientService().SelectClientByLastName(lastName));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblClient> dto = new List<DtoTblClient>();
                    foreach (TblClient obj in task.Result)
                        dto.Add(new DtoTblClient(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientByEmail")]
        [HttpPost]
        public IHttpActionResult SelectClientByEmail(string email)
        {
            var task = Task.Run(() => new ClientService().SelectClientByEmail(email));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientByUsername")]
        [HttpPost]
        public IHttpActionResult SelectClientByUsername(string username)
        {
            var task = Task.Run(() => new ClientService().SelectClientByUsername(username));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectClientByUsernamePassword")]
        [HttpPost]
        public IHttpActionResult SelectClientByUsernamePassword(List<object> usernamePassword)
        {
            string username = JsonConvert.DeserializeObject<string>(usernamePassword[0].ToString());
            string password = JsonConvert.DeserializeObject<string>(usernamePassword[1].ToString());
            var task = Task.Run(() => new ClientService().SelectClientByUsernamePassword(username, password));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCommentsByClientId")]
        [HttpPost]
        public IHttpActionResult SelectCommentsByClientId(int clientId)
        {
            var task = Task.Run(() => new ClientService().SelectCommentsByClientId(clientId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.Count != 0)
                {
                    List<DtoTblComments> dto = new List<DtoTblComments>();
                    foreach (TblComments obj in task.Result)
                        dto.Add(new DtoTblComments(obj, HttpStatusCode.OK));
                    return Ok(dto);
                }
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

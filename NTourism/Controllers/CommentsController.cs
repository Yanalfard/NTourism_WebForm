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
    [RoutePrefix("api/CommentsCore")]
    public class CommentsController : ApiController
    {
        [Route("AddComment")]
        [HttpPost]
        public IHttpActionResult AddComment(TblComments comment)
        {
            var task = Task.Run(() => new CommentsService().AddComment(comment));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result != null)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("DeleteComment")]
        [HttpPost]
        public IHttpActionResult DeleteComment(int id)
        {
            var task = Task.Run(() => new CommentsService().DeleteComment(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("UpdateComment")]
        [HttpPost]
        public IHttpActionResult UpdateComment(List<object> commentLogId)
        {
            TblComments client = JsonConvert.DeserializeObject<TblComments>(commentLogId[0].ToString());
            int logId = JsonConvert.DeserializeObject<int>(commentLogId[1].ToString());
            var task = Task.Run(() => new CommentsService().UpdateComment(client, logId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result)
                    return Ok(true);
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectAllComments")]
        [HttpGet]
        public IHttpActionResult SelectAllComments()
        {
            var task = Task.Run(() => new CommentsService().SelectAllComments());
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

        [Route("SelectCommentById")]
        [HttpPost]
        public IHttpActionResult SelectCommentById(int id)
        {
            var task = Task.Run(() => new CommentsService().SelectCommentById(id));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblComments(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }

        [Route("SelectCommentsByClientId")]
        [HttpPost]
        public IHttpActionResult SelectCommentsByClientId(int clientId)
        {
            var task = Task.Run(() => new CommentsService().SelectCommentsByClientId(clientId));
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

        [Route("SelectClientByComment")]
        [HttpPost]
        public IHttpActionResult SelectClientByComment(int commentId)
        {
            var task = Task.Run(() => new CommentsService().SelectClientByComment(commentId));
            if (task.Wait(TimeSpan.FromSeconds(10)))
                if (task.Result.id != -1)
                    return Ok(new DtoTblClient(task.Result, HttpStatusCode.OK));
                else
                    return Conflict();
            return StatusCode(HttpStatusCode.RequestTimeout);
        }
    }
}

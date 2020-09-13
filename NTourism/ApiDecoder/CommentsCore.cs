using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class CommentsCore : ApiController
    {
        private HttpClient _httpClient;

        public CommentsCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/CommentsCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddComment(TblComments comment)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/AddComment", comment);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteComment(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/DeleteComment?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateComment(TblComments comment, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(comment);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/UpdateComment", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblComments>> SelectAllComments()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/CommentsCore/SelectAllComments");
            List<DtoTblComments> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblComments>>();
            return ans;
        }

        public async Task<DtoTblComments> SelectCommentById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/SelectCommentById?id={id}", id);
            DtoTblComments ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblComments>();
            return ans;
        }

        public async Task<List<DtoTblComments>> SelectCommentsByClientId(int clientId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/SelectCommentsByClientId?clientId={clientId}", clientId);
            List<DtoTblComments> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblComments>>();
            return ans;
        }

        public async Task<TblClient> SelectClientByComment(int commentId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CommentsCore/SelectClientByComment?commentId={commentId}", commentId);
            TblClient ans = await httpResponseMessage.Content.ReadAsAsync<TblClient>();
            return ans;
        }
    }
}
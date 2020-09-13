using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class AttractionCommentsRelCore : ApiController
    {
        private HttpClient _httpClient;

        public AttractionCommentsRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AttractionCommentsRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AttractionCommentsRelCore/AddAttractionCommentsRel", AttractionCommentsRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteAttractionCommentsRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCommentsRelCore/DeleteAttractionCommentsRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateAttractionCommentsRel(TblAttractionCommentsRel AttractionCommentsRel, int logId)
        {
            List<object> AttractionCommentsRelAndLogId = new List<object>();
            AttractionCommentsRelAndLogId.Add(AttractionCommentsRel);
            AttractionCommentsRelAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AttractionCommentsRelCore/UpdateAttractionCommentsRel", AttractionCommentsRelAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblAttractionCommentsRel>> SelectAllAttractionCommentsRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/AttractionCommentsRelCore/SelectAllAttractionCommentsRels");
            List<DtoTblAttractionCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionCommentsRel>>();
            return ans;
        }

        public async Task<DtoTblAttractionCommentsRel> SelectAttractionCommentsRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCommentsRelCore/SelectAttractionCommentsRelById?id={id}", id);
            DtoTblAttractionCommentsRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblAttractionCommentsRel>();
            return ans;
        }

        public async Task<List<DtoTblAttractionCommentsRel>> SelectAttractionCommentsRelByAttractionId(int AttractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCommentsRelCore/SelectAttractionCommentsRelByAttractionId?AttractionId={AttractionId}", AttractionId);
            List<DtoTblAttractionCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionCommentsRel>>();
            return ans;
        }

        public async Task<List<DtoTblAttractionCommentsRel>> SelectAttractionCommentsRelByCommentId(int commentId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCommentsRelCore/SelectAttractionCommentsRelByCommentId?commentId={commentId}", commentId);
            List<DtoTblAttractionCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionCommentsRel>>();
            return ans;
        }
    }
}
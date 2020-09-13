using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class AttractionPollRelCore
    {
        private HttpClient _httpClient;

        public AttractionPollRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AttractionPollRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddAttractionPollRel(TblAttractionPollRel AttractionPollRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/AddAttractionPollRel", AttractionPollRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteAttractionPollRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/DeleteAttractionPollRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateAttractionPollRel(TblAttractionPollRel AttractionPollRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(AttractionPollRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/UpdateAttractionPollRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblAttractionPollRel>> SelectAllAttractionPollRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/AttractionPollRelCore/SelectAllAttractionPollRels");
            List<DtoTblAttractionPollRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionPollRel>>();
            return ans;
        }

        public async Task<DtoTblAttractionPollRel> SelectAttractionPollRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/SelectAttractionPollRelById?id={id}", id);
            DtoTblAttractionPollRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblAttractionPollRel>();
            return ans;
        }

        public async Task<List<DtoTblAttractionPollRel>> SelectAttractionPollRelByAttractionId(int AttractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/SelectAttractionPollRelByAttractionId?AttractionId={AttractionId}", AttractionId);
            List<DtoTblAttractionPollRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionPollRel>>();
            return ans;
        }

        public async Task<List<DtoTblAttractionPollRel>> SelectAttractionPollRelByPollId(int pollId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionPollRelCore/SelectAttractionPollRelByPollId?pollId={pollId}", pollId);
            List<DtoTblAttractionPollRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionPollRel>>();
            return ans;
        }
    }
}
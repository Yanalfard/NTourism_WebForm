using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class AttractionCore : ApiController
    {
        private HttpClient _httpClient;

        public AttractionCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AttractionCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddAttraction(TblAttraction Attraction)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/AddAttractionCommentsRel", Attraction);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteAttraction(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/DeleteAttraction?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateAttraction(TblAttraction Attraction, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(Attraction);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/UpdateAttraction", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAllAttractions()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/AttractionCore/SelectAllAttractions");
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAllEvents()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/AttractionCore/SelectAllEvents");
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAllTripStories()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/AttractionCore/SelectAllTripStories");
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<DtoTblAttraction> SelectAttractionById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectAttractionById?id={id}", id);
            DtoTblAttraction ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblAttraction>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAttractionByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectAttractionByName?name={name}", name);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblComments>> SelectCommentsByAttraction(int AttractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectCommentsByAttraction?AttractionId={AttractionId}", AttractionId);
            List<DtoTblComments> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblComments>>();
            return ans;
        }

        public async Task<List<DtoTblPoll>> SelectPollByAttractionId(int AttractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectPollByAttractionId?AttractionId={AttractionId}", AttractionId);
            List<DtoTblPoll> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblPoll>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAAttraction(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectAAttraction?name={name}", name);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectAttractionByIsSelected(bool isSelected)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectAttractionByIsSelected?isSelected={isSelected}", isSelected);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectEventsByIsSelected(bool isSelected)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectEventsByIsSelected?isSelected={isSelected}", isSelected);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }

        public async Task<List<DtoTblAttraction>> SelectTripStoriesByIsSelected(bool isSelected)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionCore/SelectTripStoriesByIsSelected?isSelected={isSelected}", isSelected);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }
    }
}
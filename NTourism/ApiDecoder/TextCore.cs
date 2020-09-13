using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class TextCore : ApiController
    {
        private HttpClient _httpClient;

        public TextCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/TextCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddText(TblText text)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TextCore/AddText", text);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteText(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TextCore/DeleteText?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateText(TblText text, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(text);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TextCore/UpdateText", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblText>> SelectAllTexts()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/TextCore/SelectAllTexts");
            List<DtoTblText> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblText>>();
            return ans;
        }

        public async Task<DtoTblText> SelectTextById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TextCore/SelectTextById?id={id}", id);
            DtoTblText ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblText>();
            return ans;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class NewsCore : ApiController
    {
        private HttpClient _httpClient;

        public NewsCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/NewsCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddNews(TblNews news)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/AddNews", news);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteNews(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/DeleteNews?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateNews(TblNews news, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(news);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/UpdateNews", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectAllNews()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/NewsCore/SelectAllNews");
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<DtoTblNews> SelectNewsById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsById?id={id}", id);
            DtoTblNews ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblNews>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectNewsByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsByName?name={name}", name);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectNewsByOrder(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsByOrder?name={name}", name);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectNewsByTextId(int textId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsByTextId?textId={textId}", textId);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectNewsByImageId(int imageId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsByImageId?imageId={imageId}", imageId);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectANews(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectANews?name={name}", name);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }

        public async Task<List<DtoTblNews>> SelectNewsByIsSelected(bool isSelected)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsCore/SelectNewsByIsSelected?isSelected={isSelected}", isSelected);
            List<DtoTblNews> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNews>>();
            return ans;
        }
    }
}
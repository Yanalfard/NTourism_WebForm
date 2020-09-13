using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class ImagesCore : ApiController
    {
        private HttpClient _httpClient;

        public ImagesCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/ImagesCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddImage(TblImages image)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/AddImage", image);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteImage(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/DeleteImage?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateImage(TblImages image, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(image);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/UpdateImage", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblImages>> SelectAllImages()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/ImagesCore/SelectAllImages");
            List<DtoTblImages> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblImages>>();
            return ans;
        }

        public async Task<DtoTblImages> SelectImageById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/SelectImageById?id={id}", id);
            DtoTblImages ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblImages>();
            return ans;
        }

        public async Task<List<DtoTblImages>> SelectImagesByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/SelectImagesByName?name={name}", name);
            List<DtoTblImages> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblImages>>();
            return ans;
        }
    }
}
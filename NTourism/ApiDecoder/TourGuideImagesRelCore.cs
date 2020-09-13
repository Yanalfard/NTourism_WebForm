using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class TourGuideImagesRelCore : ApiController
    {
        private HttpClient _httpClient;

        public TourGuideImagesRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/TourGuideImagesRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/AddTourGuideImagesRel", tourGuideImagesRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteTourGuideImagesRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/DeleteTourGuideImagesRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateTourGuideImagesRel(TblTourGuideImagesRel tourGuideImagesRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(tourGuideImagesRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/UpdateTourGuideImagesRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideImagesRel>> SelectAllTourGuideImagesRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/TourGuideImagesRelCore/SelectAllTourGuideImagesRels");
            List<DtoTblTourGuideImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideImagesRel>>();
            return ans;
        }

        public async Task<DtoTblTourGuideImagesRel> SelectTourGuideImagesRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/SelectTourGuideImagesRelById?id={id}", id);
            DtoTblTourGuideImagesRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuideImagesRel>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideImagesRel>> SelectTourGuideImagesRelByImageId(int imageId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/SelectTourGuideImagesRelByImageId?imageId={imageId}", imageId);
            List<DtoTblTourGuideImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideImagesRel>>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideImagesRel>> SelectTourGuideImagesRelByTourGuideId(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideImagesRelCore/SelectTourGuideImagesRelByTourGuideId?tourGuideId={tourGuideId}", tourGuideId);
            List<DtoTblTourGuideImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideImagesRel>>();
            return ans;
        }
    }
}
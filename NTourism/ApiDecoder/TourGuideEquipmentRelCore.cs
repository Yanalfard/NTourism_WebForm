using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class TourGuideEquipmentRelCore : ApiController
    {
        private HttpClient _httpClient;

        public TourGuideEquipmentRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/TourGuideEquipmentRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/AddTourGuideEquipmentRel", tourGuideEquipmentRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteTourGuideEquipmentRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/DeleteTourGuideEquipmentRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateTourGuideEquipmentRel(TblTourGuideEquipmentRel tourGuideEquipmentRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(tourGuideEquipmentRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/UpdateTourGuideEquipmentRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideEquipmentRel>> SelectAllTourGuideEquipmentRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/TourGuideEquipmentRelCore/SelectAllTourGuideEquipmentRels");
            List<DtoTblTourGuideEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideEquipmentRel>>();
            return ans;
        }

        public async Task<DtoTblTourGuideEquipmentRel >SelectTourGuideEquipmentRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/SelectTourGuideEquipmentRelById?id={id}", id);
            DtoTblTourGuideEquipmentRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuideEquipmentRel>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideEquipmentRel>> SelectTourGuideEquipmentRelByEquipmentId(int equipmentId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/SelectTourGuideEquipmentRelByEquipmentId?equipmentId={equipmentId}", equipmentId);
            List<DtoTblTourGuideEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideEquipmentRel>>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideEquipmentRel>> SelectTourGuideEquipmentRelByTourGuideId(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideEquipmentRelCore/SelectTourGuideEquipmentRelByTourGuideId?tourGuideId={tourGuideId}", tourGuideId);
            List<DtoTblTourGuideEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideEquipmentRel>>();
            return ans;
        }
    }
}
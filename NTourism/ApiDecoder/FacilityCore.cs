using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class FacilityCore : ApiController
    {
        private HttpClient _httpClient;

        public FacilityCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/FacilityCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddFacility(TblFacility facility)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FacilityCore/AddFacility", facility);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteFacility(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FacilityCore/DeleteFacility?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateFacility(TblFacility facility, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(facility);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FacilityCore/UpdateFacility", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblFacility>> SelectAllFacilities()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/FacilityCore/SelectAllFacilities");
            List<DtoTblFacility> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblFacility>>();
            return ans;
        }

        public async Task<DtoTblFacility> SelectFacilityById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FacilityCore/SelectFacilityById?id={id}", id);
            DtoTblFacility ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblFacility>();
            return ans;
        }

        public async Task<DtoTblFacility> SelectFacilityByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FacilityCore/SelectFacilityByName?name={name}", name);
            DtoTblFacility ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblFacility>();
            return ans;
        }
    }
}
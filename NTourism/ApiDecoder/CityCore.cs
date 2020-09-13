using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class CityCore : ApiController
    {
        private HttpClient _httpClient;

        public CityCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AttractionCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddCity(TblCity city)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/AddCity", city);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteCity(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/DeleteCity?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateCity(TblCity city, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(city);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/UpdateCity", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblCity>> SelectAllCities()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/CityCore/SelectAllCities");
            List<DtoTblCity> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCity>>();
            return ans;
        }

        public async Task<DtoTblCity> SelectCityById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/SelectCityById?id={id}", id);
            DtoTblCity ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblCity>();
            return ans;
        }

        public async Task<List<DtoTblCity>> SelectCityByCountryId(int countryId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/SelectCityByCountryId?countryId={countryId}", countryId);
            List<DtoTblCity> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCity>>();
            return ans;
        }
        public async Task<List<DtoTblAttraction>> SelectAttractionByCityId(int cityId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityCore/SelectAttractionByCityId?cityId={cityId}", cityId);
            List<DtoTblAttraction> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttraction>>();
            return ans;
        }
    }
}
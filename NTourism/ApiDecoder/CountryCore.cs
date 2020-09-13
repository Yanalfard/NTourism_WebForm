using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class CountryCore : ApiController
    {
        private HttpClient _httpClient;

        public CountryCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/CountryCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }
        public async Task<bool> AddCountry(TblCountry country)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/AddCountry", country);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/DeleteCountry?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateCountry(TblCountry country, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(country);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/UpdateCountry", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblCountry>> SelectAllCountries()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/CountryCore/SelectAllCountries");
            List<DtoTblCountry> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCountry>>();
            return ans;
        }

        public async Task<DtoTblCountry> SelectCountryById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/SelectCountryById?id={id}", id);
            DtoTblCountry ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblCountry>();
            return ans;
        }

        public async Task<DtoTblCountry> SelectCountryByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/SelectCountryByName?name={name}", name);
            DtoTblCountry ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblCountry>();
            return ans;
        }

        public async Task<DtoTblCountry> SelectCountryByCity(int cityId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CountryCore/SelectCountryByCity?cityId={cityId}", cityId);
            DtoTblCountry ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblCountry>();
            return ans;
        }
    }
}
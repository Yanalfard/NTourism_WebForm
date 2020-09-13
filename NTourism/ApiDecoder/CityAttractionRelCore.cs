using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class CityAttractionRelCore
    {
        private HttpClient _httpClient;

        public CityAttractionRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/CityAttractionRelCore"));
            _httpClient.BaseAddress = new Uri("ferffeweffdefwerejiorfujrerfrf7uy7r54fy7ur54fe");

        }
        /// <summary>
        /// Adds a cityAttractionRel to NTourism.TblCityAttractionRel
        /// </summary>
        /// <param name="cityAttractionRel"></param>
        /// <returns></returns>
        public async Task<DtoTblCityAttractionRel> AddCityAttractionRel(TblCityAttractionRel cityAttractionRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/CityAttractionRelCore/AddCityAttractionRel", cityAttractionRel);
            DtoTblCityAttractionRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblCityAttractionRel>();
            return ans;
        }
        /// <summary>
        /// Deletes a cityAttractionRel from NTourism.TblCityAttractionRel using its id
        /// </summary>
        /// <param name="cityAttractionRel"></param>
        /// <returns></returns>
        public async Task<bool> DeleteCityAttractionRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityAttractionRelCore/DeleteCityAttractionRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        /// <summary>
        /// Updates a cityAttractionRel at NTourism.TblCityAttractionRel
        /// </summary>
        /// <param name="cityAttractionRel"></param>
        /// <param name="logId">Old doctors id</param>
        /// <returns></returns>
        public async Task<bool> UpdateCityAttractionRel(TblCityAttractionRel cityAttractionRel, int logId)
        {
            List<object> cityAttractionRelAndLogId = new List<object>();
            cityAttractionRelAndLogId.Add(cityAttractionRel);
            cityAttractionRelAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/CityAttractionRelCore/UpdateCityAttractionRel", cityAttractionRelAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        /// <summary>
        /// Selects all cityAttractionRels from NTourism.TblCityAttractionRel
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoTblCityAttractionRel>> SelectAllCityAttractionRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/CityAttractionRelCore/SelectAllCityAttractionRels");
            List<DtoTblCityAttractionRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCityAttractionRel>>();
            return ans;
        }
        /// <summary>
        /// Selects a doctor from NTourism.TblCityAttractionRel by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TblCityAttractionRel> SelectCityAttractionRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityAttractionRelCore/SelectCityAttractionRelById?id={id}", id);
            TblCityAttractionRel ans = await httpResponseMessage.Content.ReadAsAsync<TblCityAttractionRel>();
            return ans;
        }
        /// <summary>
        /// Select CityAttractionRels from NTourism.TblCityAttractionRel by attractionId
        /// </summary>
        /// <param name="attractionId"></param>
        /// <returns></returns>
        public async Task<List<DtoTblCityAttractionRel>> SelectCityAttractionRelByAttractionId(int attractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityAttractionRelCore/SelectCityAttractionRelByAttractionId?attractionId={attractionId}", attractionId);
            List<DtoTblCityAttractionRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCityAttractionRel>>();
            return ans;
        }
        /// <summary>
        /// Select CityAttractionRels from NTourism.TblCityAttractionRel by roomHomeId
        /// </summary>
        /// <param name="roomHomeId"></param>
        /// <returns></returns>
        public async Task<List<DtoTblCityAttractionRel>> SelectCityAttractionRelByRoomHomeId(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityAttractionRelCore/SelectCityAttractionRelByRoomHomeId?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblCityAttractionRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCityAttractionRel>>();
            return ans;
        }
        /// <summary>
        /// Select CityAttractionRels from NTourism.TblCityAttractionRel by cityId
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public async Task<List<DtoTblCityAttractionRel>> SelectCityAttractionRelByCityId(int cityId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/CityAttractionRelCore/SelectCityAttractionRelByCityId?cityId={cityId}", cityId);
            List<DtoTblCityAttractionRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblCityAttractionRel>>();
            return ans;
        }

    }
}
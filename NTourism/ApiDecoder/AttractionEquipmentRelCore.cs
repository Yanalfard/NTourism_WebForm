using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class AttractionEquipmentRelCore
    {
        private HttpClient _httpClient;

        public AttractionEquipmentRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AttractionEquipmentRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AttractionEquipmentRelCore/AddAttractionEquipmentRel", AttractionEquipmentRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteAttractionEquipmentRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionEquipmentRelCore/DeleteAttractionEquipmentRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateAttractionEquipmentRel(TblAttractionEquipmentRel AttractionEquipmentRel, int logId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AttractionEquipmentRelCore/UpdateAttractionEquipmentRel", AttractionEquipmentRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblAttractionEquipmentRel>> SelectAllAttractionEquipmentRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/AttractionEquipmentRelCore/SelectAllAttractionEquipmentRels");
            List<DtoTblAttractionEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionEquipmentRel>>();
            return ans;
        }

        public async Task<DtoTblAttractionEquipmentRel> SelectAttractionEquipmentRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionEquipmentRelCore/SelectAttractionEquipmentRelById?id={id}", id);
            DtoTblAttractionEquipmentRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblAttractionEquipmentRel>();
            return ans;
        }

        public async Task<List<DtoTblAttractionEquipmentRel>> SelectAttractionEquipmentRelByAttractionId(int AttractionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionEquipmentRelCore/SelectAttractionEquipmentRelByAttractionId?AttractionId={AttractionId}", AttractionId);
            List<DtoTblAttractionEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionEquipmentRel>>();
            return ans;
        }

        public async Task<List<DtoTblAttractionEquipmentRel>> SelectAttractionEquipmentRelByEquipmentId(int equipmentId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AttractionEquipmentRelCore/SelectAttractionEquipmentRelByEquipmentId?equipmentId={equipmentId}", equipmentId);
            List<DtoTblAttractionEquipmentRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAttractionEquipmentRel>>();
            return ans;
        }

    }
}
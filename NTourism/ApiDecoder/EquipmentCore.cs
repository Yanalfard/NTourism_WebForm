using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class EquipmentCore : ApiController
    {
        private HttpClient _httpClient;

        public EquipmentCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/EquipmentCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddEquipment(TblEquipment equipment)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/EquipmentCore/AddEquipment", equipment);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteEquipment(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/EquipmentCore/DeleteEquipment?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateEquipment(TblEquipment equipment, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(equipment);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/EquipmentCore/UpdateEquipment", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblEquipment>> SelectAllEquipments()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/EquipmentCore/SelectAllEquipments");
            List<DtoTblEquipment> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblEquipment>>();
            return ans;
        }

        public async Task<DtoTblEquipment> SelectEquipmentById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/EquipmentCore/SelectEquipmentById?id={id}", id);
            DtoTblEquipment ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblEquipment>();
            return ans;
        }

        public async Task<DtoTblEquipment> SelectEquipmentByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/EquipmentCore/SelectEquipmentByName?name={name}", name);
            DtoTblEquipment ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblEquipment>();
            return ans;
        }
    }
}
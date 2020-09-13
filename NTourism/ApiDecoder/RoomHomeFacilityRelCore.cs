using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class RoomHomeFacilityRelCore : ApiController
    {
        private HttpClient _httpClient;

        public RoomHomeFacilityRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/RoomHomeFacilityRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddRoomHomeFacilityRel(TblRoomHomeFacilityRel roomHomeFacilityRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/AddRoomHomeFacilityRel", roomHomeFacilityRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteRoomHomeFacilityRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/DeleteRoomHomeFacilityRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateRoomHomeFacilityRel(TblRoomHomeFacilityRel roomHomeFacilityRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(roomHomeFacilityRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/UpdateRoomHomeFacilityRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeFacilityRel>> SelectAllRoomHomeFacilityRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/RoomHomeFacilityRelCore/SelectAllRoomHomeFacilityRels");
            List<DtoTblRoomHomeFacilityRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeFacilityRel>>();
            return ans;
        }

        public async Task<DtoTblRoomHomeFacilityRel> SelectRoomHomeFacilityRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelById?id={id}", id);
            DtoTblRoomHomeFacilityRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblRoomHomeFacilityRel>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeFacilityRel>> SelectRoomHomeFacilityRelByFacilityId(int facility)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelByFacilityId?facility={facility}", facility);
            List<DtoTblRoomHomeFacilityRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeFacilityRel>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeFacilityRel>> SelectRoomHomeFacilityRelByRoomHomeId(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeFacilityRelCore/SelectRoomHomeFacilityRelByRoomHomeId?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblRoomHomeFacilityRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeFacilityRel>>();
            return ans;
        }
    }
}
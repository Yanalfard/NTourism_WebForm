using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;

namespace NTourism.ApiDecoder
{
    public class RoomHomeCore : ApiController
    {
        private HttpClient _httpClient;

        public RoomHomeCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/RoomHomeCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddRoomHome(DtoTblRoomHome roomHome)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/AddRoomHome", roomHome);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteRoomHome(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/DeleteRoomHome?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateRoomHome(DtoTblRoomHome roomHome, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(roomHome);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/UpdateRoomHome", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblRoomHome>> SelectAllRoomHomes()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/RoomHomeCore/SelectAllRoomHomes");
            List<DtoTblRoomHome> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHome>>();
            return ans;
        }

        public async Task<DtoTblRoomHome>SelectRoomHomeById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeById?id={id}", id);
            DtoTblRoomHome ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblRoomHome>();
            return ans;
        }

        public async Task<DtoTblRoomHome> SelectRoomHomeByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeByName?name={name}", name);
            DtoTblRoomHome ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblRoomHome>();
            return ans;
        }

        public async Task<List<DtoTblRoomHome>> SelectRoomHomeByCityId(int cityId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeByCityId?cityId={cityId}", cityId);
            List<DtoTblRoomHome> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHome>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHome>> SelectRoomHomeByIsReserved(bool isReserved)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeByIsReserved?isReserved={isReserved}", isReserved);
            List<DtoTblRoomHome> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHome>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHome>> SelectRoomHomeByClientId(string clientId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeByClientId?clientId={clientId}", clientId);
            List<DtoTblRoomHome> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHome>>();
            return ans;
        }

        public async Task<List<DtoTblComments>> SelectCommentsByRoomHome(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectCommentsByRoomHome?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblComments> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblComments>>();
            return ans;
        }

        public async Task<List<DtoTblFacility>> SelectFacilitiesByRoomHome(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectFacilitiesByRoomHome?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblFacility> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblFacility>>();
            return ans;
        }

        public async Task<List<DtoTblImages>> SelectImagesByRoomHome(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectImagesByRoomHome?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblImages> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblImages>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHome>> SelectRoomHomeByIsSelected(bool isSelected)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeCore/SelectRoomHomeByIsSelected?isSelected={isSelected}", isSelected);
            List<DtoTblRoomHome> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHome>>();
            return ans;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class RoomHomeImageRelCore : ApiController
    {
        private HttpClient _httpClient;

        public RoomHomeImageRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/RoomHomeImageRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddRoomHomeImageRel(TblRoomHomeImageRel roomHomeImageRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/AddRoomHomeImageRel", roomHomeImageRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteRoomHomeImageRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/DeleteRoomHomeImageRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateRoomHomeImageRel(TblRoomHomeImageRel roomHomeImageRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(roomHomeImageRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/UpdateRoomHomeImageRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeImageRel>> SelectAllRoomHomeImageRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/RoomHomeImageRelCore/SelectAllRoomHomeImageRels");
            List<DtoTblRoomHomeImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeImageRel>>();
            return ans;
        }

        public async Task<DtoTblRoomHomeImageRel> SelectRoomHomeImageRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/SelectRoomHomeImageRelById?id={id}", id);
            DtoTblRoomHomeImageRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblRoomHomeImageRel>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeImageRel>> SelectRoomHomeImageRelByImageId(int imageId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/SelectRoomHomeImageRelByImageId?imageId={imageId}", imageId);
            List<DtoTblRoomHomeImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeImageRel>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeImageRel>> SelectRoomHomeImageRelByRoomHomeId(int roomHomeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/RoomHomeImageRelCore/SelectRoomHomeImageRelByRoomHomeId?roomHomeId={roomHomeId}", roomHomeId);
            List<DtoTblRoomHomeImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeImageRel>>();
            return ans;
        }
    }
}
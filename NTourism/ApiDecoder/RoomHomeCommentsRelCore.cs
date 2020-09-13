using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class RoomHomeCommentsRelCore : ApiController
    {
        private HttpClient _httpClient;

        public RoomHomeCommentsRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/RoomHomeCommentsRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddHotelCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/AddHotelCommentsRel", hotelCommentsRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteHotelCommentsRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/DeleteHotelCommentsRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateHotelCommentsRel(TblRoomHomeCommentsRel hotelCommentsRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(hotelCommentsRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/UpdateHotelCommentsRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeCommentsRel>> SelectAllHotelCommentsRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/HotelCommentsRelCore/SelectAllHotelCommentsRels");
            List<DtoTblRoomHomeCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeCommentsRel>>();
            return ans;
        }

        public async Task<DtoTblRoomHomeCommentsRel> SelectHotelCommentsRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/SelectHotelCommentsRelById?id={id}", id);
            DtoTblRoomHomeCommentsRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblRoomHomeCommentsRel>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeCommentsRel>> SelectHotelCommentsRelByHotelId(int hotelId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/SelectHotelCommentsRelByHotelId?hotelId={hotelId}", hotelId);
            List<DtoTblRoomHomeCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeCommentsRel>>();
            return ans;
        }

        public async Task<List<DtoTblRoomHomeCommentsRel>> SelectHotelCommentsRelByCommentId(int commentId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HotelCommentsRelCore/SelectHotelCommentsRelByCommentId?={commentId}", commentId);
            List<DtoTblRoomHomeCommentsRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblRoomHomeCommentsRel>>();
            return ans;
        }
    }
}
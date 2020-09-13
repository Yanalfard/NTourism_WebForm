using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class AdCore : ApiController
    {
        private HttpClient _httpClient;

        public AdCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/AdCore"));
            _httpClient.BaseAddress = new Uri("#localhost#");
        }
        public async Task<bool> AddAd(TblAd ad)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AdCore/AddAd", ad);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        public async Task<bool> DeleteAd(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/DeleteAd/DeleteAd?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        public async Task<bool> UpdateAd(TblAd ad, int logId)
        {
            List<object> adAndLogId = new List<object>();
            adAndLogId.Add(ad);
            adAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/AdCore/UpdateAd", adAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        public async Task<List<DtoTblAd>> SelectAllAds()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/AdCore/SelectAllAds");
            List<DtoTblAd> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAd>>();
            return ans;
        }
        public async Task<bool> SelectAdById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AdCore/SelectAdById?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
        public async Task<DtoTblAd> SelectAdByImage(string image)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AdCore/SelectAdByImage?image={image}", image);
            DtoTblAd ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblAd>();
            return ans;
        }
        public async Task<List<DtoTblAd>> SelectAdByPositionId(int positionId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AdCore/SelectAdByPositionId?positionId={positionId}", positionId);
            List<DtoTblAd> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAd>>();
            return ans;
        }
        public async Task<List<DtoTblAd>> SelectAdByIsAvailable(bool isAvailable)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/AdCore/SelectAdByIsAvailable?isAvailable={isAvailable}", isAvailable);
            List<DtoTblAd> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblAd>>();
            return ans;
        }

    }
}
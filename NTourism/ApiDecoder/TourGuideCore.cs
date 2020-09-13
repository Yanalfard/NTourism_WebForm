using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class TourGuideCore : ApiController
    {
        private HttpClient _httpClient;

        public TourGuideCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/TourGuideCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddTourGuide(TblTourGuide tourGuide)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/AddTourGuide", tourGuide);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteTourGuide(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/DeleteTourGuide?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateTourGuide(TblTourGuide tourGuide, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(tourGuide);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/UpdateTourGuide", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblTourGuide>> SelectAllTourGuides()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/TourGuideCore/SelectAllTourGuides");
            List<DtoTblTourGuide> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuide>>();
            return ans;
        }

        public async Task<DtoTblTourGuide> SelectTourGuideById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectTourGuideById?id={id}", id);
            DtoTblTourGuide ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuide>();
            return ans;
        }

        public async Task<DtoTblTourGuide> SelectTourGuideByTellNo(string tellNo)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectTourGuideByTellNo?tellNo={tellNo}", tellNo);
            DtoTblTourGuide ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuide>();
            return ans;
        }

        public async Task<DtoTblTourGuide> SelectTourGuideByEmail(string email)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectTourGuideByEmail?email={email}", email);
            DtoTblTourGuide ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuide>();
            return ans;
        }

        public async Task<List<TblEquipment>> SelectEquipmentsByTourGuide(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectEquipmentsByTourGuide?tourGuideId={tourGuideId}", tourGuideId);
            List<TblEquipment> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblEquipment>>();
            return ans;
        }

        public async Task<List<TblImages>> SelectImagesByTourGuide(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectImagesByTourGuide?tourGuideId={tourGuideId}", tourGuideId);
            List<TblImages> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblImages>>();
            return ans;
        }

        public async Task<List<TblResume>> SelectResumesByTourGuide(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideCore/SelectResumesByTourGuide?tourGuideId={tourGuideId}", tourGuideId);
            List<TblResume> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblResume>>();
            return ans;
        }
    }
}
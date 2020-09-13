using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class TourGuideResumeRelCore : ApiController
    {
        private HttpClient _httpClient;

        public TourGuideResumeRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/TourGuideResumeRelCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/AddTourGuideResumeRel", tourGuideResumeRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteTourGuideResumeRel(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/DeleteTourGuideResumeRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateTourGuideResumeRel(TblTourGuideResumeRel tourGuideResumeRel, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(tourGuideResumeRel);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/UpdateTourGuideResumeRel", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideResumeRel>> SelectAllTourGuideResumeRels()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/TourGuideResumeRelCore/SelectAllTourGuideResumeRels");
            List<DtoTblTourGuideResumeRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideResumeRel>>();
            return ans;
        }

        public async Task<DtoTblTourGuideResumeRel> SelectTourGuideResumeRelById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/SelectTourGuideResumeRelById?id={id}", id);
            DtoTblTourGuideResumeRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblTourGuideResumeRel>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideResumeRel>> SelectTourGuideResumeRelByResumeId(int resumeId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/SelectTourGuideResumeRelByResumeId?resumeId={resumeId}", resumeId);
            List<DtoTblTourGuideResumeRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideResumeRel>>();
            return ans;
        }

        public async Task<List<DtoTblTourGuideResumeRel>> SelectTourGuideResumeRelByTourGuideId(int tourGuideId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/TourGuideResumeRelCore/SelectTourGuideResumeRelByTourGuideId?tourGuideId={tourGuideId}", tourGuideId);
            List<DtoTblTourGuideResumeRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblTourGuideResumeRel>>();
            return ans;
        }
    }
}
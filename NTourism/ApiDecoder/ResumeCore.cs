using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class ResumeCore : ApiController
    {
        private HttpClient _httpClient;

        public ResumeCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/ResumeCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddResume(TblResume resume)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HttpClient/AddResume", resume);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteResume(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HttpClient/DeleteResume?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateResume(TblResume resume, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(resume);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HttpClient/UpdateResume", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblResume>> SelectAllResumes()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/HttpClient/SelectAllResumes");
            List<DtoTblResume> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblResume>>();
            return ans;
        }

        public async Task<DtoTblResume> SelectResumeById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HttpClient/SelectResumeById?id={id}", id);
            DtoTblResume ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblResume>();
            return ans;
        }

        public async Task<DtoTblResume> SelectResumeByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/HttpClient/SelectResumeByName?name={name}", name);
            DtoTblResume ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblResume>();
            return ans;
        }
    }
}
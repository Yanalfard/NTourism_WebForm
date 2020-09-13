using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class MedicalServiceImagesRelCore : ApiController
    {
        private HttpClient _httpClient;

        public MedicalServiceImagesRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/MedicalServiceImagesRelCore"));
            _httpClient.BaseAddress = new Uri("#localhost#");
        }
        public async Task<bool> AddMedicalServiceImagesRel(TblMedicalServiceImagesRel medicalServiceImagesRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/MedicalServiceImagesRelCore/AddMedicalServiceImagesRel", medicalServiceImagesRel);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/DeleteMedicalServiceImagesRel/DeleteMedicalServiceImagesRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            List<object> medicalServiceImagesRelAndLogId = new List<object>();
            medicalServiceImagesRelAndLogId.Add(medicalServiceImagesRel);
            medicalServiceImagesRelAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/MedicalServiceImagesRelCore/UpdateMedicalServiceImagesRel", medicalServiceImagesRelAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/MedicalServiceImagesRelCore/SelectAllMedicalServiceImagesRels");
            List<DtoTblMedicalServiceImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblMedicalServiceImagesRel>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceImagesRelCore/SelectMedicalServiceImagesRelById?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceImagesRelCore/SelectMedicalServiceImagesRelsByMedicalServiceId?medicalServiceId={medicalServiceId}", medicalServiceId);
            List<TblMedicalServiceImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblMedicalServiceImagesRel>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceImagesRelCore/SelectMedicalServiceImagesRelsByImageId?imageId={imageId}", imageId);
            List<TblMedicalServiceImagesRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblMedicalServiceImagesRel>>();
            return ans;
        }

    }
}
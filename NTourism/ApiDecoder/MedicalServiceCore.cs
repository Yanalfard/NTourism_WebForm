using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class MedicalServiceCore : ApiController
    {
        private HttpClient _httpClient;

        public MedicalServiceCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/MedicalServiceCore"));
            _httpClient.BaseAddress = new Uri("#localhost#");
        }
        public async Task<bool> AddMedicalService(TblMedicalService medicalService)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/MedicalServiceCore/AddMedicalService", medicalService);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/DeleteMedicalService/DeleteMedicalService?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            List<object> medicalServiceAndLogId = new List<object>();
            medicalServiceAndLogId.Add(medicalService);
            medicalServiceAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/MedicalServiceCore/UpdateMedicalService", medicalServiceAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/MedicalServiceCore/SelectAllMedicalServices");
            List<DtoTblMedicalService> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblMedicalService>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceCore/SelectMedicalServiceById?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceCore/SelectMedicalServiceByFirstName?firstName={firstName}", firstName);
            DtoTblMedicalService ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblMedicalService>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceCore/SelectMedicalServiceByLastName?lastName={lastName}", lastName);
            DtoTblMedicalService ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblMedicalService>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceCore/SelectMedicalServiceBySicknessName?sicknessName={sicknessName}", sicknessName);
            DtoTblMedicalService ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblMedicalService>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/MedicalServiceCore/SelectMedicalServiceByPassportImageId?passportImageId={passportImageId}", passportImageId);
            List<DtoTblMedicalService> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblMedicalService>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ImagesCore/SelectImagesByMedicalServiceId?medicalServiceId={medicalServiceId}", medicalServiceId);
            List<DtoTblImages> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblImages>>();
            return ans;
        }

    }
}
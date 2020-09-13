using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class FirstPageCore
    {
        private HttpClient _httpClient;

        public FirstPageCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/FirstPageCore"));
            _httpClient.BaseAddress = new Uri("#localhost#");

        }
        /// <summary>
        /// Adds a firstPage to NTourism.TblFirstPage
        /// </summary>
        /// <param name="firstPage"></param>
        /// <returns></returns>
        public async Task<DtoTblFirstPage> AddFirstPage(TblFirstPage firstPage)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/FirstPageCore/AddFirstPage", firstPage);
            DtoTblFirstPage ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblFirstPage>();
            return ans;
        }

        /// Deletes a firstPage from NTourism.TblFirstPage using its id
        /// </summary>
        /// <param name="firstPage"></param>
        /// <returns></returns>
        public async Task<bool> DeleteFirstPage(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FirstPageCore/DeleteFirstPage?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        /// Updates a firstPage at NTourism.TblFirstPage
        /// </summary>
        /// <param name="firstPage"></param>
        /// <param name="logId">Old doctors id</param>
        /// <returns></returns>
        public async Task<bool> UpdateFirstPage(TblFirstPage firstPage, int logId)
        {
            List<object> firstPageAndLogId = new List<object>();
            firstPageAndLogId.Add(firstPage);
            firstPageAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/FirstPageCore/UpdateFirstPage", firstPageAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        /// Selects all firstPages from NTourism.TblFirstPage
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoTblFirstPage>> SelectAllFirstPages()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/FirstPageCore/SelectAllFirstPages");
            List<DtoTblFirstPage> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblFirstPage>>();
            return ans;
        }

        /// Selects a doctor from NTourism.TblFirstPage by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TblFirstPage> SelectFirstPageById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FirstPageCore/SelectFirstPageById?id={id}", id);
            TblFirstPage ans = await httpResponseMessage.Content.ReadAsAsync<TblFirstPage>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FirstPageCore/SelectFirstPageByImage?image={image}", image);
            DtoTblFirstPage ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblFirstPage>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/FirstPageCore/SelectFirstPageByIsText?isText={isText}", isText);
            List<DtoTblFirstPage> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblFirstPage>>();
            return ans;
        }

    }
}
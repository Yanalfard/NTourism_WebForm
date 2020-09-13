using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class PollCore
    {
        private HttpClient _httpClient;

        public PollCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/PollCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }

        public async Task<bool> AddPoll(TblPoll poll)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/PollCore/AddPoll", poll);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeletePoll(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/PollCore/DeletePoll?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdatePoll(TblPoll poll, int logId)
        {
            List<object> pollAndLogId = new List<object> {poll, logId};
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/PollCore/UpdatePoll", pollAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblPoll>> SelectAllPolls()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/PollCore/SelectAllPolls");
            List<DtoTblPoll> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblPoll>>();
            return ans;
        }

        public async Task<DtoTblPoll> SelectPollById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/PollCore/SelectPollById?id={id}", id);
            DtoTblPoll ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblPoll>();
            return ans;
        }

        public async Task<DtoTblPoll> SelectPollByName(string name)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/PollCore/SelectPollByName?name={name}", name);
            DtoTblPoll ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblPoll>();
            return ans;
        }
    }
}
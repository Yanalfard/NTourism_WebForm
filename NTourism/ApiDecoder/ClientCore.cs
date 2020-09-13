using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using NTourism.Models.Dto;
using NTourism.Models.Regular;

namespace NTourism.ApiDecoder
{
    public class ClientCore : ApiController
    {
        private HttpClient _httpClient;

        public ClientCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/ClientCore"));
            _httpClient.BaseAddress = new Uri("http://localhost:54244/");
        }
        public async Task<bool> AddClient(TblClient client)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/AddClient", client);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> DeleteClient(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/DeleteClient?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<bool> UpdateClient(TblClient client, int logId)
        {
            List<object> obj = new List<object>();
            obj.Add(client);
            obj.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/UpdateClient", obj);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        public async Task<List<DtoTblClient>> SelectAllClients()
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync($"api/ClientCore/SelectAllClients");
            List<DtoTblClient> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblClient>>();
            return ans;
        }

        public async Task<DtoTblClient> SelectClientById(int id)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientById?id={id}", id);
            DtoTblClient ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblClient>();
            return ans;
        }

        public async Task<DtoTblClient> SelectClientByFirstName(string firstName)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientByFirstName?firstName={firstName}", firstName);
            DtoTblClient ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblClient>();
            return ans;
        }

        public async Task<List<DtoTblClient>> SelectClientByLastName(string lastName)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientByLastName?lastName={lastName}", lastName);
            List<DtoTblClient> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblClient>>();
            return ans;
        }

        public async Task<DtoTblClient> SelectClientByEmail(string email)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientByEmail?email={email}", email);
            DtoTblClient ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblClient>();
            return ans;
        }

        public async Task<DtoTblClient> SelectClientByUsername(string username)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientByUsername?username={username}", username);
            DtoTblClient ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblClient>();
            return ans;
        }

        public async Task<DtoTblClient> SelectClientByUsernamePassword(string username, string password)
        {
            List<object> obj = new List<object>();
            obj.Add(username);
            obj.Add(password);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectClientByUsernamePassword", obj);
            DtoTblClient ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblClient>();
            return ans;
        }

        public async Task<List<DtoTblComments>> SelectCommentsByClientId(int clientId)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/ClientCore/SelectCommentsByClientId?clientId={clientId}", clientId);
            List<DtoTblComments> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblComments>>();
            return ans;
        }
    }
}
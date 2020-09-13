using NTourism.Models.Regular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace NTourism.ApiDecoder
{
    public class _4ServicesCore
    {
        private HttpClient _httpClient;

        public _4ServicesCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/Services4"));
            _httpClient.BaseAddress = new Uri("#localhost#");
        }

        public async Task<bool> Update4Services(Tbl4Services services, int logId)
        {
            List<object> servicesAndLogId = new List<object>();
            servicesAndLogId.Add(services);
            servicesAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/Services4/Update4Services", servicesAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }
    }
}
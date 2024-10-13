using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace WarehouseUI
{
    public class ApiRepository
    {
        private readonly HttpClient _httpClient;

        public ApiRepository()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Target.Url);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}

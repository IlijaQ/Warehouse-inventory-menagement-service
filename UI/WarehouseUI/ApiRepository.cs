using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using WarehouseApi.DataTransferClasses;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Linq;
using WarehouseUI.DataTransferClasses;
using WarehouseUI.Models;
using WarehouseApi.Tools;

namespace WarehouseUI
{
    public class ApiRepository
    {
        private readonly HttpClient _httpClient;

        public ApiRepository()
        {
            _httpClient = new HttpClient(new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => true
            });
            _httpClient.BaseAddress = new Uri(Target.Url);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Product>> GetProductsAsync(SearchFilters searchFilters)
        {
            List<Product> results = new List<Product>();
            string jsonContent;
            using (var stringWriter = new StringWriter())
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(stringWriter, searchFilters);
                jsonContent = stringWriter.ToString();
            }
            HttpContent content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("api/warehouse/getproducts", content);
            
            if (response.IsSuccessStatusCode)
            {
                string responseJson = await response.Content.ReadAsStringAsync();
                
                List<ProductData> resultsInDTOs = JsonConvert.DeserializeObject<List<ProductData>>(responseJson);

                foreach(var dto in resultsInDTOs)
                {
                    Product resultObject = TransferData.FromDtoToProduct(dto);
                    results.Add(resultObject);
                }

                return results;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}

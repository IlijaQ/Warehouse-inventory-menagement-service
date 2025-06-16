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

        public async Task<ProductAndCategories> GetProductByIdAsync(string productIdInString)
        {
            ProductAndCategories result = new ProductAndCategories();

            HttpResponseMessage response = await _httpClient.GetAsync($"api/warehouse/GetProductById/{productIdInString}");

            if (response.IsSuccessStatusCode)
            {
                string responseJson = await response.Content.ReadAsStringAsync();

                result = JsonConvert.DeserializeObject<ProductAndCategories>(responseJson);

                return result;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
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

        public async Task<List<Category>> GetCategoriesAsync()
        {
            List<Category> results = new List<Category>();

            HttpContent content = new StringContent("", System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.GetAsync("api/warehouse/getcategories");

            if (response.IsSuccessStatusCode)
            {
                string responseJson = await response.Content.ReadAsStringAsync();

                List<CategoryData> resultsInDTOs = JsonConvert.DeserializeObject<List<CategoryData>>(responseJson);

                foreach (var dto in resultsInDTOs)
                {
                    Category resultObject = TransferData.DtoToCategory(dto);
                    results.Add(resultObject);
                }

                return results;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<bool> CreateProductAsync(ProductData productData)
        {
            string jsonContent;
            using (var stringWriter = new StringWriter ())
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(stringWriter, productData);
                jsonContent = stringWriter.ToString();
            }
            HttpContent content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("api/warehouse/createproduct", content);

            if (response.IsSuccessStatusCode)
            { 
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<bool> CreateCategoryAsync(CategoryData categoryData)
        {
            string jsonContent;
            using (var stringWriter = new StringWriter())
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(stringWriter, categoryData);
                jsonContent = stringWriter.ToString();
            }
            HttpContent content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("api/warehouse/createcategory", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<bool> UpdateProductAsync(ProductData productData)
        {
            string jsonContent;
            using (var stringWriter = new StringWriter())
            {
                var serializer = new JsonSerializer();
                serializer.Serialize(stringWriter, productData);
                jsonContent = stringWriter.ToString();
            }
            HttpContent content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _httpClient.PostAsync("api/warehouse/updateproduct", content);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }

        public async Task<bool> DeleteProductAsync(string productIdInString)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/warehouse/DeleteProduct/{productIdInString}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new HttpRequestException($"Error: {response.StatusCode}, {response.ReasonPhrase}");
            }
        }
    }
}

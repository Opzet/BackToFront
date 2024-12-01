using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApiClient
{
    public static partial class ApiCalls
    {
        private static readonly HttpClient _httpClient;
        public const int InternalPort = 54322;  //<<for TESTING

        public static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Ignore,
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        static ApiCalls()
        {

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri($"http://127.0.0.1:{InternalPort}/ ");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<T>> GetAllAsync<T>()
        {
            Debug.WriteLine($"\tTest URL : {$"{_httpClient.BaseAddress}api/{typeof(T).Name}/all"}");

            HttpResponseMessage response = await _httpClient.GetAsync($"api/{typeof(T).Name}/all");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<T>>(json, settings);
            }
            // {StatusCode: 404, ReasonPhrase: 'Not Found', 
            return null;
        }

        public static async Task<T> GetByIdAsync<T>(int id)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"api/{typeof(T).Name}/{id}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(json, settings);
            }
            return default(T);
        }

        public static async Task<bool> CreateAsync<T>(T entity)
        {
            string json = JsonConvert.SerializeObject(entity, settings);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync($"api/{typeof(T).Name}", content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> UpdateAsync<T>(int id, T entity)
        {
            string json = JsonConvert.SerializeObject(entity, settings);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PutAsync($"api/{typeof(T).Name}/{id}", content);
            return response.IsSuccessStatusCode;
        }

        public static async Task<bool> DeleteAsync<T>(int id)
        {
            HttpResponseMessage response = await _httpClient.DeleteAsync($"api/{typeof(T).Name}/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}

using System;
using System.Configuration;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Service.Liquidacion.Http
{
    public class ClienteLiq
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptiones;

        public ClienteLiq()
        {

            string baseUrl = ConfigurationManager.AppSettings["server"]!;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

            //_httpClient = new HttpClient
            //{
            //    BaseAddress = new Uri("https://localhost:7033/api/v1/")
            //};

            // Configurar otros aspectos del HttpClient si es necesario
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

           _jsonOptiones = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await _httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return await _httpClient.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return await _httpClient.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return await _httpClient.DeleteAsync(requestUri);
        }

        public JsonSerializerOptions GetJsonOptions()
            => this._jsonOptiones;
    }
}

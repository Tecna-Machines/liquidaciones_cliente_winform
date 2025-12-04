using System.Configuration;
using System.Text.Json;

namespace DAL.Service.Liquidacion.Http
{
    public class ClientApiLiquidacion
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _jsonOptiones;

        public ClientApiLiquidacion()
        {

            string baseUrl = ConfigurationManager.AppSettings["server"]!;

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };

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

        public async Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content)
        {
            return await _httpClient.PatchAsync(requestUri, content);
        }

        public JsonSerializerOptions GetJsonOptions()
            => this._jsonOptiones;
    }
}

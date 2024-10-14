using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.RetencionDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.AgregarItems
{
    public class AgregarRetencion
    {
        private readonly ClienteLiq _client;

        public AgregarRetencion(ClienteLiq client)
        {
            _client = client;
        }

        public async Task<RetencionDTO> CrearRetencion(CrearRetencionDTO retencion)
        {
            HttpContent data = JsonContent.Create(retencion);
            HttpResponseMessage response = await _client.PostAsync("Retencion", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            RetencionDTO? remu = JsonSerializer.Deserialize<RetencionDTO>(responseBody, _client.GetJsonOptions());

            return remu ?? throw new NullReferenceException();
        }

    }
}

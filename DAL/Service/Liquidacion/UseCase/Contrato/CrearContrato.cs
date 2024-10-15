using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class CrearContrato
    {
        private readonly ClienteLiq _client;

        public CrearContrato(ClienteLiq client)
        {
            _client = client;
        }

        public async Task<ContratoDTO> CrearUnContrato(CrearContratoDTO contratoNuevo)
        {
            HttpContent data = JsonContent.Create(contratoNuevo);
            HttpResponseMessage response = await _client.PostAsync("Contrato", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            ContratoDTO? contrato = JsonSerializer.Deserialize<ContratoDTO>(responseBody, _client.GetJsonOptions());

            return contrato ?? throw new NullReferenceException();
        }
    }
}

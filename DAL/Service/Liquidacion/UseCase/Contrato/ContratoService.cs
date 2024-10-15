using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class ContratoService
    {
        private readonly ClienteLiq _client;

        public ContratoService(ClienteLiq client)
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

        public async Task<List<ResumenContratoDTO>> ObtenerContratosEmpleados(string dniEmp)
        {
            HttpResponseMessage response = await _client.GetAsync($"Empleado/{dniEmp}/contratos");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<ResumenContratoDTO>? contratos = JsonSerializer.Deserialize<List<ResumenContratoDTO>>(responseBody, _client.GetJsonOptions());

            return contratos ?? throw new NullReferenceException();
        }

        public async Task<ContratoDTO> ObtenerContrato(string codContrato)
        {
            HttpResponseMessage response = await _client.GetAsync($"Contrato/{codContrato}");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            ContratoDTO? contrato = JsonSerializer.Deserialize<ContratoDTO>(responseBody, _client.GetJsonOptions());

            return contrato ?? throw new NullReferenceException();
        }
    }
}

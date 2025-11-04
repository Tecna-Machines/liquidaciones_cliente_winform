using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class ContratoService
    {
        private readonly ApiLiquidacion _client;

        public ContratoService(ApiLiquidacion client)
        {
            _client = client;
        }



        public async Task<List<ResumenContratoDTO>> ObtenerContratosEmpleados(string dniEmp)
        {
            HttpResponseMessage response = await _client.GetAsync($"Empleado/{dniEmp}/contratos");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<ResumenContratoDTO>? contratos = JsonSerializer.Deserialize<List<ResumenContratoDTO>>(responseBody, _client.GetJsonOptions());

            return contratos ?? throw new NullReferenceException();
        }
    }
}

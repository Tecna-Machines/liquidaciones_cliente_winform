using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados
{
    public class ObtenerContratoEmpleadoVIEJO
    {
        private readonly ApiLiquidacion Client;

        public ObtenerContratoEmpleadoVIEJO(ApiLiquidacion client)
        {
            Client = client;
        }


        public async Task<ContratoDTO> ObtenerUltimoContratoEmp(string dniEmp)
        {
            string endponint = $"Empleado/{dniEmp}/contrato";

            HttpResponseMessage response = await Client.GetAsync(endponint);

            if (!response.IsSuccessStatusCode)
            {
                throw new IOException();
            }

            string responseBody = await response.Content.ReadAsStringAsync();
            ContratoDTO? contrato = JsonSerializer.Deserialize<ContratoDTO>(responseBody, Client.GetJsonOptions());

            return contrato ?? throw new NullReferenceException();
        }
    }
}

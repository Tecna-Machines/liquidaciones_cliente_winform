using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados
{
    public class RecuperarEmpleado
    {
        private readonly ApiLiquidacion Client;

        public RecuperarEmpleado(ApiLiquidacion client)
        {
            this.Client = client;
        }

        public async Task<List<GetEmpleadoResponse>> ObtenerEmpleados()
        {
            HttpResponseMessage response = await Client.GetAsync("Empleado");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            List<GetEmpleadoResponse>? lista = JsonSerializer.Deserialize<List<GetEmpleadoResponse>>(responseBody,Client.GetJsonOptions());

            return lista ?? throw new NullReferenceException();
        }

        public async Task<GetEmpleadoResponse> RecuperarEmpleadoDetalle(string dniEmp)
        {
            HttpResponseMessage response = await Client.GetAsync($"Empleado/{dniEmp}");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            GetEmpleadoResponse? emp = JsonSerializer.Deserialize<GetEmpleadoResponse>(responseBody, Client.GetJsonOptions());

            return emp ?? throw new NullReferenceException();
        }
    }
}

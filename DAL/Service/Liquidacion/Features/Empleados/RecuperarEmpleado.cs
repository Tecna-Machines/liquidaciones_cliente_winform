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

        public async Task<List<EmpleadoResponse>> ObtenerEmpleados()
        {
            HttpResponseMessage response = await Client.GetAsync("Empleado");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            List<EmpleadoResponse>? lista = JsonSerializer.Deserialize<List<EmpleadoResponse>>(responseBody,Client.GetJsonOptions());

            return lista ?? throw new NullReferenceException();
        }

        public async Task<EmpleadoResponse> RecuperarEmpleadoDetalle(string dniEmp)
        {
            HttpResponseMessage response = await Client.GetAsync($"Empleado/{dniEmp}");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            EmpleadoResponse? emp = JsonSerializer.Deserialize<EmpleadoResponse>(responseBody, Client.GetJsonOptions());

            return emp ?? throw new NullReferenceException();
        }
    }
}

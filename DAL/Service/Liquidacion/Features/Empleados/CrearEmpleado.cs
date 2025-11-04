using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados
{
    public class CrearEmpleado
    {
        private readonly ApiLiquidacion _client;

        public CrearEmpleado(ApiLiquidacion client)
        {
            _client = client;
        }

        public async Task<EmpleadoResponse> CrearUnEmpleado(CrearEmpleadoRequest emp)
        {
            HttpContent data = JsonContent.Create(emp);
            HttpResponseMessage response = await _client.PostAsync("Empleado", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            EmpleadoResponse? remu = JsonSerializer.Deserialize<EmpleadoResponse>(responseBody, _client.GetJsonOptions());

            return remu ?? throw new NullReferenceException();
        }

        public async Task AsignarRetencionesEmpleado(List<string> codigos,string numeroCuenta)
        {
            string jsonArray = JsonSerializer.Serialize(codigos);

            // Crear el contenido HTTP
            HttpContent data = new StringContent(jsonArray, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync($"Cuenta/{numeroCuenta}/retenciones-fijas",data);

            response.EnsureSuccessStatusCode();
        }
    }
}

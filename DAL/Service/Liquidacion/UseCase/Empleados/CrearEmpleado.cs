using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados
{
    public class CrearEmpleado
    {
        private readonly ClienteLiq _client;

        public CrearEmpleado(ClienteLiq client)
        {
            _client = client;
        }

        public async Task<EmpleadoDTO> CrearUnEmpleado(CrearEmpleadoDTO emp)
        {
            HttpContent data = JsonContent.Create(emp);
            HttpResponseMessage response = await _client.PostAsync("Empleado", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            EmpleadoDTO? remu = JsonSerializer.Deserialize<EmpleadoDTO>(responseBody, _client.GetJsonOptions());

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

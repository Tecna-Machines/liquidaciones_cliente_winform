using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados
{
    public class RecuperarEmpleado
    {
        private readonly ClienteLiq Client;

        public RecuperarEmpleado(ClienteLiq client)
        {
            this.Client = client;
        }

        public async Task<List<EmpleadoDTO>> ObtenerEmpleados()
        {
            HttpResponseMessage response = await Client.GetAsync("Empleado");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            List<EmpleadoDTO>? lista = JsonSerializer.Deserialize<List<EmpleadoDTO>>(responseBody,Client.GetJsonOptions());

            return lista ?? throw new NullReferenceException();
        }

        public async Task<EmpleadoDTO> RecuperarEmpleadoDetalle(string dniEmp)
        {
            HttpResponseMessage response = await Client.GetAsync($"Empleado/{dniEmp}");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            EmpleadoDTO? emp = JsonSerializer.Deserialize<EmpleadoDTO>(responseBody, Client.GetJsonOptions());

            return emp ?? throw new NullReferenceException();
        }
    }
}

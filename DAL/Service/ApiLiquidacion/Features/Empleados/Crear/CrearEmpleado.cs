using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Empleados.Crear
{
    internal class CrearEmpleado
    {
        private readonly ClientApiLiquidacion _api;

        public CrearEmpleado(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearEmpleadoResponse> CargarEmpleado(CrearEmpleadoRequest req)
        {
            var json = JsonSerializer.Serialize(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Llamada HTTP POST
            HttpResponseMessage response = await _api.PostAsync("Empleado", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 201)
            {
                return await GetJsonValue<CrearEmpleadoResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear un empleado");
        }
    }
}

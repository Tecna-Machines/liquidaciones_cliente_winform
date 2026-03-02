using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.CrearMarca
{
    internal class CrearEmpleadoAsistencia
    {
        private readonly ClientApiLiquidacion _api;

        public CrearEmpleadoAsistencia(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearEmpleadoAsistenciaResponse> Crear(CrearEmpleadoAsistenciaRequest req)
        {

            var json = JsonSerializer.Serialize(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _api.PostAsync("Empleado/asistencia", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 201)
            {
                return await GetJsonValue<CrearEmpleadoAsistenciaResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear asistencia");
        }
    }
}

using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion
{
    internal class CrearLiquidacionHandler
    {
        private readonly ClientApiLiquidacion _api;

        public CrearLiquidacionHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearLiquidacionResponse> CrearLiquidacion(CrearLiquidacionRequest req)
        {
            var json = JsonSerializer.Serialize(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Llamada HTTP POST
            HttpResponseMessage response = await _api.PostAsync("Liquidacion", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            //TODO: deberia de ser un 201
            if (statusCode == 200)
            {
                return await GetJsonValue<CrearLiquidacionResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear un empleado");
        }
    }
}

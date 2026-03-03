using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Feriados.CrearFeriado
{
    internal class CrearFeriadoHandler
    {
        private readonly ClientApiLiquidacion _api;

        public CrearFeriadoHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearFeriadoResponse> Crear(CrearFeriadoRequest req)
        {
            var json = JsonSerializer.Serialize(req);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _api.PostAsync($"Feriado", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 200)
            {
                return await GetJsonValue<CrearFeriadoResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear el feriado");
        }
    }
}

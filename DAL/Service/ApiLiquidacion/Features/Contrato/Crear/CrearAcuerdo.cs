using DAL.Service.Liquidacion.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.Features.Contrato.Crear
{
    internal class CrearAcuerdo
    {
        private readonly ClientApiLiquidacion _api;
        public CrearAcuerdo(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<string> CargarAcuerdo(CrearAcuerdoRequest acuerdo)
        {
            using HttpContent requestContent = JsonContent.Create(acuerdo);

            HttpResponseMessage response = await _api.PostAsync("Acuerdo", requestContent);
            string body = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(body);

            JsonElement root = doc.RootElement;

            int statusCode = await GetHttpStatusCode.GetCode(response);


            CrearAcuerdoResponse acuerdoCreado = await GetJsonValue<CrearAcuerdoResponse>
                                                       .GetBodyValue(response);
            return acuerdoCreado.Codigo;

        }
    }
}

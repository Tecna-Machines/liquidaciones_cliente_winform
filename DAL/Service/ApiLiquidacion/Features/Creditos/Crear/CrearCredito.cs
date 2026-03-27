using DAL.Service.Liquidacion.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Crear
{
    internal class CrearCredito
    {
        private readonly ClientApiLiquidacion _api;

        public CrearCredito(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearCreditoResponse> Crear(CrearCreditoRequest acuerdo)
        {
            using HttpContent requestContent = JsonContent.Create(acuerdo);

            HttpResponseMessage response = await _api.PostAsync("Credito", requestContent);
            string body = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(body);

            JsonElement root = doc.RootElement;

            int statusCode = await GetHttpStatusCode.GetCode(response);

            //JsonElement value = root.GetProperty("value");

            //if (statusCode >= 400)
            //{
            //    if (value.TryGetProperty("descripcion", out JsonElement desc))
            //    {
            //        string? msg = desc.GetString();
            //        throw new InvalidOperationException(msg ?? "Error al crear el credito.");
            //    }

            //    throw new InvalidOperationException("Error al crear el credito.");
            //}

            CrearCreditoResponse credito = await GetJsonValue<CrearCreditoResponse>
                                                       .GetBodyValue(response);
            return credito;

        }
    }
}

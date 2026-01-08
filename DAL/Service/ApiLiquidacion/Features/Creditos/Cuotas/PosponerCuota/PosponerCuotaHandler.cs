using DAL.Service.Liquidacion.Http;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Cuotas.PosponerCuota
{
    internal class PosponerCuotaHandler
    {
        private readonly ClientApiLiquidacion _api;

        public PosponerCuotaHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task Posponer(PosponerCuotaRequest req)
        {

            HttpResponseMessage response = await _api.PostAsync($"Credito/{req.CodigoCredito}/cuota/{req.NroCuota}/posponer", null);
            string body = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(body);

            JsonElement root = doc.RootElement;

            int statusCode = await GetHttpStatusCode.GetCode(response);

            JsonElement value = root.GetProperty("value");

            if (statusCode >= 400)
            {
                if (value.TryGetProperty("descripcion", out JsonElement desc))
                {
                    string? msg = desc.GetString();
                    throw new InvalidOperationException(msg ?? "Error al crear el credito.");
                }

                throw new InvalidOperationException("Error al crear el credito.");
            }

        }
    }
}

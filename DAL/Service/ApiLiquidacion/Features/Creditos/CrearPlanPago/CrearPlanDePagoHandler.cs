using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.CrearPlanPago
{
    internal class CrearPlanDePagoHandler
    {
        private readonly ClientApiLiquidacion _api;

        public CrearPlanDePagoHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearPlanDePagoResponse> Crear(string codigoCredito, CrearPlanDePagoRequest solicitudPlan)
        {
            var json = JsonSerializer.Serialize(solicitudPlan);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Llamada HTTP POST
            HttpResponseMessage response = await _api.PostAsync($"credito/{codigoCredito}/plan-de-pago", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 200)
            {
                return await GetJsonValue<CrearPlanDePagoResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear un empleado");
        }
    }
}

using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.Liquidacion.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.Pagar
{
    internal class PagarLiquidacionHandler
    {
        private readonly ClientApiLiquidacion _api;

        public PagarLiquidacionHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<PagoCreadoResponse> PagarLiquidacion(CrearPagoRequest pago)
        {
            var json = JsonSerializer.Serialize(pago);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _api.PostAsync($"pago", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 200)
            {
                return await GetJsonValue<PagoCreadoResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("erro.pago");
        }
    }
}

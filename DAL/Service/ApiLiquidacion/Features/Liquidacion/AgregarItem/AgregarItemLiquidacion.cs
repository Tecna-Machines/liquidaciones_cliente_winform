using DAL.Service.Liquidacion.Http;
using System.Text;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem
{
    internal class AgregarItemLiquidacion
    {
        private readonly ClientApiLiquidacion _api;

        public AgregarItemLiquidacion(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<CrearItemResponse> CrearItem(string codigoLiquidacion, CrearItemRequest itemData)
        {
            var json = JsonSerializer.Serialize(itemData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _api.PostAsync($"Liquidacion/{codigoLiquidacion}/items", content);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode == 200)
            {
                return await GetJsonValue<CrearItemResponse>.GetBodyValue(response);
            }

            throw new ArgumentException("no se pudo crear un empleado");
        }
    }
}

using DAL.Service.Liquidacion.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato.Crear
{
    internal class CrearAcuerdo
    {
        private readonly ApiLiquidacion _api;
        public CrearAcuerdo(ApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<string> CargarAcuerdo(CrearAcuerdoRequest acuerdo)
        {
            using HttpContent data = JsonContent.Create(acuerdo);

            HttpResponseMessage response = await _api.PostAsync("Acuerdo", data);
            string body = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(body);

            JsonElement root = doc.RootElement;

            int statusCode = root.GetProperty("statusCode").GetInt32();

            JsonElement value = root.GetProperty("value");

            // si statusCode indica error:
            if (statusCode >= 400)
            {
                if (value.TryGetProperty("descripcion", out JsonElement desc))
                {
                    string? msg = desc.GetString();
                    throw new InvalidOperationException(msg ?? "Error al crear el acuerdo.");
                }

                throw new InvalidOperationException("Error al crear el acuerdo.");
            }

            if (value.TryGetProperty("codigo", out JsonElement codigoElement))
            {
                string? codigo = codigoElement.GetString();

                if (!string.IsNullOrWhiteSpace(codigo))
                    return codigo;
            }

            throw new NullReferenceException("No se encontró 'codigo' en la respuesta.");
        }
    }
}

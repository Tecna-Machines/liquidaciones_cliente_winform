using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class ContratoService
    {
        private readonly ApiLiquidacion _client;

        public ContratoService(ApiLiquidacion client)
        {
            _client = client;
        }

        public async Task<string> CrearUnContrato(CrearAcuerdoRequest acuerdo)
        {
            using HttpContent data = JsonContent.Create(acuerdo);

            HttpResponseMessage response = await _client.PostAsync("Acuerdo", data);
            string body = await response.Content.ReadAsStringAsync();

            // Parseamos la respuesta tipo:
            // { "value": { ... }, "statusCode": 200, "contentType": null }
            using JsonDocument doc = JsonDocument.Parse(body);

            JsonElement root = doc.RootElement;

            // leo el statusCode que vino en el JSON envuelto
            int statusCode = root.GetProperty("statusCode").GetInt32();

            JsonElement value = root.GetProperty("value");

            // si statusCode indica error:
            if (statusCode >= 400)
            {
                // intento leer el mensaje de error para tirarlo como excepción linda
                if (value.TryGetProperty("descripcion", out JsonElement desc))
                {
                    string? msg = desc.GetString();
                    throw new InvalidOperationException(msg ?? "Error al crear el acuerdo.");
                }

                throw new InvalidOperationException("Error al crear el acuerdo.");
            }

            // si fue OK: saco el código del acuerdo
            if (value.TryGetProperty("codigo", out JsonElement codigoElement))
            {
                string? codigo = codigoElement.GetString();

                if (!string.IsNullOrWhiteSpace(codigo))
                    return codigo;
            }

            throw new NullReferenceException("No se encontró 'codigo' en la respuesta.");
        }



        public async Task<List<ResumenContratoDTO>> ObtenerContratosEmpleados(string dniEmp)
        {
            HttpResponseMessage response = await _client.GetAsync($"Empleado/{dniEmp}/contratos");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<ResumenContratoDTO>? contratos = JsonSerializer.Deserialize<List<ResumenContratoDTO>>(responseBody, _client.GetJsonOptions());

            return contratos ?? throw new NullReferenceException();
        }

        public async Task<ContratoDTO> ObtenerContrato(string codContrato)
        {
            HttpResponseMessage response = await _client.GetAsync($"Contrato/{codContrato}");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            ContratoDTO? contrato = JsonSerializer.Deserialize<ContratoDTO>(responseBody, _client.GetJsonOptions());

            return contrato ?? throw new NullReferenceException();
        }
    }
}

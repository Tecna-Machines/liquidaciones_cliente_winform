using System.Text.Json;

namespace DAL.Service.Liquidacion.Http
{
    internal static class GetJsonValue<TResponse>
    {
        public static async Task<TResponse> GetBodyValue(HttpResponseMessage response)
        {
            string body = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(body);
            JsonElement root = doc.RootElement;

            //if (!root.TryGetProperty("value", out JsonElement valueEl))
            //    throw new InvalidOperationException("Response JSON does not contain 'value' property.");

            TResponse result = JsonSerializer.Deserialize<TResponse>(
                root.GetRawText(),
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            )!;

            return result;
        }
    }
}

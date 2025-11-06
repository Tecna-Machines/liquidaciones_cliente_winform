using System.Text.Json;

namespace DAL.Service.Liquidacion.Http
{
    internal static class GetHttpStatusCode
    {
        public async static Task<int> GetCode(HttpResponseMessage response)
        {

            string body = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(body);


            return doc.RootElement.GetProperty("statusCode").GetInt32();
        }
    }
}

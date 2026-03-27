namespace DAL.Service.Liquidacion.Http
{
    internal static class GetHttpStatusCode
    {
        public async static Task<int> GetCode(HttpResponseMessage response)
        {
            return (int)response.StatusCode;
        }
    }
}

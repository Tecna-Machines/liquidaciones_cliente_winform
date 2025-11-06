using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.Features.Empleados.GetEmpleados
{
    public class GetTodosEmpleados
    {
        private readonly ApiLiquidacion _api;

        public GetTodosEmpleados(ApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetEmpleadosResponse> GetTodos()
        {

            HttpResponseMessage response = await _api.GetAsync("Empleados");
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<GetEmpleadosResponse>.GetBodyValue(response);
        }
    }
}

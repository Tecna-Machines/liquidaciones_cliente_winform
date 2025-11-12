using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado
{
    internal class GetAcuerdoEmpleadoHandler
    {
        private readonly ApiLiquidacion _api;

        public GetAcuerdoEmpleadoHandler(ApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetAcuerdosEmpleadosResponse> GetAcuerdos(string dni)
        {
            HttpResponseMessage response = await _api.GetAsync($"Empleado/{dni}/acuerdos");
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<GetAcuerdosEmpleadosResponse>.GetBodyValue(response);
        }

    }
}

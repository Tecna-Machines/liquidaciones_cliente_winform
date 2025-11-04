using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.UseCase.Empleados.Crear
{
    internal class CrearEmpleado
    {
        private readonly ApiLiquidacion _api;

        public CrearEmpleado(ApiLiquidacion api)
        {
            _api = api;
        }

        public Task CargarEmpleado(CrearEmpleadoRequest req)
        {
            throw new NotImplementedException();
        }
    }
}

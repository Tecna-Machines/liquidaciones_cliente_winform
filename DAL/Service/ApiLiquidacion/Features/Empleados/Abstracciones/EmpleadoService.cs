using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;

namespace DAL.Service.Liquidacion.Features.Empleados.Abstracciones
{
    internal class EmpleadoService : IEmpleadoService
    {
        private readonly CrearEmpleado _crear;
        private readonly GetTodosEmpleados _getEmpleados;

        public EmpleadoService(CrearEmpleado crear, GetTodosEmpleados getEmpleados)
        {
            _crear = crear;
            _getEmpleados = getEmpleados;
        }

        public async Task<CrearEmpleadoResponse> Crear(CrearEmpleadoRequest empleado)
        {
            return await _crear.CargarEmpleado(empleado);
        }

        public async Task<GetEmpleadosResponse> GetAll()
        {
            return await _getEmpleados.GetTodos();
        }
    }
}

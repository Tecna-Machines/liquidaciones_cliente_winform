using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;

namespace DAL.Service.Liquidacion.Features.Empleados.Abstracciones
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly CrearEmpleado _crear;
        private readonly GetTodosEmpleados _getEmpleados;

        public EmpleadoService(CrearEmpleado crear, GetTodosEmpleados getEmpleados)
        {
            _crear = crear;
            _getEmpleados = getEmpleados;
        }

        public Task Crear(CrearEmpleadoRequest empleado)
        {
            _crear.CargarEmpleado(empleado);
            throw new NotImplementedException();
        }

        public async Task<GetEmpleadosResponse> GetAll()
        {
            return await _getEmpleados.GetTodos();
        }
    }
}

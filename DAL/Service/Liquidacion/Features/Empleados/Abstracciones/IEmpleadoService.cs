using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;

namespace DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones
{
    public interface IEmpleadoService
    {
        Task Crear(CrearEmpleadoRequest empleado);
        Task<GetEmpleadosResponse> GetAll(); 
    }
}

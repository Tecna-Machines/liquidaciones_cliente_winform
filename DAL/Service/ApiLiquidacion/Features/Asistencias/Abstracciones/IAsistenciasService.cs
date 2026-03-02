using DAL.Service.ApiLiquidacion.Features.Asistencias.CrearMarca;
using DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones
{
    public interface IAsistenciasService
    {
        Task<GetEmpleadoAsistenciasResponse> GetAsistencia(string dni, DateTime inicio, DateTime fin);
        Task<CrearEmpleadoAsistenciaResponse>  CrearAsistencia(string dni,DateTime ingreso,DateTime egreso);
    }
}

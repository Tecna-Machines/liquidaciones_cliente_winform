using DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones
{
    public interface IAsistenciasService
    {
        Task<GetEmpleadoAsistenciasResponse> GetAsistencia(string dni, DateTime inicio, DateTime fin);
    }
}

using DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones
{
    internal class AsistenciaService : IAsistenciasService
    {
        private readonly GetAsistencia _getAsistencia;

        public AsistenciaService(GetAsistencia getAsistencia)
        {
            _getAsistencia = getAsistencia;
        }

        public async Task<GetEmpleadoAsistenciasResponse> GetAsistencia(string dni, DateTime inicio, DateTime fin)
        {
            return await _getAsistencia.GetAsistencias(dni, inicio, fin);
        }
    }
}

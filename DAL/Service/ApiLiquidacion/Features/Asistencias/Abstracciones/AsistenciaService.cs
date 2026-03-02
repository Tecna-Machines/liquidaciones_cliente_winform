using DAL.Service.ApiLiquidacion.Features.Asistencias.CrearMarca;
using DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones
{
    internal class AsistenciaService : IAsistenciasService
    {
        private readonly GetAsistencia _getAsistencia;
        private readonly CrearEmpleadoAsistencia _crearAsistencia;

        public AsistenciaService(GetAsistencia getAsistencia, CrearEmpleadoAsistencia crearAsistencia)
        {
            _getAsistencia = getAsistencia;
            _crearAsistencia = crearAsistencia;
        }

        public async Task<GetEmpleadoAsistenciasResponse> GetAsistencia(string dni, DateTime inicio, DateTime fin)
        {
            return await _getAsistencia.GetAsistencias(dni, inicio, fin);
        }

        public async Task<CrearEmpleadoAsistenciaResponse> CrearAsistencia(string dni, DateTime ingreso, DateTime egreso)
        {
            return await _crearAsistencia.Crear(new CrearEmpleadoAsistenciaRequest(dni, ingreso, egreso));
        }
    }
}

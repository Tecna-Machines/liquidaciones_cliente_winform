using DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Asistencias.CrearMarca;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;

namespace BLL.Controllers
{
    public class EmpleadoController
    {

        private readonly IEmpleadoService _empleados;
        private readonly IAcuerdoService _acuerdos;
        private readonly IAsistenciasService _asistencias;
        public EmpleadoController(IEmpleadoService empleados,
                                  IAcuerdoService acuerdos,
                                  IAsistenciasService asistencias)
        {
            _empleados = empleados;
            _acuerdos = acuerdos;
            _asistencias = asistencias;
        }

        public async Task CrearEmpleado(CrearEmpleadoRequest empDto)
        {

            try
            {
                await _empleados.Crear(empDto);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        public async Task<List<GetEmpleadoResponse>> ObtenerEmpleados()
        {
            var response = await _empleados.GetAll();
            return response.Empleados;
        }

        public async Task<GetAcuerdosEmpleadosResponse> GetHistorialAcuerdosEmpleado(string dniEmp)
        {
            return await _acuerdos.GetAcuerdosEmpleado(dniEmp);
        }

        public async Task<CrearEmpleadoAsistenciaResponse> CrearAsistencia(string dni, DateTime ingreso, DateTime egreso)
        {
            return await _asistencias.CrearAsistencia(dni, ingreso, egreso);
        }
    }
}

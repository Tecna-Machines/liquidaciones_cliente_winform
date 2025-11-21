using DAL.Service.Liquidacion.Features.Contrato.Abstracciones;
using DAL.Service.Liquidacion.Features.Contrato.Crear;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;

namespace DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones
{
    internal class AcuerdoService : IAcuerdoService
    {
        private readonly CrearAcuerdo _crearAcuerdo;
        private readonly GetAcuerdoEmpleadoHandler _getAcuerdos;
        private readonly GetAcuerdoById _getAcuerdoById;

        public AcuerdoService(CrearAcuerdo crearAcuerdo, GetAcuerdoEmpleadoHandler getAcuerdos, GetAcuerdoById getAcuerdoById)
        {
            _crearAcuerdo = crearAcuerdo;
            _getAcuerdos = getAcuerdos;
            _getAcuerdoById = getAcuerdoById;
        }

        public async Task<string> Crear(CrearAcuerdoRequest req)
        {
            return await _crearAcuerdo.CargarAcuerdo(req);
        }

        public async Task<GetAcuerdosEmpleadosResponse> GetAcuerdosEmpleado(string dni)
        {
            return await _getAcuerdos.GetAcuerdos(dni);
        }

        async Task<GetAcuerdoByIdResponse> IAcuerdoService.GetById(string id)
        {
            return await _getAcuerdoById.GetById(id);
        }
    }
}

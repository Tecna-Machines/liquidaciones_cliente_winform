using DAL.Service.Liquidacion.Features.Contrato.Crear;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;

namespace DAL.Service.Liquidacion.Features.Contrato.Abstracciones
{
    public interface IAcuerdoService
    {
        Task<string> Crear(CrearAcuerdoRequest req);
        Task<GetAcuerdosEmpleadosResponse> GetAcuerdosEmpleado(string dni);
        Task<GetAcuerdoByIdResponse> GetById(string id);
    }
}

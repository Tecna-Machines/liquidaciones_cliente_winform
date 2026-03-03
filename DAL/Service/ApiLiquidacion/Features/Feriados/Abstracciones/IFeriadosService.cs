using DAL.Service.ApiLiquidacion.Features.Feriados.CrearFeriado;

namespace DAL.Service.ApiLiquidacion.Features.Feriados.Abstracciones
{
    public interface IFeriadosService
    {
        Task<CrearFeriadoResponse> CrearFeriado(CrearFeriadoRequest req);
    }
}

using DAL.Service.ApiLiquidacion.Features.Feriados.CrearFeriado;

namespace DAL.Service.ApiLiquidacion.Features.Feriados.Abstracciones
{
    internal class FeriadoService : IFeriadosService
    {
        private readonly CrearFeriadoHandler _crearFeriado;

        public FeriadoService(CrearFeriadoHandler crearFeriado)
        {
            _crearFeriado = crearFeriado;
        }

        public async Task<CrearFeriadoResponse> CrearFeriado(CrearFeriadoRequest req)
        {
            return await _crearFeriado.Crear(req);
        }
    }
}

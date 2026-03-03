using DAL.Service.ApiLiquidacion.Features.Feriados.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Feriados.CrearFeriado;

namespace BLL.Controllers
{
    public class FeriadoController
    {
        private readonly IFeriadosService _feriados;

        public FeriadoController(IFeriadosService feriados)
        {
            _feriados = feriados;
        }

        public async Task<CrearFeriadoResponse> CrearUnFeriado(DateTime fecha, string descripcion, bool esPermanente)
        {
            return await _feriados.CrearFeriado(new CrearFeriadoRequest(fecha, descripcion, esPermanente));
        }
    }
}

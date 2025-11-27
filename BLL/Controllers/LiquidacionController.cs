using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena;
using DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace BLL.Controllers
{
    public class LiquidacionController
    {
        private readonly ILiquidacionService _liquidacion;

        public LiquidacionController(ILiquidacionService liquidacion)
        {
            _liquidacion = liquidacion;
        }

        public async Task<GetLiquidacionByIdResponse> GetById(string id)
        {
            return await _liquidacion.GetLiquidacion(id);
        }

        public async Task<string> Create(string dni, int mes, int anio, int quincena)
        {
            var req = new CrearLiquidacionRequest(dni, anio, mes, quincena);
            var result = await _liquidacion.Crear(req);

            return result.Codigo;
        }

        public async Task<GetLiquidacionByIdResponse> Liquidar(string codigo)
        {
            var req = await _liquidacion.Liquidar(codigo);

            return await _liquidacion.GetLiquidacion(req.Codigo);
        }

        public async Task<CrearItemResponse> AgregarItem(string codigo, CrearItemRequest req)
        {
            return await _liquidacion.AgregarItem(codigo, req);
        }

        public async Task<GetLiquidacionesResponse> GetLiquidacionesByQuincena(int quincena,int mes,int anio)
        {
            return await _liquidacion.GetByQuincena(quincena, mes, anio);
        }
    }
}

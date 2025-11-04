using DAL.Service.Liquidacion.UseCase.Contrato.Crear;

namespace DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones
{
    internal class AcuerdoService : IAcuerdoService
    {
        private readonly CrearAcuerdo _crearAcuerdo;

        public AcuerdoService(CrearAcuerdo crearAcuerdo)
        {
            _crearAcuerdo = crearAcuerdo;
        }

        public async Task<string> Crear(CrearAcuerdoRequest req)
        {
            return await _crearAcuerdo.CargarAcuerdo(req);
        }
    }
}

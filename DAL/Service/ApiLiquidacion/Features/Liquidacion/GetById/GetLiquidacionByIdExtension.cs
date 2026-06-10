using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.GetById
{
    public static class GetLiquidacionByIdExtension
    {

        private static int ACEPTADO = 0;
        private static int Remunerativo = 0;
        private static int Descuento = 1;
        private static int NoRemunerativo = 2;
        private static int Retencion = 3;
        public static decimal ObtenerBrutoOficial(this GetLiquidacionByIdResponse liquidacion)
        {
            return liquidacion.Items
                             .Where(x => x.Estado == ACEPTADO)
                            .Where(x => x.EsEnBlanco)
       .Where(x =>
           x.TipoItem == Remunerativo ||
           x.TipoItem == NoRemunerativo)
       .Sum(x => x.Monto);

        }

        public static decimal ObtenerRetencionesOficiales(this GetLiquidacionByIdResponse liquidacion)
        {
            return liquidacion.Items
                    .Where(x => x.Estado == ACEPTADO)
                    .Where(x => x.EsEnBlanco)
                    .Where(x =>
                           x.TipoItem == Retencion ||
                           x.TipoItem == Descuento)
                    .Sum(x => x.Monto);
        }

        public static decimal ObtenerDescuentosInterno(this GetLiquidacionByIdResponse liquidacion)
        {
            return liquidacion.Items
                    .Where(x => x.Estado == ACEPTADO)
                    .Where(x => !x.EsEnBlanco)
                    .Where(x =>
                            x.TipoItem == Retencion ||
                            x.TipoItem == Descuento)
                    .Sum(x => x.Monto);
        }


        public static decimal ObtenerBrutoInterno(this GetLiquidacionByIdResponse liquidacion)
        {
            return liquidacion.Items
         .Where(x => x.Estado == ACEPTADO)
         .Where(x => !x.EsEnBlanco)
         .Where(x =>
             x.TipoItem == Remunerativo ||
             x.TipoItem == NoRemunerativo)
         .Sum(x => x.Monto);

        }

        public static decimal ObtenerNoRemunerativo(this GetLiquidacionByIdResponse liquidacion)
        {
            return liquidacion.Items
         .Where(x => x.Estado == ACEPTADO)
         .Where(x => x.EsEnBlanco)
         .Where(x =>
             x.TipoItem == NoRemunerativo)
         .Sum(x => x.Monto);

        }

    }
}

using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.AgregarItems;
using LAUCHA.application.DTOs.DescuentoDTOs;
using LAUCHA.application.DTOs.RemuneracionDTOs;
using LAUCHA.application.DTOs.RetencionDTOs;

namespace BLL.Controllers
{
    public class AgregarItemController
    {
        private readonly ClienteLiq clienteLiq;
        private readonly AgregarRemuneracion agregarRemuneracion;
        private readonly AgregarDescuento agregarDescuento;
        private readonly AgregarRetencion agregarRetencion;

        public AgregarItemController()
        {
            clienteLiq = new ClienteLiq();
            agregarRemuneracion = new(clienteLiq);
            agregarDescuento = new(clienteLiq);
            agregarRetencion = new(clienteLiq);
        }

        public async Task<RemuneracionDTO> CrearUnaRemuneracion(string descripcion, string monto, string numeroCuenta, bool esBlanco)
        {
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(monto) || string.IsNullOrEmpty(numeroCuenta))
            {
                throw new ArgumentNullException();
            }

            decimal montoD;

            bool castCorrecto = decimal.TryParse(monto, out montoD);

            if (!castCorrecto)
            {
                throw new InvalidCastException();
            }


            var remu = new CrearRemuneracionDTO
            {
                Descripcion = descripcion,
                Monto = montoD,
                EsBlanco = esBlanco,
                Cuenta = numeroCuenta
            };

            var result = await this.agregarRemuneracion.CrearRemuneracionD(remu);

            return result;
        }

        public async Task<DescuentoDTO> CrearUnDescuento(string description,string monto,string numeroCuenta,int? numeroConcepto)
        {
            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(monto) || string.IsNullOrEmpty(numeroCuenta))
            {
                throw new ArgumentNullException();
            }

            decimal montoD;

            bool castCorrecto = decimal.TryParse(monto, out montoD);

            if (!castCorrecto)
            {
                throw new InvalidCastException();
            }

            var desc = new CrearDescuentoDTO
            {
                Descripcion = description,
                NumeroCuenta = numeroCuenta,
                NumeroConcepto = numeroConcepto,
                Monto = montoD
            };

            var descuento = await agregarDescuento.CrearDescuento(desc);

            return descuento;
        }

        public async Task<RetencionDTO> CrearUnaRetencion(string descripcion,string monto,string numeroCuenta)
        {
            if (string.IsNullOrEmpty(descripcion) || string.IsNullOrEmpty(monto) || string.IsNullOrEmpty(numeroCuenta))
            {
                throw new ArgumentNullException();
            }

            decimal montoD;

            bool castCorrecto = decimal.TryParse(monto, out montoD);

            if (!castCorrecto)
            {
                throw new InvalidCastException();
            }

            var reten = new CrearRetencionDTO
            {
                Descripcion = descripcion,
                Monto = montoD,
                NumeroCuenta = numeroCuenta
            };

            var result = await agregarRetencion.CrearRetencion(reten);

            return result;
        }
    }
}

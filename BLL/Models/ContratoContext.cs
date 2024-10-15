using LAUCHA.application.DTOs.AcuerdoBlancoDTOs;
using LAUCHA.application.DTOs.ContratoDTOs;

namespace BLL.Models
{
    public sealed class ContratoContext
    {
        private ContratoDTO _contrato;

        private ContratoContext() { }

        private static ContratoContext? _instancia;

        public static ContratoContext GetInstance()
        {
            if (_instancia == null)
            {
                _instancia = new ContratoContext();
            }

            return _instancia;
        }

        public CrearContratoDTO CrearContrato(string dni, string modaliad, decimal montoFijo, decimal montoBlanco, decimal montoHora)
        {

            VerificarMontos(montoFijo, montoBlanco, montoHora);

            return new CrearContratoDTO
            {
                Dni = dni,
                MontoHora = montoHora,
                MontoFijo = montoFijo,
                Modalidad = modaliad,
                Tipo = "permanente",
                Adicionales = Array.Empty<string>(),
                AcuerdoBlanco = new AcuerdoBlancoDTO
                {
                    Concepto = "monto bruto en el banco",
                    Cantidad = montoBlanco,
                    EsPorcentual = false
                }
            };
        }

        public void SetContrato(ContratoDTO contrato)
        {
            this._contrato = contrato;
        }

        public ContratoDTO GetContrato()
        {
            return this._contrato;
        }

        private void VerificarMontos(params decimal[] montos)
        {
            foreach (var monto in montos)
            {
                if (monto <= 0)
                {
                    throw new ArgumentException("Los montos no pueden ser menores a cero.");
                }
            }
        }
    }
}

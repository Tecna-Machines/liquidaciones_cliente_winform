using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.LiquidacionDTOs;

namespace BLL.Models
{
    public sealed class LiquidacionContext
    {
        private string dniEmpleado;
        private PeriodoDTO? periodoALiquidar;
        private LiquidacionDTO? liquidacion;
        private EmpleadoDTO? empleado;


        private LiquidacionContext() { }

        private static LiquidacionContext? _instancia;

        public static LiquidacionContext GetInstance()
        {
            if(_instancia == null)
            {
                _instancia = new LiquidacionContext();
            }

            return _instancia;
        }
        public LiquidacionDTO? ObtenerLiquidacion()
        {
            return liquidacion;
        }

        public PeriodoDTO? GetPeriodo()
        {
            return periodoALiquidar;
        }

        public LiquidacionDTO SetLiquidacion(LiquidacionDTO liq)
        {
            this.liquidacion = liq;
            return liquidacion;
        }

        public PeriodoDTO SetearPeriodo(PeriodoDTO periodo)
        {

            if(periodo.Inicio == periodo.Fin)
            {
                throw new IOException();
            }

            this.periodoALiquidar = periodo;
            return periodoALiquidar;
        }

        public void ResetearContexto()
        {
            this.liquidacion = null;
            this.periodoALiquidar = null;
        }

        public string GetDniEmpleado()
        {
            return this.dniEmpleado;
        }

        public void SetDniEmpleado(string dni)
        {
            this.dniEmpleado = dni;
        }

        public void SetEmpleado(EmpleadoDTO emp)
        {
            this.empleado = emp;
        }

        public EmpleadoDTO ObtenerDatosEmpleado() => this.empleado!;
    }
}

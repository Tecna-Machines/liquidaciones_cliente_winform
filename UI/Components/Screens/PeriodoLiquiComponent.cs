using BLL.Models;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using UI.Screens.HacerLiquidacion;

namespace UI
{
    public partial class PeriodoLiquiComponent : UserControl
    {
        public PeriodoLiquiComponent()
        {
            InitializeComponent();
        }

        private void ClickBtnConfirmarPeriodo(object sender, EventArgs e)
        {
            DateTime fechaInicio = this.calendarioFechaInicio.SelectionStart;
            DateTime fechaFin = this.calendarioFechaFin.SelectionStart;

            var periodoLiquidacion = new PeriodoDTO
            {
                Inicio = fechaInicio,
                Fin = fechaFin
            };

            LiquidacionContext context = LiquidacionContext.GetInstance();

           try
            {
                context.SetearPeriodo(periodoLiquidacion);
            }catch(IOException)
            {
                MessageBox.Show("error al colocar las fechas");
                return;
            }

            CrearLiquidacionForm form = new();
            form.Show();
        }
    }
}

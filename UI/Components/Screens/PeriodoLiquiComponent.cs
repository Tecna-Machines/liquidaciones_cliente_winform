using BLL.Models;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using System;
using UI.Screens.HacerLiquidacion;

namespace UI
{
    public partial class PeriodoLiquiComponent : UserControl
    {
        private bool segundaQuincenaActiva = false;
        private bool primeraQuincenaActiva = false;
        public event EventHandler<bool>? EventPrimeraQuincena;
        public PeriodoLiquiComponent()
        {
            InitializeComponent();
            this.SetearLabelPeriodo();
        }

        private void SetearLabelPeriodo()
        {
            string month = DateTime.Now.ToString("MMMM").ToUpper();
            string year = DateTime.Now.ToString("yyyy");

            this.labelFecha.Text = $"MES DE {month} DE {year}";

            // Calcular las fechas para las quincenas
            DateTime primerDiaDelMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime dia15 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15);
            DateTime dia16 = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16);
            int ultimoDiaMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            // Asignar las quincenas a los labels
            this.periodoPrimerQuincena.Text = $"(01 al 15)";
            this.periodoSegunQuincena.Text = $"(16 al {ultimoDiaMes})";
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


            if(this.primeraQuincenaActiva)
            {
                periodoLiquidacion = new PeriodoDTO
                {
                    Inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                    Fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 15)
                };

            }

            if (this.segundaQuincenaActiva)
            {
                int ultimoDiaMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

                periodoLiquidacion = new PeriodoDTO
                {
                    Inicio = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 16),
                    Fin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, ultimoDiaMes),
                };

            }


            LiquidacionContext context = LiquidacionContext.GetInstance();

            try
            {
                context.SetearPeriodo(periodoLiquidacion);
            }
            catch (IOException)
            {
                MessageBox.Show("error al colocar las fechas");
                return;
            }

            CrearLiquidacionForm form = new(this,this.primeraQuincenaActiva);
            form.Show();
        }

        private void ClickUsarCalendario(object sender, EventArgs e)
        {
            this.panelPeriodo.Visible = false;
        }

        private void ClickBtnPrimerQuincena(object sender, EventArgs e)
        {
            this.btnPrimerQuincena.BackColor = Color.LightGreen;
            this.btnSegQuincena.BackColor = SystemColors.ControlLightLight;

            this.primeraQuincenaActiva = true;
            this.segundaQuincenaActiva = false;

            EventPrimeraQuincena?.Invoke(this,true);
        }

        private void ClickBtnSegundaQuicena(object sender, EventArgs e)
        {
            this.btnSegQuincena.BackColor = Color.LightGreen;
            this.btnPrimerQuincena.BackColor = SystemColors.ControlLightLight;

            this.segundaQuincenaActiva = true;
            this.primeraQuincenaActiva = false;

            EventPrimeraQuincena?.Invoke(this, false);
        }
    }
}

using BLL.Models;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using UI.Screens.HacerLiquidacion;

namespace UI
{
    public partial class PeriodoLiquiComponent : UserControl
    {
        public event EventHandler<bool>? EventPrimeraQuincena;
        private bool segundaQuincenaActiva = false;
        private bool primeraQuincenaActiva = false;
        private int year;
        private int mes;

        public PeriodoLiquiComponent()
        {
            InitializeComponent();
            this.InicializarForm();
        }

        private void SetearLabelPeriodo()
        {
            int ultimoDiaMes = DateTime.DaysInMonth(this.year, this.mes);

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


            if (this.primeraQuincenaActiva)
            {
                int selectedMesIndex = comboBoxMeses.SelectedIndex + 1;
                int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
                // Ahora puedes usar selectedMesIndex y selectedYear

                this.mes = selectedMesIndex;
                this.year = selectedYear;

                periodoLiquidacion = new PeriodoDTO
                {
                    Inicio = new DateTime(this.year, this.mes, 1),
                    Fin = new DateTime(this.year, this.mes, 15)
                };

            }

            if (this.segundaQuincenaActiva)
            {
                int selectedMesIndex = comboBoxMeses.SelectedIndex + 1;
                int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
                // Ahora puedes usar selectedMesIndex y selectedYear

                this.mes = selectedMesIndex;
                this.year = selectedYear;

                int ultimoDiaMes = DateTime.DaysInMonth(this.year, this.mes);

                periodoLiquidacion = new PeriodoDTO
                {
                    Inicio = new DateTime(this.year, this.mes, 16),
                    Fin = new DateTime(this.year, this.mes, ultimoDiaMes),
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

            CrearLiquidacionForm form = new(this, this.primeraQuincenaActiva);
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

            EventPrimeraQuincena?.Invoke(this, true);
        }

        private void ClickBtnSegundaQuicena(object sender, EventArgs e)
        {
            this.btnSegQuincena.BackColor = Color.LightGreen;
            this.btnPrimerQuincena.BackColor = SystemColors.ControlLightLight;

            this.segundaQuincenaActiva = true;
            this.primeraQuincenaActiva = false;

            EventPrimeraQuincena?.Invoke(this, false);
        }

        private void InicializarForm()
        {

            this.comboBoxMeses.Items.Clear();
            DateTime ahora = DateTime.Now;

            for (int i = 1; i <= 12; i++)
            {
                this.comboBoxMeses.Items.Add(new DateTime(ahora.Year, i, 1).ToString("MMMM").ToUpper());
            }

            this.comboBoxMeses.SelectedIndex = ahora.Month - 1;

            this.comboBoxYear.Items.Clear();

            for (int i = 0; i <= 5; i++)
            {
                // Restar los años al año actual
                int year = ahora.Year - i;
                this.comboBoxYear.Items.Add(year.ToString());
            }

            this.comboBoxYear.SelectedIndex = 0;

            if (comboBoxMeses.SelectedIndex != -1 && comboBoxYear.SelectedItem != null)
            {
                int selectedMesIndex = comboBoxMeses.SelectedIndex + 1;
                int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
                // Ahora puedes usar selectedMesIndex y selectedYear

                this.mes = selectedMesIndex;
                this.year = selectedYear;

                this.SetearLabelPeriodo();
            }

        }

        private void InputMesCambio(object sender, EventArgs e)
        {
            if (comboBoxMeses.SelectedIndex != -1 && comboBoxYear.SelectedItem != null)
            {
                int selectedMesIndex = comboBoxMeses.SelectedIndex + 1;
                int selectedYear = int.Parse(comboBoxYear.SelectedItem.ToString());
                // Ahora puedes usar selectedMesIndex y selectedYear

                this.mes = selectedMesIndex;
                this.year = selectedYear;

                this.SetearLabelPeriodo();
            }

        }

    }
}

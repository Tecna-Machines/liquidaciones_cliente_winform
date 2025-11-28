using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using UI.Screens.VerLiquidacion;

namespace UI.Screens.Liquidaciones.HistorialLiquidaciones
{
    public partial class HistorialLiquidacionesForm : Form
    {
        private readonly LiquidacionController _controllerLiquidacion;
        public HistorialLiquidacionesForm(LiquidacionController controllerLiquidacion)
        {
            InitializeComponent();

            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.Items.AddRange(
                DateTimeFormatInfo.CurrentInfo.MonthNames
                    .Where(m => !string.IsNullOrWhiteSpace(m))
                    .ToArray()
            );

            int yearActual = DateTime.Now.Year;
            for (int y = yearActual; y > yearActual - 10; y--)
            {
                comboBoxYear.Items.Add(y);
            }

            _controllerLiquidacion = controllerLiquidacion;
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que haya selección
            if (comboBoxQuincena.SelectedIndex == -1 ||
                comboBoxMeses.SelectedIndex == -1 ||
                comboBoxYear.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná quincena, mes y año.");
                return;
            }

            int quincena = int.Parse((string)comboBoxQuincena.SelectedItem);
            int mes = comboBoxMeses.SelectedIndex + 1;
            int anio = (int)comboBoxYear.SelectedItem;

            var resultado = await _controllerLiquidacion.GetLiquidacionesByQuincena(quincena, mes, anio);

            LimpiarTablaResultados();
            SetTablaResultados(resultado.Liquidaciones);
        }

        private void SetTablaResultados(IEnumerable<LiquidacionResumenResponse> liquidaciones)
        {
            foreach (var liq in liquidaciones)
            {
                SetItemResultado(liq);
            }
        }

        private void SetItemResultado(LiquidacionResumenResponse liq)
        {
            var resultado = new ListViewItem(liq.Codigo);
            resultado.SubItems.Add(liq.NombreEmpleado);
            resultado.SubItems.Add(liq.DniEmpleado);
            resultado.SubItems.Add(liq.Creacion.ToString("dd/MM/yyyy HH:mm"));
            resultado.SubItems.Add(liq.Sello.ToString("dd/MM/yyyy HH:mm"));

            if (liq.SeSello)
            {
                resultado.BackColor = Color.ForestGreen;
                resultado.SubItems.Add("SELLADA");
            }
            else
            {
                resultado.BackColor = Color.LightYellow;
                resultado.SubItems.Add("PENDIENTE");
            }

            tablaLiquidaciones.Items.Add(resultado);
        }

        private void LimpiarTablaResultados()
        {
            tablaLiquidaciones.Items.Clear();
        }

        private void TablaLiquidaciones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tablaLiquidaciones.FocusedItem != null)
            {
                string codigoLiquidacion = tablaLiquidaciones.FocusedItem.SubItems[0].Text;
                BuscarLiquidacion(codigoLiquidacion);
            }
        }

        private async void BuscarLiquidacion(string codigo)
        {
            var liquidacion = await _controllerLiquidacion.GetById(codigo);

            var formLiquidacion = Program.ServiceProvider.GetRequiredService<VerLiquidacionForm>();
            formLiquidacion.SetLiquidacion(liquidacion);

            formLiquidacion.ShowDialog();
        }
    }
}

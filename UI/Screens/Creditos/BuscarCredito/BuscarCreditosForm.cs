using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos;

namespace UI.Screens.Creditos.BuscarCredito
{
    public partial class BuscarCreditosForm : Form
    {
        private readonly CreditoController _controller;
        public BuscarCreditosForm(CreditoController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            tablaDeResultados.Items.Clear();
            BuscarCreditos();
        }

        private async void BuscarCreditos()
        {
            var filtro = ConstruirFiltro();

            var resultados = await _controller.Buscar(filtro);
            CargarTablaResultados(resultados);
        }

        private FiltroCredito ConstruirFiltro()
        {
            int? estado = comboBoxEstado.SelectedIndex >= 0
                            ? comboBoxEstado.SelectedIndex
                            : (int?)null;

            decimal? montoMin = null;
            if (decimal.TryParse(textMontoMinimo.Text, out var minParsed))
                montoMin = minParsed;

            decimal? montoMax = null;
            if (decimal.TryParse(textMontoMaximo.Text, out var maxParsed))
                montoMax = maxParsed;

            DateTime? fechaDesdeFiltro = null;
            if (fechaDesde.Checked) // DateTimePicker con checkbox
                fechaDesdeFiltro = fechaDesde.Value.Date;

            DateTime? fechaHastaFiltro = null;
            if (fechaHasta.Checked)
                fechaHastaFiltro = fechaHasta.Value.Date;

            return new FiltroCredito
            {
                Dni = string.IsNullOrWhiteSpace(textBoxDni.Text)
                    ? null
                    : textBoxDni.Text.Trim(),

                Estado = estado,
                MontoMin = montoMin,
                MontoMax = montoMax,
                CreacionDesde = fechaDesdeFiltro,
                CreacionHasta = fechaHastaFiltro
            };
        }

        private void CargarTablaResultados(GetCreditosResponse resultado)
        {
            foreach (var credito in resultado.Creditos)
            {
                var item = MapCreditoResultado(credito);
                tablaDeResultados.Items.Add(item);
            }

            labelResultados.Text = $"Resultados {resultado.Creditos.Count()}";
        }

        private ListViewItem MapCreditoResultado(GetCreditoResumen credito)
        {
            var item = new ListViewItem(credito.Codigo);
            item.SubItems.Add(credito.DniEmpleado);
            item.SubItems.Add(credito.Descripcion);
            item.SubItems.Add(credito.Cuotas.ToString());
            item.SubItems.Add(credito.MontoPrestado.ToString("C"));
            item.SubItems.Add(credito.Estado);

            return item;
        }

    }
}

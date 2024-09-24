using BLL.Controllers;
using BLL.Models;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using UI.Screens.Marcas;
using UI.Screens.VerLiquidacion;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearLiquidacionForm : Form
    {
        private readonly CrearLiquidacionController _controller;
        private List<EmpleadoDTO> _empleados;
        private LiquidacionContext _context;
        private PeriodoDTO _periodoLiquidar;


        private List<EmpleadoDTO> empleadoDTOs;
        public CrearLiquidacionForm()
        {
            _context = LiquidacionContext.GetInstance();
            _periodoLiquidar = _context.GetPeriodo();

            _controller = new();

            InitializeComponent();
            IniciarConfiguraciones();


            this.listaEmpComponent1.EventDniSeleccionado += OnEmpleadoSeleccionado;

        }

        private async void IniciarConfiguraciones()
        {
            this.empleadoDTOs = await this._controller.ObtenerTodosLosEmpleado();
            this.listaEmpComponent1.CargarLista(this.empleadoDTOs);

            this.SetearLabelPeriodo(_periodoLiquidar);

        }

        private async void OnEmpleadoSeleccionado(object? sender, string dni)
        {
            EmpleadoDTO? empleado = empleadoDTOs.FirstOrDefault(emp => emp.Dni == dni);
            this.LimpiarTodasLasTablasLiquidacion();

            if (empleado == null)
            {
                return;
            }

            this.dniLabel.Text = $"DNI: {empleado.Dni}";
            this.nombreLabel.Text = $"Nombre Completo: {empleado.Nombre} {empleado.Apellido}";

            _context.SetDniEmpleado(empleado.Dni);

            var contrato = await _controller.ObtenerContratoActual(empleado.Dni);
            this.CargarTablaContrato(contrato);
        }

        private void SetearLabelPeriodo(PeriodoDTO? periodo)
        {
            if (periodo == null)
            {
                MessageBox.Show("no se ha seteado el periodo");
                return;
            }

            string inicio = periodo.Inicio.ToString("dd/MM/yyyy");
            string fin = periodo.Fin.ToString("dd/MM/yyyy");

            this.labelPeriodo.Text = $"periodo a liquidar: {inicio} hasta {fin}";
        }

        private void CargarTablaContrato(ContratoDTO contrato)
        {

            ListUtils.LimpiarElementos(this.listContrato);

            var contratoItem = new ListViewItem(contrato.Codigo);
            contratoItem.SubItems.Add(contrato.MontoFijo.ToString("c"));
            contratoItem.SubItems.Add(contrato.MontoHora.ToString("c"));
            contratoItem.SubItems.Add(contrato.Modalidad.Descripcion);
            listContrato.Items.Add(contratoItem);

        }

        private async void ClickBtnPreLiquidar(object sender, EventArgs e)
        {
            this.LimpiarTodasLasTablasLiquidacion();
            string dni = _context.GetDniEmpleado();
            PeriodoDTO periodo = _context.GetPeriodo();

            var liquidacionSimulada = await _controller.SimularLiquidacion(dni,periodo);

            _context.SetLiquidacion(liquidacionSimulada);

            this.CargarTablasLiquidacion(liquidacionSimulada);
        }


        private async void ClickBtnConfirmarLiquidacion(object sender, EventArgs e)
        {
            string leyenda = "estas a punt de confirmar la liquidacion , revisa cuidadosamente";
            MessageBox.Show(leyenda);


            var formVerLiqui = new VerLiquidacionForm();
            formVerLiqui.Show();
        }

        private void LimpiarTodasLasTablasLiquidacion()
        {
            ListUtils.LimpiarElementos(this.listaSueldoBlanco);
            ListUtils.LimpiarElementos(this.listaSueldoBillete);
            ListUtils.LimpiarElementos(this.listaSubtotales);
        }

        private void ClickBtnMarcas(object sender, EventArgs e)
        {
            var marcasForm = new MarcasForm();
            marcasForm.Show();
        }

        private void CargarTablasLiquidacion(LiquidacionDTO liq)
        {
            liq.Items.Remuneraciones.Where(r => r.EsBlanco == true).ToList().ForEach(r =>
            {
                DateTime result;
                DateTime.TryParse(r.Fecha, out result);

                var item = new ListViewItem(r.Descripcion);
                item.SubItems.Add(result.ToString("dd/MM/yyyyy"));
                item.SubItems.Add(r.Monto.ToString("c"));
                item.SubItems.Add("");
                item.SubItems.Add("");

                listaSueldoBlanco.Items.Add(item);
            });

            liq.Items.Retenciones.ForEach(rt =>
            {
                var item = new ListViewItem(rt.Descripcion);
                item.SubItems.Add(rt.Fecha.ToString("dd/MM/yyyyy"));
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(rt.Monto.ToString("c"));

                listaSueldoBlanco.Items.Add(item);
            });

            listaSueldoBlanco.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            liq.Items.Remuneraciones.Where(r => r.EsBlanco == false).ToList().ForEach(rn =>
            {
                DateTime result;
                DateTime.TryParse(rn.Fecha, out result);

                var item = new ListViewItem(rn.Descripcion);
                item.SubItems.Add(result.ToString("dd/MM/yyyy"));
                item.SubItems.Add(rn.Monto.ToString("c"));

                listaSueldoBillete.Items.Add(item);

            });

            liq.Items.Descuentos.ForEach(d =>
            {
                var item = new ListViewItem(d.Descripcion);
                item.SubItems.Add(d.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(d.Monto.ToString("c"));

                listaSueldoBillete.Items.Add(item);
            });

            this.CargaTablaSubtotales(liq);
            this.CargarTablaPagarEmpleado(liq);
        }

        private void CargaTablaSubtotales(LiquidacionDTO liquidacion)
        {
            var itemRemunerativo = new ListViewItem("REMUNERATIVO");
            itemRemunerativo.SubItems.Add(liquidacion.TotalBrutoBanco.ToString("c"));


            var montoRetenciones = liquidacion.Items.Retenciones.Sum(r => r.Monto);

            var itemRetenciones = new ListViewItem("RETENCIONES");
            itemRetenciones.SubItems.Add(montoRetenciones.ToString("c"));

            var itemNegro = new ListViewItem("EN NEGRO");
            itemNegro.SubItems.Add(liquidacion.TotalBrutoEfectivo.ToString("c"));

            listaSubtotales.Items.Add(itemRemunerativo);
            listaSubtotales.Items.Add(itemRetenciones);
            listaSubtotales.Items.Add(itemNegro);
        }

        private void CargarTablaPagarEmpleado(LiquidacionDTO liquidacion)
        {

            int pagarBanco = 0;
            int pagarEfectivo = 1;

            listaPagarEmpleado.Items[pagarBanco].SubItems.Add(liquidacion.TotalPagarBanco.ToString("c"));
            listaPagarEmpleado.Items[pagarEfectivo].SubItems.Add(liquidacion.TotalPagarEfectivo.ToString("c"));
        }


    }
}

using BLL.Controllers;
using BLL.Enums;
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
        private bool _esPrimeraQuincena;
        private PeriodoLiquiComponent _periodoComponent;


        private List<EmpleadoDTO> empleadoDTOs;
        public CrearLiquidacionForm(PeriodoLiquiComponent periodoComponent, bool esPrimeraQuincena)
        {
            _context = LiquidacionContext.GetInstance();
            _periodoLiquidar = _context.GetPeriodo();

            _controller = new();
            IniciarConfiguraciones();

            InitializeComponent();


            this.listaEmpComponent1.EventDniSeleccionado += OnEmpleadoSeleccionado;

            _esPrimeraQuincena = esPrimeraQuincena;
        }

        private async void PrimeraQuincenaSeteada(bool primeraQuincenaActiva)
        {
            if (primeraQuincenaActiva)
            {
                var empleadosPrimeraQuincena = this.empleadoDTOs
                 .Where(emp =>
                !string.IsNullOrEmpty(emp.ContratoResumen.CodigoModalidad) &&
                int.TryParse(emp.ContratoResumen.CodigoModalidad, out int codigoModalidad) &&
                EsModalidadQuincenal(codigoModalidad)) // Llama a un método que verifica si es modalidad quincenal
                .ToList();

                this.listaEmpComponent1.CargarLista(empleadosPrimeraQuincena);
            }

        }

        private bool EsModalidadQuincenal(int codigoModalidad)
        {
            return codigoModalidad == (int)Modalidad.QuincenalPorHora ||
                   codigoModalidad == (int)Modalidad.QuincenalFijo ||
                   codigoModalidad == (int)Modalidad.QuincenajFijoMasExtra;
        }

        private async void IniciarConfiguraciones()
        {
            this.empleadoDTOs = await this._controller.ObtenerTodosLosEmpleado();
            this.listaEmpComponent1.CargarLista(this.empleadoDTOs);

            this.SetearLabelPeriodo(_periodoLiquidar);

            this.PrimeraQuincenaSeteada(this._esPrimeraQuincena);

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
            _context.SetEmpleado(empleado);

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

            bool primeraQuincea = periodo.Inicio.Day <= 15;
            string mes = periodo.Inicio.ToString("MMMM");

            this.labelQuincena.Text = $"[1ra quincena {mes}]";

            if (!primeraQuincea)
            {
                this.labelQuincena.Text = $"[ 2da quincena {mes}]";
            }
        }

        private void CargarTablaContrato(ContratoDTO contrato)
        {

            ListUtils.LimpiarElementos(this.listContrato);


            string montoBlanco = contrato.AcuerdoBlanco.Cantidad.ToString("c");

            if (contrato.AcuerdoBlanco.EsPorcentual)
            {
                montoBlanco = $"{contrato.AcuerdoBlanco.Cantidad}%";
            }

            var contratoItem = new ListViewItem(contrato.Codigo);
            contratoItem.SubItems.Add(contrato.MontoFijo.ToString("c"));
            contratoItem.SubItems.Add(contrato.MontoHora.ToString("c"));
            contratoItem.SubItems.Add(contrato.Modalidad.Descripcion);
            contratoItem.SubItems.Add(montoBlanco);
            listContrato.Items.Add(contratoItem);

        }

        private async void ClickBtnPreLiquidar(object sender, EventArgs e)
        {
            this.LimpiarTodasLasTablasLiquidacion();
            string dni = _context.GetDniEmpleado();
            PeriodoDTO periodo = _context.GetPeriodo();

            LiquidacionDTO liquidacionSimulada;

            try
            {
                liquidacionSimulada = await _controller.SimularLiquidacion(dni, periodo);

            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un problema durante la simulacion");
                return;
            }

            _context.SetLiquidacion(liquidacionSimulada);

            this.CargarTablasLiquidacion(liquidacionSimulada);
        }


        private async void ClickBtnConfirmarLiquidacion(object sender, EventArgs e)
        {
            string leyenda = "Estás a punto de confirmar la liquidación, revisa cuidadosamente.";

            DialogResult result = MessageBox.Show(leyenda, "Confirmar Liquidación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);



            if (result == DialogResult.Yes)
            {
                var liquidacion = await _controller.ConfirmarLiquidacion(_context.GetDniEmpleado(), _context.GetPeriodo());

                _context.SetLiquidacion(liquidacion);

                var formVerLiqui = new VerLiquidacionForm();
                formVerLiqui.Show();
            }
            else
            {
                MessageBox.Show("La liquidación no ha sido confirmada.", "Acción cancelada");
            }
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

            listaPagarEmpleado.Items.Clear();

            var itemEfectivo = new ListViewItem("EN EL SOBRE");
            itemEfectivo.SubItems.Add(liquidacion.TotalPagarEfectivo.ToString("C"));

            var itemBanco = new ListViewItem("EN EL BANCO");
            itemBanco.SubItems.Add(liquidacion.TotalPagarBanco.ToString("C"));

            listaPagarEmpleado.Items.Add(itemBanco);
            listaPagarEmpleado.Items.Add(itemEfectivo);
        }

        private void ClickBtnAgregarItem(object sender, EventArgs e)
        {
            var formItems = new CrearItemForm();

            formItems.Show();
        }
    }
}

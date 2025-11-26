using BLL.Controllers;
using BLL.Enums;
using BLL.Models;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using Microsoft.Extensions.DependencyInjection;
using UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion;
using UI.Screens.Marcas;
using UI.Screens.VerLiquidacion;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearLiquidacionForm : Form
    {
        private readonly CrearLiquidacionController _controller;
        private readonly EmpleadoController _empleadoController;
        private LiquidacionContext _context;
        private Quincena _periodoLiquidar;
        private bool _esPrimeraQuincena;
        private LiquidacionController _liquidacionController;


        private int _quincena;
        private int _anio;
        private int _mes;
        private string _dniEmpleado;

        private List<GetEmpleadoResponse> empleadoDTOs;
        public CrearLiquidacionForm(EmpleadoController empleadoController, LiquidacionController liquidacionController)
        {
            _context = LiquidacionContext.GetInstance();
            _periodoLiquidar = null;

            _controller = Program.ServiceProvider.GetRequiredService<CrearLiquidacionController>(); ;

            InitializeComponent();


            this.listaEmpComponent1.EventDniSeleccionado += OnEmpleadoSeleccionado;

            _esPrimeraQuincena = false;
            _empleadoController = empleadoController;
            IniciarConfiguraciones();
            _liquidacionController = liquidacionController;
        }

        public void SetQuincena(int quincena, int mes, int anio)
        {
            string quincenaStr = "error";
            string mesStr = MesMapper.MapToString(mes);

            _mes = mes;
            _anio = anio;

            if (quincena == 1)
            {
                _quincena = quincena;
                quincenaStr = "1ra";
                _esPrimeraQuincena = true;
            }
            else
            {
                quincenaStr = "2da";
                _quincena = quincena;
                _esPrimeraQuincena = false;
            }

            textBoxPeriodo.Text = $"{quincenaStr} {mesStr} {anio}";
        }
        public void EsPrimeraQuicena() => _esPrimeraQuincena = true;

        private async void PrimeraQuincenaSeteada(bool primeraQuincenaActiva)
        {
            if (primeraQuincenaActiva)
            {
                var empleadosPrimeraQuincena = this.empleadoDTOs
                 .Where(emp =>
                emp.TipoSueldo != -1 &&
                EsModalidadQuincenal(emp.TipoSueldo)) // Llama a un método que verifica si es modalidad quincenal
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
            var response = await _empleadoController.ObtenerEmpleados();
            this.empleadoDTOs = response.ToList();
            this.listaEmpComponent1.CargarLista(this.empleadoDTOs);


            this.PrimeraQuincenaSeteada(this._esPrimeraQuincena);

        }

        private void OnEmpleadoSeleccionado(object? sender, string dni)
        {
            GetEmpleadoResponse? emp = empleadoDTOs.FirstOrDefault(emp => emp.Dni == dni);
            this.LimpiarTodasLasTablasLiquidacion();

            if (emp == null)
            {
                return;
            }

            _dniEmpleado = emp.Dni;
            textBoxEmpleado.Text = $"{emp.Dni} - {emp.Nombre} {emp.Apellido}";
        }   


        private async void BtnRecalcular_Click(object sender, EventArgs e)
        {
            var codigo = GenerarCodigoLiquidacion();

            var liquidacion = await _liquidacionController.GetById(codigo);
            SetLiquidacion(liquidacion);

            Dialog.Success(liquidacion.Empleado.Dni + "existe!!1");
        }

        private void SetLiquidacion(GetLiquidacionByIdResponse liquidacion)
        {
            TablaAcuerdoLiquidacionForm.SetTablaAcuerdo(liquidacion, tablaAcuerdo);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnBlanco(liquidacion, tablaDetalleEnBlanco);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnNegro(liquidacion, listaSueldoBillete);

            valorPagarBlanco.Text = liquidacion.Montos.EnBlanco.ToString("C");
            valorPagarNegro.Text = liquidacion.Montos.EnNegro.ToString("C");
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

                var formVerLiqui = Program.ServiceProvider.GetRequiredService<VerLiquidacionForm>();
                formVerLiqui.Show();
            }
            else
            {
                MessageBox.Show("La liquidación no ha sido confirmada.", "Acción cancelada");
            }
        }

        private void LimpiarTodasLasTablasLiquidacion()
        {
            ListUtils.LimpiarElementos(this.tablaDetalleEnBlanco);
            ListUtils.LimpiarElementos(this.listaSueldoBillete);
        }

        private void ClickBtnMarcas(object sender, EventArgs e)
        {
            var marcasForm = new MarcasForm();
            marcasForm.Show();
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
        }

        private void CargarTablaPagarEmpleado(LiquidacionDTO liquidacion)
        {


            var itemEfectivo = new ListViewItem("EN EL SOBRE");
            itemEfectivo.SubItems.Add(liquidacion.TotalPagarEfectivo.ToString("C"));

            var itemBanco = new ListViewItem("EN EL BANCO");
            itemBanco.SubItems.Add(liquidacion.TotalPagarBanco.ToString("C"));


        }

        private void ClickBtnAgregarItem(object sender, EventArgs e)
        {
            var formItems = new CrearItemForm();

            formItems.ShowDialog();
        }

        private  string GenerarCodigoLiquidacion()
            => $"{_anio}:{_mes}:{_quincena}:{_dniEmpleado}";
    }
}

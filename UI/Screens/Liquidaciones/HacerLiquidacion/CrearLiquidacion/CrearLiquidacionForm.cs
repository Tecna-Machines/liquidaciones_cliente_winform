using BLL.Controllers;
using BLL.Enums;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion;
using UI.Screens.Marcas;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearLiquidacionForm : Form
    {
        private readonly CrearItemForm _formItem;
        private readonly EmpleadoController _empleadoController;
        private LiquidacionController _liquidacionController;


        private int _quincena;
        private int _anio;
        private int _mes;
        private string _dniEmpleado;
        private bool _esPrimeraQuincena;

        private List<GetEmpleadoResponse> _empleados;
        public CrearLiquidacionForm(EmpleadoController empleadoController, LiquidacionController liquidacionController, CrearItemForm formItem)
        {
            InitializeComponent();

            listaConBuscador.EventDniSeleccionado += ClickEnEmpleadoSeleccionado;

            _empleados = new();
            _dniEmpleado = "default";
            _esPrimeraQuincena = false;
            _empleadoController = empleadoController;
            _liquidacionController = liquidacionController;

            CargarListaDeEmpleados();
            _formItem = formItem;
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

        private void MostrarSoloEmpleadosQuincenales()
        {
            if (_esPrimeraQuincena)
            {
                var empleadosPrimeraQuincena = this._empleados
                 .Where(emp =>
                emp.TipoSueldo != -1 &&
                EsModalidadQuincenal(emp.TipoSueldo)) // Llama a un método que verifica si es modalidad quincenal
                .ToList();

                listaConBuscador.CargarLista(empleadosPrimeraQuincena);
            }

        }

        private bool EsModalidadQuincenal(int codigoModalidad)
        {
            return codigoModalidad == (int)Modalidad.QuincenalPorHora ||
                   codigoModalidad == (int)Modalidad.QuincenalFijo ||
                   codigoModalidad == (int)Modalidad.QuincenajFijoMasExtra;
        }

        private async void CargarListaDeEmpleados()
        {
            var response = await _empleadoController.ObtenerEmpleados();

            _empleados = response.ToList();
            listaConBuscador.CargarLista(this._empleados);

            MostrarSoloEmpleadosQuincenales();

        }

        private void ClickEnEmpleadoSeleccionado(object? sender, string dni)
        {
            GetEmpleadoResponse? emp = _empleados.FirstOrDefault(emp => emp.Dni == dni);
            this.RemoverLiquidacionDePantalla();

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

            try
            {
                var liquidacion = await _liquidacionController.GetById(codigo);

                var liquidacionMostrar = await _liquidacionController.Liquidar(codigo);
                MostrarLiquidacionEnPantalla(liquidacionMostrar);

            }
            catch (Exception)
            {
                CrearLiquidacionSinItems();
            }


        }

        private async void CrearLiquidacionSinItems()
        {
            string leyenda = "al parecer esta persona aun no se ha liquidado , deseas crear una liquidacion nueva?";
            var result = Dialog.PopUpDeConfirmacion(leyenda, "nueva liquidacion");

            if (result == DialogResult.Yes)
            {

                var codigoNuevaLiquidacion = await _liquidacionController.Create(_dniEmpleado, _mes, _anio, _quincena);
                var liquidacion = await _liquidacionController.GetById(codigoNuevaLiquidacion);
                MostrarLiquidacionEnPantalla(liquidacion);
            }
;
        }

        private void MostrarLiquidacionEnPantalla(GetLiquidacionByIdResponse liquidacion)
        {
            RemoverLiquidacionDePantalla();

            TablaAcuerdoLiquidacionForm.SetTablaAcuerdo(liquidacion, tablaAcuerdo);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnBlanco(liquidacion, tablaDetalleEnBlanco);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnNegro(liquidacion, tablaDetalleEnNegro);

            valorPagarBlanco.Text = liquidacion.Montos.EnBlanco.ToString("C");
            valorPagarNegro.Text = liquidacion.Montos.EnNegro.ToString("C");
        }


        private void BtnSellar_Click(object sender, EventArgs e)
        {
            //TODO: completar
            throw new NotImplementedException();
        }

        private void RemoverLiquidacionDePantalla()
        {
            ListUtils.LimpiarElementos(this.tablaDetalleEnBlanco);
            ListUtils.LimpiarElementos(this.tablaDetalleEnNegro);
            ListUtils.LimpiarElementos(this.tablaAcuerdo);
        }

        private void ClickBtnMarcas(object sender, EventArgs e)
        {
            var marcasForm = new MarcasForm();
            marcasForm.Show();
        }

        private void ClickBtnAgregarItem(object sender, EventArgs e)
        {
            _formItem.SetLiquidacion(GenerarCodigoLiquidacion());
            _formItem.ShowDialog();
        }

        private string GenerarCodigoLiquidacion()
            => $"{_anio}:{_mes}:{_quincena}:{_dniEmpleado}";
    }
}

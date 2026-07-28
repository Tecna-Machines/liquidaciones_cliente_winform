using BLL.Controllers;
using BLL.Enums;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetById;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using UI.Screens.Asistencias.Marcas;
using UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion;
using UI.Screens.Liquidaciones.VerLiquidacion;
using UI.Screens.Marcas;
using UI.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearLiquidacionForm : Form
    {
        private readonly IServiceProvider _sp;

        private readonly CrearItemForm _formCrearItem;
        private readonly AnularItemForm _formAnularItem;
        private readonly EmpleadoController _empleadoController;
        private LiquidacionController _liquidacionController;

        private CargarPagosForm _crearPagoForm;


        private int _quincena;
        private int _anio;
        private int _mes;
        private string _dniEmpleado;
        private bool _esPrimeraQuincena;

        private string? _codigoLiquidacion;

        private List<GetEmpleadoResponse> _empleados;

        private GetLiquidacionByIdResponse? _liquidacionResponse;
        public CrearLiquidacionForm(EmpleadoController empleadoController,
                                    LiquidacionController liquidacionController,
                                    CrearItemForm formItem,
                                    AnularItemForm formAnularItem,
                                    IServiceProvider sp,
                                    CargarPagosForm crearPagoForm)
        {
            InitializeComponent();

            listaConBuscador.EventDniSeleccionado += ClickEnEmpleadoSeleccionado;

            _empleados = new();
            _dniEmpleado = "default";
            _esPrimeraQuincena = false;
            _empleadoController = empleadoController;
            _liquidacionController = liquidacionController;

            CargarListaDeEmpleados();
            _formCrearItem = formItem;
            _formAnularItem = formAnularItem;
            _sp = sp;
            _crearPagoForm = crearPagoForm;
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

            textBoxPeriodo.Text = $"{quincenaStr} Quincena - {mesStr} {anio}";
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
            IEnumerable<GetEmpleadoResponse> empleadosParaMostrar = _empleados;

            if (_esPrimeraQuincena)
            {
                empleadosParaMostrar = _empleados
                    .Where(emp =>
                        emp.TipoSueldo != -1 &&
                        EsModalidadQuincenal(emp.TipoSueldo));
            }

            listaConBuscador.CargarLista(empleadosParaMostrar.ToList());
        }

        private void ClickEnEmpleadoSeleccionado(object? sender, string dni)
        {
            GetEmpleadoResponse? emp = _empleados.FirstOrDefault(emp => emp.Dni == dni);

            DesbloquarAccionesLiquidacion();
            RemoverLiquidacionDePantalla();

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

            if (liquidacion is null)
            {
                CrearLiquidacionSinItems();
                return;
            }

            if (liquidacion.SeSello)
            {
                BloquearAccionesLiquidacion();
                MostrarLiquidacionEnPantalla(liquidacion);
                return;
            }

            var liquidacionProcesada = await _liquidacionController.Liquidar(liquidacion.Codigo);
            MostrarLiquidacionEnPantalla(liquidacionProcesada);
        }

        private async void CrearLiquidacionSinItems()
        {
            string leyenda = "al parecer esta persona aun no se ha liquidado , deseas crear una liquidacion nueva?";
            var result = Dialog.PopUpDeConfirmacion(leyenda, "nueva liquidacion");

            if (result == DialogResult.Yes)
            {

                var codigoNuevaLiquidacion = await _liquidacionController.Create(_dniEmpleado, _mes, _anio, _quincena);
                var liquidacion = await _liquidacionController.GetById(codigoNuevaLiquidacion);
                MostrarLiquidacionEnPantalla(liquidacion!);
            }
;
        }

        private void MostrarLiquidacionEnPantalla(GetLiquidacionByIdResponse liquidacion)
        {
            _liquidacionResponse = liquidacion;

            RemoverLiquidacionDePantalla();

            _codigoLiquidacion = liquidacion.Codigo;


            TablaAcuerdoLiquidacionForm.SetTablaAcuerdo(liquidacion, tablaAcuerdo);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnBlanco(liquidacion, tablaDetalleEnBlanco);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnNegro(liquidacion, tablaDetalleEnNegro);
            TablaPagosCrearLiquidacionForm.SetTablaPagos(liquidacion, lvPagos);


            decimal montoOficialFaltaPagar = _liquidacionResponse.MontosPago.NetoOficial - _liquidacionResponse.MontosPago.PagadoOficial;
            decimal montoInternoFaltaPagar = _liquidacionResponse.MontosPago.NetoInterno - _liquidacionResponse.MontosPago.PagadoInterno;

            LabelMontoOficialFaltaPagar.Text = montoOficialFaltaPagar.ToString("C");
            LabelMontoInternoFaltaPagar.Text = montoInternoFaltaPagar.ToString("C");


            // Footer de totales oficial
            lvTotales.Items.Clear();

            var itOficial = new ListViewItem("Totales:");

            itOficial.SubItems.Add(liquidacion.ObtenerBrutoOficial().ToString("C"));          // $ remun
            itOficial.SubItems.Add(liquidacion.ObtenerRetencionesOficiales().ToString("C")); // $ descuentos
            itOficial.SubItems.Add(liquidacion.ObtenerNoRemunerativo().ToString("C"));        // $ no remu
            itOficial.SubItems.Add($"neto: {liquidacion.MontosPago.NetoOficial.ToString("C")}");

            lvTotales.Items.Add(itOficial);


            // Footer de totales interno
            lvTotalesInterno.Items.Clear();

            var itInterno = new ListViewItem("Totales:");

            itInterno.SubItems.Add(liquidacion.ObtenerBrutoInterno().ToString("C"));          // $ remun
            itInterno.SubItems.Add(liquidacion.ObtenerDescuentosInterno().ToString("C")); // $ descuentos
            itInterno.SubItems.Add($"neto: {liquidacion.MontosPago.NetoInterno.ToString("C")}");

            lvTotalesInterno.Items.Add(itInterno);

            //Footer de totales pago
            lvMontosDePagos.Items.Clear();

            decimal pagadoOficial = liquidacion.MontosPago.PagadoOficial;
            decimal pagadoInterno = liquidacion.MontosPago.PagadoInterno;
            decimal pagadoTotal = pagadoInterno + pagadoOficial;

            var itPagos = new ListViewItem("Total:");
            itPagos.SubItems.Add(pagadoTotal.ToString("C"));
            itPagos.SubItems.Add("Oficial: " + pagadoOficial.ToString("C"));
            itPagos.SubItems.Add("Interno: " + pagadoInterno.ToString("C"));

            lvMontosDePagos.Items.Add(itPagos);
        }


        private void BtnSellar_Click(object sender, EventArgs e)
        {
            var formSellar = Program.ServiceProvider.GetRequiredService<SellarLiquidacionForm>();

            if (_codigoLiquidacion != null)
                formSellar.SetCodigoLiquidacion(_codigoLiquidacion);
            formSellar.ShowDialog();
        }

        private void RemoverLiquidacionDePantalla()
        {
            ListUtils.LimpiarElementos(this.tablaDetalleEnBlanco);
            ListUtils.LimpiarElementos(this.tablaDetalleEnNegro);
            ListUtils.LimpiarElementos(this.tablaAcuerdo);
            ListUtils.LimpiarElementos(this.lvPagos);
        }

        //TODO: Ojo! con esto ,no deben haber async en void
        private async void ClickBtnMarcas(object sender, EventArgs e)
        {
            var formMarcas = _sp.GetRequiredService<MarcasForm>();

            await formMarcas.GetAsistenciasYCargarTabla(
                new MarcasRequest(_dniEmpleado, _quincena, _mes, _anio)
            );

            formMarcas.Show();
        }

        private void ClickBtnAgregarItem(object sender, EventArgs e)
        {
            _formCrearItem.SetLiquidacion(GenerarCodigoLiquidacion());
            _formCrearItem.ShowDialog();
        }

        private string GenerarCodigoLiquidacion()
            => $"{_anio}:{_mes}:{_quincena}:{_dniEmpleado}";

        private void BloquearAccionesLiquidacion()
        {
            BtnSellar.Enabled = false;
            BtnRecalcular.Enabled = false;
            BtnItem.Enabled = false;
        }

        private void DesbloquarAccionesLiquidacion()
        {
            BtnSellar.Enabled = true;
            BtnRecalcular.Enabled = true;
            BtnItem.Enabled = true;
        }

        private void TablaDetalleEnBlanco_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tablaDetalleEnBlanco.SelectedItems.Count == 1)
            {
                int indx = tablaDetalleEnBlanco.SelectedItems[0].Index;
                var itemSeleccionado = tablaDetalleEnBlanco.Items[indx].Tag as ItemLiquidacionByIdResponse;

                AnularItem(itemSeleccionado);
            }
        }

        private void TablaDetalleEnNegro_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tablaDetalleEnNegro.SelectedItems.Count == 1)
            {
                int indx = tablaDetalleEnNegro.SelectedItems[0].Index;
                var itemSeleccionado = tablaDetalleEnNegro.Items[indx].Tag as ItemLiquidacionByIdResponse;

                AnularItem(itemSeleccionado);
            }
        }

        private void AnularItem(ItemLiquidacionByIdResponse? item)
        {
            if (item is null)
                return;

            if (_codigoLiquidacion is null)
                return;

            _formAnularItem.SetItem(_codigoLiquidacion, item);
            _formAnularItem.ShowDialog();
        }

        private void BtnCargarPago_Click(object sender, EventArgs e)
        {
            if (_codigoLiquidacion is null)
            {
                return;
            }

            _crearPagoForm.SetIdLiquidacion(_codigoLiquidacion);
            _crearPagoForm.ShowDialog();
        }

        private void BtnPagarOficialNeto_Click(object sender, EventArgs e)
        {
            if (_liquidacionResponse is null)
                return;

            decimal netoOficialTotal = _liquidacionResponse.MontosPago.NetoOficial;
            decimal netoOficialFaltante = netoOficialTotal - _liquidacionResponse.MontosPago.PagadoOficial;

            _crearPagoForm.SetIdLiquidacion(_codigoLiquidacion ?? throw new NullReferenceException("liq.id"));
            _crearPagoForm.SetMonto(netoOficialFaltante);
            _crearPagoForm.MarcarComoOficial();
            _crearPagoForm.MarcarComoTransferencia();
            _crearPagoForm.ShowDialog();
        }

        private void BtnPagarInternoNeto_Click(object sender, EventArgs e)
        {
            if (_liquidacionResponse is null)
                return;

            decimal netoInternoTotal = _liquidacionResponse.MontosPago.NetoInterno;
            decimal netoInternoFaltante = netoInternoTotal - _liquidacionResponse.MontosPago.PagadoInterno;

            _crearPagoForm.SetIdLiquidacion(_codigoLiquidacion ?? throw new NullReferenceException("liq.id"));
            _crearPagoForm.SetMonto(netoInternoFaltante);
            _crearPagoForm.MarcarComoInterno();
            _crearPagoForm.ShowDialog();
        }

        private async void BtnDescargarRecibo_Click(object sender, EventArgs e)
        {
            if (_codigoLiquidacion is null)
                return;

            if (_liquidacionResponse is null)
                return;

            try
            {
                var pdfBytes = await _liquidacionController.DescargarRecibo(_codigoLiquidacion);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Guardar Recibo";
                    saveFileDialog.FileName = $"recibo-{_liquidacionResponse.Empleado.Dni}.pdf"; // Nombre por defecto

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show("PDF descargado y guardado correctamente.",
                                            "Éxito", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        var psi = new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        };

                        Process.Start(psi);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre algún problema
                MessageBox.Show($"Error al descargar el recibo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

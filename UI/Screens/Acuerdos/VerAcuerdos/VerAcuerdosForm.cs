using BLL.Controllers;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using UI.Screens.CrearContrato;
using UI.Utils;

namespace UI.Screens.VerContratos
{
    public partial class VerAcuerdosForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _acuerdoController;
        private GetAcuerdoByIdResponse? _acuerdoVigenteEmp;
        private CrearAcuerdoForm _crearAcuerdoForm;
        public VerAcuerdosForm(EmpleadoController empleadoController,
                               IServiceProvider sp,
                               AcuerdoController acuerdoController,
                               CrearAcuerdoForm crearAcuerdoForm)
        {
            InitializeComponent();

            _empleadoController = empleadoController;

            listaEmpleados.ServiceProvider = sp;
            listaEmpleados.EventEmpleadoSeleccionado += ClickEnEmpleado;
            _acuerdoController = acuerdoController;
            _crearAcuerdoForm = crearAcuerdoForm;
        }

        private void ClickEnEmpleado(object? sender, GetEmpleadoResponse emp)
        {
            LimpiarDatosEmpleadoAnterior();
            CargarHistorialAcuerdos(emp);
        }

        private async Task SetDatosEmpleado(GetEmpleadoResponse emp)
        {
            DataLbDni.Text = emp.Dni;
            DataLbNombre.Text = $"{emp.Nombre}";
            DataLbApellido.Text = $"{emp.Apellido}";
            DataLbCuil.Text = emp.Cuil;

            var acuerdoActual = await _acuerdoController.GetAcuerdo(emp.AcuerdoId);

            _acuerdoVigenteEmp = acuerdoActual;

            SetDatosAcuerdo(acuerdoActual);
        }

        private async void CargarHistorialAcuerdos(GetEmpleadoResponse emp)
        {
            await SetDatosEmpleado(emp);

            var response = await _empleadoController.GetHistorialAcuerdosEmpleado(emp.Dni);


            foreach (var contrato in response.Historial)
            {
                ListViewItem item = new ListViewItem(contrato.Codigo);

                item.Tag = contrato;
                item.SubItems.Add(contrato.Sueldo.ToString("C"));
                item.SubItems.Add(contrato.ValorHora.ToString("C"));
                item.SubItems.Add(contrato.Fecha.ToString("dd/MM/yyyy | hh:mm"));
                this.listHistorial.Items.Add(item);
            }

            ListUtils.AjustarColumnas(this.listHistorial);
        }

        private async void Select_AcuerdoDeHistorial(object sender, EventArgs e)
        {
            listAdicionales.Items.Clear();

            var codAcuerdo = GetCodigoAcuerdoSeleccionado();

            if (codAcuerdo != string.Empty)
            {
                var acuerdo = await GetAcuerdoSeleccionado(codAcuerdo);
                SetDatosAcuerdo(acuerdo);
            }
        }

        private async Task<GetAcuerdoByIdResponse> GetAcuerdoSeleccionado(string codAcuerdo)
        {
            var acuerdo = await _acuerdoController.GetAcuerdo(codAcuerdo);
            return acuerdo;
        }
        private string GetCodigoAcuerdoSeleccionado()
        {
            if (listHistorial.SelectedItems.Count > 0)
            {
                var contrato = listHistorial.SelectedItems[0].Tag as GetAcuerdoEmpleado;
                if (contrato == null)
                    return "";

                return contrato.Codigo;
            }
            return string.Empty;
        }

        private void SetDatosAcuerdo(GetAcuerdoByIdResponse acu)
        {
            string textCodigo = "error";


            if (_acuerdoVigenteEmp is not null)
            {

                if (_acuerdoVigenteEmp.Codigo == acu.Codigo)
                {
                    textCodigo = $"{acu.Codigo} : VIGENTE";
                    DataLbCodAcuerdo.BackColor = Color.ForestGreen;

                }
                else
                {
                    textCodigo = $"{acu.Codigo} : SIN VIGENCIA";
                    DataLbCodAcuerdo.BackColor = Color.Red;
                }

            }

            DataLbCodAcuerdo.Text = textCodigo;
            DataLbValorHora.Text = acu.ValorHora.ToString("C");
            DataLbSueldo.Text = acu.Sueldo.ToString("C");
            DataLbJornal.Text = acu.ValorBlanco.ToString("C");
            DataLbFechaCreacionAcuerdo.Text = acu.Fecha.ToString("dd/MM/yyyy");
            DataLbTipoSueldo.Text = acu.TipoSueldo.Descripcion;
            DataLbCodSueldo.Text = acu.TipoSueldo.Codigo;
            DataLbJornada.Text = $"{acu.Jornada.Descripcion}:{acu.Jornada.Horas} hs"
            ;

            CargarTablaAdicionales(acu.Adicionales);
            CargarTablaRetenciones(acu.Retenciones);
        }

        private void CargarTablaAdicionales(IEnumerable<AdicionalAcuerdoResponse> adi)
        {
            ListUtils.LimpiarElementos(this.listAdicionales);


            foreach (var adicional in adi)
            {
                ListViewItem item = new(adicional.Concepto);
                item.SubItems.Add(adicional.Monto.ToString("C"));
                //item.SubItems.Add(adicional.EsEnBlanco.ToString());
                //item.SubItems.Add(adicional.EsPorcentual.ToString());

                listAdicionales.Items.Add(item);
            }
        }

        private void CargarTablaRetenciones(IEnumerable<RetencionResponse> retenciones)
        {
            ListUtils.LimpiarElementos(this.listRetenciones);

            foreach (var ret in retenciones)
            {
                ListViewItem item = new(ret.Codigo);
                item.SubItems.Add(ret.Concepto);
                item.SubItems.Add(ret.Unidades.ToString("F2"));

                string textQuincena = "2da quincena";

                if (ret.EsPrimeraQuincena)
                {
                    textQuincena = "1ra quincena";
                }

                item.SubItems.Add(textQuincena);
                listRetenciones.Items.Add(item);
            }
        }

        private void LimpiarDatosEmpleadoAnterior()
        {
            ListUtils.LimpiarElementos(this.listAdicionales);
            ListUtils.LimpiarElementos(this.listHistorial);
            ListUtils.LimpiarElementos(this.listRetenciones);

            DataLbCodAcuerdo.Text = "";
            DataLbValorHora.Text = "";
            DataLbSueldo.Text = "";
            DataLbJornal.Text = "";
            DataLbFechaCreacionAcuerdo.Text = "";
            DataLbTipoSueldo.Text = "";
            DataLbCodSueldo.Text = "";
            DataLbJornada.Text = "";
        }

        private void crearAPartirDelActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarFormParaCrearNuevoAcuerdo();
        }

        private void CargarFormParaCrearNuevoAcuerdo()
        {

            _crearAcuerdoForm.CargarAcuerdo(DataLbDni.Text,
                                           $"{DataLbNombre.Text} {DataLbApellido.Text}",
                                           _acuerdoVigenteEmp ?? throw new ArgumentException("acuerdo.vacio"));

            _crearAcuerdoForm.ShowDialog();
        }

        private void crearConAumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

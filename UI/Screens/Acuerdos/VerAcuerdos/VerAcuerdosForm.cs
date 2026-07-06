using BLL.Controllers;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using UI.Utils;

namespace UI.Screens.VerContratos
{
    public partial class VerAcuerdosForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _acuerdoController;
        private GetAcuerdoByIdResponse? _acuerdoVigenteEmp;
        public VerAcuerdosForm(EmpleadoController empleadoController, IServiceProvider sp, AcuerdoController acuerdoController)
        {
            InitializeComponent();

            _empleadoController = empleadoController;

            listaEmpleados.ServiceProvider = sp;
            listaEmpleados.EventEmpleadoSeleccionado += ClickEnEmpleado;
            _acuerdoController = acuerdoController;
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

        private void SetDatosAcuerdo(GetAcuerdoByIdResponse acuerdo)
        {
            string textCodigo = "error";


            if (_acuerdoVigenteEmp is not null)
            {

                if(_acuerdoVigenteEmp.Codigo == acuerdo.Codigo)
                {
                    textCodigo = $"{acuerdo.Codigo} : VIGENTE";
                    DataLbCodAcuerdo.BackColor = Color.ForestGreen;

                }
                else
                {
                    textCodigo = $"{acuerdo.Codigo} : SIN VIGENCIA";
                    DataLbCodAcuerdo.BackColor = Color.Red;
                }

            }

            DataLbCodAcuerdo.Text = textCodigo;
            DataLbValorHora.Text = acuerdo.ValorHora.ToString("C");
            DataLbSueldo.Text = acuerdo.Sueldo.ToString("C");
            DataLbJornal.Text = acuerdo.ValorBlanco.ToString("C");
            DataLbFechaCreacionAcuerdo.Text = acuerdo.Fecha.ToString("dd/MM/yyyy");
            DataLbTipoSueldo.Text = acuerdo.TipoSueldo.Descripcion;
            DataLbCodSueldo.Text = acuerdo.TipoSueldo.Codigo;
            DataLbNotas.Text = acuerdo.Notas;

            CargarTablaAdicionales(acuerdo.Adicionales);
            CargarTablaRetenciones(acuerdo.Retenciones);
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

                if(ret.EsPrimeraQuincena)
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
            DataLbNotas.Text = "";
        }
    }
}

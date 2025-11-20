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
            LimpiarHistorialAnterior();
            CargarHistorialContratos(emp);
        }

        private void SetDatosEmpleado(GetEmpleadoResponse emp)
        {
            textBoxDni.Text = emp.Dni;
            textBoxNombre.Text = $"{emp.Nombre} {emp.Apellido}";
        }

        private async void CargarHistorialContratos(GetEmpleadoResponse emp)
        {
            SetDatosEmpleado(emp);

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
            textBoxCodAcuerdo.Text = acuerdo.Codigo;
            textBoxValorHora.Text = acuerdo.ValorHora.ToString("C");
            textBoxValorSueldo.Text = acuerdo.Sueldo.ToString("C");
            textBoxValorBlanco.Text = acuerdo.ValorBlanco.ToString("C");
            textBoxFechaAcuerdo.Text = acuerdo.Fecha.ToString("dd/MM/yyyy");
            textBoxTipoSueldo.Text = acuerdo.TipoSueldo.Descripcion;

            SetTablaAdicionales(acuerdo.Adicionales);
        }

        private void SetTablaAdicionales(IEnumerable<AdicionalAcuerdoResponse> adi)
        {
            foreach (var adicional in adi)
            {
                ListViewItem item = new(adicional.Concepto);
                item.SubItems.Add(adicional.Monto.ToString("C"));
                item.SubItems.Add(adicional.EsEnBlanco.ToString());
                item.SubItems.Add(adicional.EsPorcentual.ToString());

                listAdicionales.Items.Add(item);
            }
        }

        private void LimpiarHistorialAnterior()
        {
            ListUtils.LimpiarElementos(this.listAdicionales);
            ListUtils.LimpiarElementos(this.listHistorial);

            textBoxCodAcuerdo.Text = string.Empty;
            textBoxValorHora.Text = string.Empty;
            textBoxValorSueldo.Text = string.Empty;
            textBoxValorBlanco.Text = string.Empty;
            textBoxFechaAcuerdo.Text = string.Empty;
            textBoxTipoSueldo.Text = string.Empty;
        }
    }
}

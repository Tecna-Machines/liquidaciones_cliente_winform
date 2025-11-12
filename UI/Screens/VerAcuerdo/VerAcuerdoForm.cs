using BLL.Controllers;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using UI.Utils;

namespace UI.Screens.VerContratos
{
    public partial class VerAcuerdoForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _acuerdoController;
        public VerAcuerdoForm(EmpleadoController empleadoController, IServiceProvider sp, AcuerdoController acuerdoController)
        {
            InitializeComponent();

            _empleadoController = empleadoController;

            listaEmpleados.ServiceProvider = sp;
            listaEmpleados.EventEmpleadoSeleccionado += ClickEnEmpleado;
            _acuerdoController = acuerdoController;
        }

        private void ClickEnEmpleado(object? sender, GetEmpleadoResponse emp)
        {
            CargarHistorialContratos(emp);
        }

        private void SetDatosEmpleado(GetEmpleadoResponse emp)
        {
            textBoxDni.Text = emp.Dni;
            textBoxNombre.Text = $"{emp.Nombre} {emp.Apellido}";
        }

        private async void CargarHistorialContratos(GetEmpleadoResponse emp)
        {
            LimpiarHistorialAnterior();
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

             var acuerdo = await GetAcuerdoSeleccionado();
            SetDatosAcuerdo(acuerdo);
        }

        private async Task<GetAcuerdoByIdResponse> GetAcuerdoSeleccionado()
        {
            var codAcuerdo = GetCodigoAcuerdoSeleccionado();
            var acuerdo = await _acuerdoController.GetAcuerdo(codAcuerdo);
            return acuerdo;
        }
        private string GetCodigoAcuerdoSeleccionado()
        {
            if (listHistorial.SelectedItems.Count == 0)
                return "";

            var contrato = listHistorial.SelectedItems[0].Tag as GetAcuerdoEmpleado;
            if (contrato == null)
                return "";

            return contrato.Codigo;
        }

        private void SetDatosAcuerdo(GetAcuerdoByIdResponse acuerdo)
        {
            textBoxCodAcuerdo.Text = acuerdo.Codigo;
        }

        private void LimpiarHistorialAnterior()
        {
            ListUtils.LimpiarElementos(this.listHistorial);
        }
    }
}

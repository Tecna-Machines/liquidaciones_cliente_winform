using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using UI.Utils;

namespace UI.Screens.VerCreditos
{
    public partial class CrearCreditosForm : Form
    {
        private readonly IServiceProvider _sp;

        public CrearCreditosForm(IServiceProvider sp)
        {
            InitializeComponent();

            _sp = sp;

            listaEmpleados.ServiceProvider = _sp;
            listaEmpleados.EventEmpleadoSeleccionado += CargarDniYNombre;

            this.Shown += CrearCreditosForm_Shown;

        }

        private void CargarDniYNombre(object? sender, GetEmpleadoResponse emp)
        {
            textBoxDni.Text = $"{emp.Dni}";
            textBoxNombreCompleto.Text = $"{emp.Nombre} {emp.Apellido}";
        }
        private async void CrearCreditosForm_Shown(object? sender, EventArgs e)
        {
            await listaEmpleados.ForzarCargarLista();
        }

        private void BtnCrearCredito_Click(object sender, EventArgs e)
        {
            Dialog.Error("esta funcionalidad aun no esta disponible");
        }

        private void ComboBoxCantCuotas_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoCuota();
        }


        private void TextMontoDevolver_TextChanged(object sender, EventArgs e)
        {
            ActualizarMontoCuota();
        }
        private void ActualizarMontoCuota()
        {
            decimal montoPrestado = int.Parse(TextMontoDevolver.Text);

            var itemSeleccionado = comboBoxCantCuotas.SelectedItem;

            int cantCuotas = 1;

            if(itemSeleccionado is not null)
                cantCuotas = int.Parse(comboBoxCantCuotas.SelectedItem.ToString() ?? "1");


            string valorCuota = (montoPrestado / cantCuotas).ToString("F2");

            TextValorCuota.Text = valorCuota;
        }
    }
}

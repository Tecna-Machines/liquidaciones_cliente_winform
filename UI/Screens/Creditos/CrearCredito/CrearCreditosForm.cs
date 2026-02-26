using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using UI.Screens.Creditos.VerCredito;
using UI.Utils;

namespace UI.Screens.VerCreditos
{
    public partial class CrearCreditosForm : Form
    {
        private readonly IServiceProvider _sp;
        private readonly CreditoController _controller;
        private VerCreditoForm _verCreditoForm;

        public CrearCreditosForm(IServiceProvider sp, CreditoController controller, VerCreditoForm verCreditoForm)
        {
            InitializeComponent();

            _sp = sp;

            listaEmpleados.ServiceProvider = _sp;
            listaEmpleados.EventEmpleadoSeleccionado += CargarDniYNombre;

            this.Shown += CrearCreditosForm_Shown;
            _controller = controller;
            _verCreditoForm = verCreditoForm;
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

            if (itemSeleccionado is not null)
                cantCuotas = int.Parse(comboBoxCantCuotas.SelectedItem.ToString() ?? "1");


            string valorCuota = (montoPrestado / cantCuotas).ToString("F2");

            TextValorCuota.Text = valorCuota;
        }

        private void BtnConfirmarCredito_Click(object sender, EventArgs e)
        {
            CrearCredito();
        }

        private async void CrearCredito()
        {
            if (!TryCrearSolicitudCredito(out var request, out var error))
            {
                MessageBox.Show(error, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevoCredito = await _controller.Crear(request);

            MostrarCredito(nuevoCredito.Codigo);
        }


        private int RecuperarModoPago()
        {
            if (modoPorQuincena.Checked) return 0;
            if (modoPrimerQuincena.Checked) return 1;
            if (modoSegundaQuincena.Checked) return 2;

            throw new ArgumentOutOfRangeException("modo.desconocido");
        }


        private bool TryCrearSolicitudCredito(out CrearCreditoRequest request, out string error)
        {
            request = default!;
            error = "";

            var dni = textBoxDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                error = "El DNI es obligatorio.";
                return false;
            }

            if (!decimal.TryParse(TextMontoPrestado.Text, out var montoPrestado))
            {
                error = "Monto prestado invalido.";
                return false;
            }

            if (!decimal.TryParse(TextMontoDevolver.Text, out var montoDevolver))
            {
                error = "Monto a devolver invalido.";
                return false;
            }

            if (!int.TryParse(comboBoxCantCuotas.Text, out var cantCuotas))
            {
                error = "Cantidad de cuotas invalida.";
                return false;
            }


            if (!TryRecuperarQuincenaGracia(out var quincenaGracia, out error))
                return false;

            request = new CrearCreditoRequest(
                dni,
                montoPrestado,
                montoDevolver,
                TextDescripcion.Text,
                cantCuotas,
                RecuperarModoPago(),
                quincenaGracia);

            return true;
        }

        private bool TryRecuperarQuincenaGracia(out CreditoQuincenaRequest quincena, out string error)
        {
            quincena = default!;
            error = "";

            if (!int.TryParse(ComboQuincena.Text, out var q))
            {
                error = "Quincena inválida.";
                return false;
            }
            if (!int.TryParse(ComboMes.Text, out var m))
            {
                error = "Mes inválido.";
                return false;
            }
            if (!int.TryParse(ComboAnio.Text, out var a))
            {
                error = "Año inválido.";
                return false;
            }

            quincena = new CreditoQuincenaRequest(q, m, a);
            return true;
        }

        private async void MostrarCredito(string codigo)
        {
            var credito = await _controller.GetCredito(codigo);

            _verCreditoForm.SetCredito(credito);
            _verCreditoForm.Show();
        }
    }
}

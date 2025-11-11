using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using UI.Utils;

namespace UI.Screens.CrearEmpleado
{
    public partial class CrearEmpleadoForm : Form
    {
        private readonly IEmpleadoService _empleados;
        public CrearEmpleadoForm(IEmpleadoService empleados)
        {
            InitializeComponent();
            _empleados = empleados;
        }

        private async void BtnConfirmarCrear_Click(object sender, EventArgs e)
        {

            try
            {
                await GuardarEmpleado(CrearSolicitudEmpleado());
            }
            catch (Exception ex)
            {
                Dialog.Error(ex.Message);
            }

        }

        private CrearEmpleadoRequest CrearSolicitudEmpleado()
        {
            string dni = textBoxDni.Text;
            string nombres = textBoxNombres.Text;
            string apellidos = textBoxApellidos.Text;

            DateTime ingreso = fechaIngreso.Value;
            DateTime alta = fechaAlta.Value;
            DateTime nacimiento = fechaNacimiento.Value;

            return new CrearEmpleadoRequest(dni, nombres, apellidos, ingreso, nacimiento, alta);
        }

        private async Task GuardarEmpleado(CrearEmpleadoRequest req)
        {
            var response = await _empleados.Crear(req);

            Dialog.Success($"{response.Nombre} {response.Apellido} : carga exitosa!");

            this.Close();
        }
    }
}

using BLL.Controllers;
using UI.Utils;

namespace UI.Screens.Asistencias.Marcas
{
    public partial class AgregarMarcaForm : Form
    {
        private readonly EmpleadoController _empController;
        public AgregarMarcaForm(EmpleadoController empController)
        {
            InitializeComponent();
            _empController = empController;

        }

        public void SetDni(string dni)
        {
            textBoxDni.Text = dni;
        }

        private async void BtnCrearMarca_Click(object sender, EventArgs e)
        {

            string dni = textBoxDni.Text;
            DateTime dia = dateTimeFecha.Value.Date;
            DateTime ingreso = datePickerIngreso.Value;
            DateTime egreso = datePickerEgreso.Value;

            // Combinar fecha + hora
            DateTime fechaIngreso = dia.Date + ingreso.TimeOfDay;
            DateTime fechaEgreso = dia.Date + egreso.TimeOfDay;


            try
            {
                var asistencia = await _empController.CrearAsistencia(dni, fechaIngreso, fechaEgreso);

                Dialog.Success($"se creo la asistencia para el: {asistencia.Entrada}");
            }
            catch (Exception ex)
            {
                Dialog.Error($"ocurrio un problema: {ex.Message}");
            }

        }
    }
}

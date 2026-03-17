using BLL.Controllers;
using UI.Utils;

namespace UI.Screens.Feriados.CrearFeriado
{
    public partial class CrearFeriadoForm : Form
    {
        private readonly FeriadoController _feriadoController;
        public CrearFeriadoForm(FeriadoController feriadoController)
        {
            InitializeComponent();
            _feriadoController = feriadoController;
        }

        private async void BtnCargarFeriado_Click(object sender, EventArgs e)
        {
            DateTime fecha = fechaFeriado.Value;
            string descripcion = descripcionFeriado.Text;
            bool esPermantente = checkBoxSeRepite.Checked;

            try
            {
                var feriado = await _feriadoController.CrearUnFeriado(fecha, descripcion, esPermantente);
                Dialog.Success("se creo el feriado: " + feriado.Descripcion);
                this.Close();

            }
            catch (Exception ex)
            {
                Dialog.Error("algo se rompio: " + ex.Message);
            }
        }
    }
}

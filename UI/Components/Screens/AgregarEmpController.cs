using BLL.Controllers;
using BLL.Models;
using LAUCHA.application.DTOs.RetencionesFijasDTOs;
using UI.Utils;

namespace UI.Components.Screens
{
    public partial class AgregarEmpController : UserControl
    {
        private readonly EmpleadoController _controller;
        public AgregarEmpController()
        {
            InitializeComponent();

            _controller = new EmpleadoController();
        }

        private async void btnCrearEmp_Click(object sender, EventArgs e)
        {
            var context = LiquidacionContext.GetInstance();

            string dni;
            string nombres;
            string apellidos;
            DateTime fechaIngreso;
            DateTime fechaNacimiento;

            dni = this.textBoxDni.Text;
            nombres = this.textBoxNombre.Text;
            apellidos = this.textBoxApellido.Text;
            fechaIngreso = this.fechaIngreso.Value;
            fechaNacimiento = this.fechaNacimiento.Value;

            try
            {
                var retencionesFijas = await _controller.ObtenerRetencionesFijasParaEmpleados();
                var result = await _controller.CrearNuevoEmpleado(dni: dni,
                                           nombre: nombres,
                                           apellido: apellidos,
                                           fechaNac: fechaNacimiento,
                                           fechaIng: fechaIngreso);


                this.SetListaRetencionesFijas(retencionesFijas);
                context.SetEmpleado(result);
            }
            catch (Exception)
            {
                MessageUtils.ErrorMessage("ocurrio un problema");
                return;
            }

            var empleado = context.ObtenerDatosEmpleado();
            this.textBoxNumeroCuenta.Text = empleado.NumeroCuenta;

            MessageUtils.SuccessMessage($"{empleado.Nombre} se creo exitosamente (NO OLVIDES CONFIGURAR SU CUENTA)");
        }

        private void SetListaRetencionesFijas(List<RetencionFijaDTO> retencionesFijas)
        {
            var listCheckBox = this.checkedListRetenciones;

            foreach (var retencion in retencionesFijas)
            {
                var item = new RetencionItem(retencion.Codigo, retencion.Concepto);

                listCheckBox.Items.Add(item, true);
            }
        }

        private async void btnConfigCuenta_Click(object sender, EventArgs e)
        {
            var itemsCheck = this.checkedListRetenciones.CheckedItems;

            List<string> codigos = new();

            foreach (RetencionItem item in itemsCheck)
            {
                codigos.Add(item.Codigo);
            }

            try
            {
                var numCuenta = LiquidacionContext.GetInstance().ObtenerDatosEmpleado().NumeroCuenta;
                 await _controller.ConfigurarRetencionesDeEmpleado(codigos,numCuenta);

            }catch(Exception)
            {
                MessageUtils.ErrorMessage("ocurrio un problema al setear las retenciones fijas");
                return;
            }

            MessageUtils.SuccessMessage("se configuro exitosamente las retenciones!");
        }
    }



    //clase usada unicamente para la representacion en la lista , no debe usarse para nada mas

    internal class RetencionItem
    {
        public RetencionItem(string codigo, string concepto)
        {
            Codigo = codigo;
            Concepto = concepto;
        }

        public string Codigo { get; set; }
        public string Concepto { get; set; }

        public override string ToString()
        {
            return $"{Concepto} (Código: {Codigo})";
        }
    }
}

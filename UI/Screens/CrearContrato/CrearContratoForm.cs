using BLL.Controllers;
using BLL.Models;
using DAL.Service.Liquidacion.UseCase.Contrato;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.ModalidadDTOs;
using UI.Utils;

namespace UI.Screens.CrearContrato
{
    public partial class CrearContratoForm : Form
    {
        private readonly CrearLiquidacionController _controller;
        private readonly ContratoController _contratoController;
        public CrearContratoForm()
        {
            InitializeComponent();

            _controller = new();
            _contratoController = new();

            this.listaEmpComponent1.EventEmpleadoSeleccionado += ClickEnEmpleado; //se suscribe al evento de la lista

            Inicializar();
        }

        private void ClickEnEmpleado(object? sender, EmpleadoDTO e)
        {
            this.textBoxDni.ForeColor = Color.Red;
            this.textBoxNombre.ForeColor = Color.Red;

            this.textBoxDni.Text = e.Dni;
            this.textBoxNombre.Text = $"{e.Nombre} {e.Apellido}";

            LiquidacionContext.GetInstance().SetEmpleado(e);
        }

        private async void Inicializar()
        {
            var empleados = await _controller.ObtenerTodosLosEmpleado();
            var modalidades = await _contratoController.ObtenerModalidades();

            this.listaEmpComponent1.CargarLista(empleados);
            this.CargarOpcionesModalidad(modalidades);
        }

        private void TextBoxMontoFijo_TextChanged(object sender, EventArgs e)
        {
            string sueldoFijoStr = this.textBoxSueldo.Text;
            string sueldoBancoStr = this.textBoxMontoBanco.Text;

            decimal montoFijo, montoBanco;

            decimal.TryParse(sueldoFijoStr, out montoFijo);
            decimal.TryParse(sueldoBancoStr, out montoBanco);


            if (montoBanco > montoFijo)
            {
                MessageUtils.ErrorMessage("el monto en el banco no puede ser mayor al monto fijo");

                this.textBoxSueldo.Clear();
                this.textBoxMontoBanco.Clear();
                this.textBoxValorHora.Clear();
            }
        }

        private void CargarOpcionesModalidad(List<ModalidadDTO> modalidades)
        {
            var menuOpciones = this.comboBoxModalidad;
            menuOpciones.Items.Clear();

            foreach (var modalidad in modalidades)
            {
                var modItem = new ModalidadItem(modalidad.Codigo, modalidad.Descripcion);
                menuOpciones.Items.Add(modItem);
            }

            menuOpciones.SelectedIndex = 0;
        }

        private void BtnConfirmarContrato_Click(object sender, EventArgs e)
        {

            var contratoContext = ContratoContext.GetInstance();
            var emp = LiquidacionContext.GetInstance().ObtenerDatosEmpleado();
            string dniEmp = emp.Dni;

            string sueldoStr = this.textBoxSueldo.Text;
            string valorBlancoStr = this.textBoxMontoBanco.Text;
            string valorHoraStr = this.textBoxValorHora.Text;

            decimal sueldo, valorBlanco, valorHora;

            decimal.TryParse(valorHoraStr, out valorHora);
            decimal.TryParse(sueldoStr, out sueldo);
            decimal.TryParse(valorBlancoStr, out valorBlanco);

            ModalidadItem modalidad = (ModalidadItem)this.comboBoxModalidad.SelectedItem;
            CrearAcuerdoRequest contratoReq;

            try
            {
                contratoReq = new(Dni: dniEmp,
                                  Sueldo:sueldo,
                                  ValorBlanco: valorBlanco,
                                  ValorHora: valorHora,
                                  TipoSueldo: 999,
                                  Notas: "blabla",
                                  Adicionales: new List<AdicionalesRequest>());
            }
            catch (Exception)
            {
                MessageUtils.ErrorMessage("ocurrio un problema, revisa bien los datos del contrato");
                return;
            }


            MessageBox.Show("pipip");

        }
    }

    //solo debe usarse para representar a la modalidad aqui
    internal class ModalidadItem
    {
        public ModalidadItem(string codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Descripcion}";
        }

    }
}

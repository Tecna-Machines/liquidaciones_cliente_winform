using BLL.Controllers;
using BLL.Models;
using DAL.Service.Liquidacion.UseCase.Contrato.Crear;
using LAUCHA.application.DTOs.ModalidadDTOs;
using UI.Utils;

namespace UI.Screens.CrearContrato
{
    public partial class CrearAcuerdoForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _contratoController;
        public CrearAcuerdoForm(AcuerdoController contratoController, CrearLiquidacionController controller, EmpleadoController empleadoController)
        {
            _contratoController = contratoController; ;
            InitializeComponent();

            this.listaEmpComponent1.EventEmpleadoSeleccionado += ClickEnEmpleado; //se suscribe al evento de la lista
            _empleadoController = empleadoController;
            CargarListaEmpleados();
        }

        private void ClickEnEmpleado(object? sender, DAL.Service.Liquidacion.Features.Empleados.GetEmpleados.GetEmpleadoResponse e)
        {
            this.textBoxDni.ForeColor = Color.Red;
            this.textBoxNombre.ForeColor = Color.Red;
            this.textBoxDni.Text = e.Dni;
            this.textBoxNombre.Text = $"{e.Nombre} {e.Apellido}";

            LiquidacionContext.GetInstance().SetEmpleado(e);
        }

        private async void CargarListaEmpleados()
        {
            var empleados = await _empleadoController.ObtenerEmpleados();
            var modalidades = _contratoController.ObtenerModalidades();

            this.listaEmpComponent1.CargarLista(empleados);
            this.CargarOpcionesModalidad(modalidades);
        }

        private void TextBoxMontoFijo_TextChanged(object sender, EventArgs e)
        {
            string sueldoFijoStr = this.textBoxSueldo.Text;
            string sueldoBancoStr = this.textBoxMontoBanco.Text;

            decimal sueldo, valorBlanco;

            decimal.TryParse(sueldoFijoStr, out sueldo);
            decimal.TryParse(sueldoBancoStr, out valorBlanco);
            decimal montoAdicionales = RecuperarAdicionalesDesdeLista()
                                       .Where(a => !a.EsPorcentual)
                                       .Sum(a => a.Monto);


            textBoxValorHora.Text = ((sueldo + montoAdicionales) / 200).ToString();


            if (valorBlanco > sueldo)
            {
                Dialog.Error("el monto en el banco no puede ser mayor al monto fijo");

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

        private async void BtnConfirmarContrato_Click(object sender, EventArgs e)
        {
            var acuerdo = CrearAcuerdo();

            try
            {
                await GuardarAcuerdo(acuerdo);

                this.Close();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"ocurrio un problema: {exp.Message}");
                return;
            }
        }


        private CrearAcuerdoRequest CrearAcuerdo()
        {
            string dniEmp = this.textBoxDni.Text;

            string sueldoStr = this.textBoxSueldo.Text;
            string valorBlancoStr = this.textBoxMontoBanco.Text;
            string valorHoraStr = this.textBoxValorHora.Text;

            decimal sueldo, valorBlanco, valorHora;

            decimal.TryParse(valorHoraStr, out valorHora);
            decimal.TryParse(sueldoStr, out sueldo);
            decimal.TryParse(valorBlancoStr, out valorBlanco);

            ModalidadItem modalidad = (ModalidadItem)this.comboBoxModalidad.SelectedItem;

            int tipoSueldo;
            int.TryParse(modalidad.Codigo, out tipoSueldo);

            CrearAcuerdoRequest contratoReq;

            contratoReq = new(Dni: dniEmp,
                              Sueldo: sueldo,
                              ValorBlanco: valorBlanco,
                              ValorHora: valorHora,
                              TipoSueldo: tipoSueldo,
                              Notas: "blabla",
                              Adicionales: RecuperarAdicionalesDesdeLista());

            return contratoReq;
        }

        private List<AdicionalesRequest> RecuperarAdicionalesDesdeLista()
        {
            return this.listAdicionales.Items
                    .Cast<ListViewItem>()
                    .Select(item => (AdicionalesRequest)item.Tag)
                    .ToList();
        }

        private async Task GuardarAcuerdo(CrearAcuerdoRequest acuerdo)
        {
            string codigo = await _contratoController.CargarAcuerdo(acuerdo);

            Dialog.Success($"se creo el acuerdo: {codigo}");
        }

        private void BtnAgregarAdicional_Click(object sender, EventArgs e)
        {
            var formAcuerdo = new CrearAdicionalForm(this).ShowDialog();
        }

        public void AgregarAdicional(AdicionalesRequest adicional)
        {
            ListViewItem item = new(adicional.Concepto);
            item.SubItems.Add(adicional.Monto.ToString("C"));
            item.SubItems.Add(adicional.EsEnBlanco.ToString());
            item.SubItems.Add(adicional.EsPorcentual.ToString());

            item.Tag = adicional;

            listAdicionales.Items.Add(item);
            TextBoxMontoFijo_TextChanged(this, EventArgs.Empty);
        }

        private void EliminarAdicional_DobleClick(object sender, MouseEventArgs e)
        {
            if (listAdicionales.SelectedItems.Count > 0)
            {
                var item = listAdicionales.SelectedItems[0];
                var adicional = (AdicionalesRequest)item.Tag;

                var confirmar = MessageBox.Show(
                    $"¿Deseas eliminar '{adicional.Concepto}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmar == DialogResult.Yes)
                {
                    listAdicionales.Items.Remove(item);
                }
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
}

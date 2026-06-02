using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo;
using DAL.Service.Liquidacion.Features.Contrato.Crear;
using LAUCHA.application.DTOs.ModalidadDTOs;
using UI.Utils;

namespace UI.Screens.CrearContrato
{
    public partial class CrearAcuerdoForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _contratoController;
        private readonly RetencionController _retencionController;
        public CrearAcuerdoForm(AcuerdoController contratoController,
                                EmpleadoController empleadoController,
                                RetencionController retencionController)
        {
            _contratoController = contratoController; ;
            InitializeComponent();

            this.listaEmpComponent1.EventEmpleadoSeleccionado += ClickEnEmpleado; //se suscribe al evento de la lista
            _empleadoController = empleadoController;
            _retencionController = retencionController;

            CargarListaEmpleados();
            CargarCatalogoRetenciones();

        }

        private void ClickEnEmpleado(object? sender, DAL.Service.Liquidacion.Features.Empleados.GetEmpleados.GetEmpleadoResponse e)
        {
            this.textBoxDni.ForeColor = Color.Red;
            this.textBoxNombre.ForeColor = Color.Red;
            this.textBoxDni.Text = e.Dni;
            this.textBoxNombre.Text = $"{e.Nombre} {e.Apellido}";

        }

        private async void CargarListaEmpleados()
        {
            var empleados = await _empleadoController.ObtenerEmpleados();
            var modalidades = _contratoController.ObtenerTiposDeSueldo();

            this.listaEmpComponent1.CargarLista(empleados);
            this.CargarOpcionesModalidad(modalidades);
        }

        private void TextBoxMontoFijo_TextChanged(object sender, EventArgs e)
        {
            string sueldoFijoStr = this.textBoxSueldo.Text;
            string sueldoBancoStr = this.textBoxMontoSueldoJornal.Text;

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
                this.textBoxMontoSueldoJornal.Clear();
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
            string valorBlancoStr = this.textBoxMontoSueldoJornal.Text;
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
                              Retenciones: RecuperarRetencionesSeleccionadas(),
                              Adicionales: RecuperarAdicionalesDesdeLista());

            return contratoReq;
        }

        private string[] RecuperarRetencionesSeleccionadas()
        {
            var codigos = new List<string>();

            foreach (ListViewItem item in listRetenciones.Items)
            {
                if (item.Checked)
                {
                    string codigo = item.SubItems[1].Text;
                    codigos.Add(codigo);
                }
            }

            return codigos.ToArray();
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
            var formAcuerdo = new CrearAdicionalForm(this);
           
           formAcuerdo.SetModoExtraplus();                
           formAcuerdo.ShowDialog();
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

        private async void CargarCatalogoRetenciones()
        {
            var catalogo = await _retencionController.GetCatalogo();

            foreach (var r in catalogo.Items)
            {
                ListViewItem item = new();
                item.SubItems.Add(r.Codigo);
                item.SubItems.Add(r.Concepto);
                item.SubItems.Add(GetRetencionValor(r));
                item.SubItems.Add(r.EsPrimeraQuincena ? "1ra" : "2da");

                item.Tag = r;


                listRetenciones.Items.Add(item);
            }
        }

        private string GetRetencionValor(RetencionResponse r)
        {
            if (r.EsPorcentual)
                return $"{r.Unidades:F2} %";


            return r.Unidades.ToString("C2");
        }

        //solo debe usarse para representar a la modalidad aqui
        private class ModalidadItem
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
                return $"{Codigo}:{Descripcion}";
            }

        }
    }
}

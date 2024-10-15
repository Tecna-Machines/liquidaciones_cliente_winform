using BLL.Controllers;
using BLL.Models;
using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.ModalidadDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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

        private void textBoxMontoFijo_TextChanged(object sender, EventArgs e)
        {
            string sueldoFijoStr = this.textBoxMontoFijo.Text;
            string sueldoBancoStr = this.textBoxMontoBanco.Text;

            decimal montoFijo, montoBanco;

            decimal.TryParse(sueldoFijoStr, out montoFijo);
            decimal.TryParse(sueldoBancoStr, out montoBanco);

            this.ActualizarGrafico(montoFijo, montoBanco);

            if (montoBanco > montoFijo)
            {
                MessageUtils.ErrorMessage("el monto en el banco no puede ser mayor al monto fijo");

                this.textBoxMontoFijo.Clear();
                this.textBoxMontoBanco.Clear();
                this.textBoxMontoHora.Clear();
            }
        }

        private void ActualizarGrafico(decimal sueldoFijo, decimal montoBanco)
        {
            this.chart.Series.Clear();

            var series = new Series("Sueldos")
            {
                ChartType = SeriesChartType.Pie
            };

            series.Points.AddXY("monto en negro", sueldoFijo - montoBanco);
            series.Points.AddXY("monto en banco", montoBanco);

            foreach (var point in series.Points)
            {
                point.LabelForeColor = Color.White;
            }

            chart.Series.Add(series);

            if (chart.Titles.Count == 0)
            {
                chart.Titles.Add("Distribución del Sueldo");
            }

            chart.Invalidate();
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

        private void btnConfirmarContrato_Click(object sender, EventArgs e)
        {
          
            var contratoContext = ContratoContext.GetInstance();
            var  emp = LiquidacionContext.GetInstance().ObtenerDatosEmpleado();
            string dniEmp = emp.Dni;

            string sueldoFijoStr = this.textBoxMontoFijo.Text;
            string sueldoBancoStr = this.textBoxMontoBanco.Text;
            string sueldoHoraStr = this.textBoxMontoHora.Text;

            decimal montoFijo, montoBanco,montoHora;

            decimal.TryParse(sueldoHoraStr,out montoHora);
            decimal.TryParse(sueldoFijoStr, out montoFijo);
            decimal.TryParse(sueldoBancoStr, out montoBanco);

            ModalidadItem modalidad = (ModalidadItem)this.comboBoxModalidad.SelectedItem;
            CrearContratoDTO contratoReq;

            try
            {
                contratoReq = contratoContext.CrearContrato(dni: dniEmp,
                                          modaliad: modalidad.Codigo,
                                          montoHora: montoHora,
                                          montoFijo: montoFijo,
                                          montoBlanco: montoBanco);
            }catch(Exception)
            {
                MessageUtils.ErrorMessage("ocurrio un problema, revisa bien los datos del contrato");
                return;
            }


            var formConfirmar = new ConfirmarContratoForm(contratoReq,emp,modalidad.Descripcion);
            formConfirmar.ShowDialog();

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

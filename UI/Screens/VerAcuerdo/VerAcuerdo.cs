using BLL.Controllers;
using BLL.Models;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Utils;

namespace UI.Screens.VerContratos
{
    public partial class VerAcuerdoForm : Form
    {
        private readonly EmpleadoController _empleadoController;
        private readonly AcuerdoController _contratoController;
        public VerAcuerdoForm(EmpleadoController empleadoController)
        {
            InitializeComponent();

            _empleadoController = empleadoController;
            this._contratoController = null;
            this.listaEmpComponent1.ForzarCargarLista();
            this.listaEmpComponent1.EventEmpleadoSeleccionado += ClickEnEmpleado;
        }

        private void ClickEnEmpleado(object? sender, GetEmpleadoResponse emp)
        {
            this.Clean();

            this.CargarDatosEmpleado(emp);
            this.CargarHistorialContratos(emp.Dni);
        }

        private void CargarDatosEmpleado(GetEmpleadoResponse empleado)
        {
            this.textBoxDni.Text = empleado.Dni;
            this.textBoxNombres.Text = empleado.Nombre;
            this.textBoxApellidos.Text = empleado.Apellido;

            //this.textBoxFechaCarga.Text = empleado.FechaCreacion.ToString("dd/MM/yyyy");
            //this.textBoxFechaNacimiento.Text = empleado.FechaNacimiento.ToString("dd/MM/yyyy");
            //this.textBoxFechaIngreso.Text = empleado.FechaIngreso.ToString("dd/MM/yyyy");
        }

        private async void CargarHistorialContratos(string dni)
        {
            var historial = await _empleadoController.ObtenerHistorialContratosEmpleado(dni);


            foreach (var contrato in historial)
            {
                ListViewItem item = new ListViewItem(contrato.Codigo);

                item.SubItems.Add(contrato.MontoFijo.ToString("C"));
                item.SubItems.Add(contrato.MontoHora.ToString("C"));
                item.SubItems.Add(contrato.Fecha);
                this.listHistorial.Items.Add(item);
            }

            ListUtils.AjustarColumnas(this.listHistorial);
        }

        private async void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listHistorial.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listHistorial.SelectedItems[0];

                string codigoContrato = selectedItem.Text;
                var contrato = await _contratoController.ConsultarAcuerdo(codigoContrato);

                ContratoContext.GetInstance().SetContrato(contrato);

                this.PintarInformacionContrato();
            }
        }

        private void PintarInformacionContrato()
        {
            var contratoActual = ContratoContext.GetInstance().GetContrato();

            this.textBoxCodigoContrato.Text = contratoActual.Codigo;
            this.textBoxModalidad.Text = contratoActual.Modalidad.Descripcion;
            this.textBoxFechaCreacionContrato.Text = contratoActual.Fecha;

            //montos
            this.textBoxMontoBrutoFijo.Text = contratoActual.MontoFijo.ToString("C");
            this.textBoxMontoValorHora.Text = contratoActual.MontoHora.ToString("C");


           if(!contratoActual.AcuerdoBlanco.EsPorcentual)
            {
                decimal montoEfectivo = contratoActual.MontoFijo - contratoActual.AcuerdoBlanco.Cantidad;

                this.textBoxMontoBrutoEfectiv.Text = montoEfectivo.ToString("C");
                this.textBoxMontoBrutoBanco.Text = contratoActual.AcuerdoBlanco.Cantidad.ToString("C");
            }
            else
            {
                this.textBoxMontoBrutoBanco.Text = $"{contratoActual.AcuerdoBlanco.Cantidad} %";

            }
        }

        private void Clean()
        {
            //limpia el historial 
            ListUtils.LimpiarElementos(this.listHistorial);

            //limpia los datos de empleados
            this.textBoxDni.Clear();
            this.textBoxNombres.Clear();
            this.textBoxApellidos.Clear();
            this.textBoxFechaCarga.Clear();
            this.textBoxFechaNacimiento.Clear();
            this.textBoxFechaIngreso.Clear();

            //limpia los detalles del contrato
            this.textBoxCodigoContrato.Clear();
            this.textBoxModalidad.Clear();
            this.textBoxFechaCreacionContrato.Clear();
            this.textBoxMontoBrutoFijo.Clear();
            this.textBoxMontoValorHora.Clear();
            this.textBoxMontoBrutoBanco.Clear();
        }
    }
}

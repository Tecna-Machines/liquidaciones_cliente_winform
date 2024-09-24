using BLL.Models;
using DAL.Service.Liquidacion.Modesl.MarcasDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Screens.Marcas
{
    public partial class MarcasForm : Form
    {
        public MarcasForm()
        {
            InitializeComponent();

            var listaMarcas = LiquidacionContext.GetInstance()?.ObtenerLiquidacion()?.Marcas;

            this.CargarTablaMarcas(listaMarcas);
        }


        private void CargarTablaMarcas(List<MarcaVista>? marcas)
        {
            var periodo = LiquidacionContext.GetInstance().GetPeriodo();
            DateTime fechaInicio = periodo.Inicio;
            DateTime fechaFin = periodo.Fin;

            listaMarcas.Items.Clear();

            // Iterar sobre cada día en el período
            for (DateTime dia = fechaInicio; dia <= fechaFin; dia = dia.AddDays(1))
            {
 
                MarcaVista? marcaDelDia = marcas?.FirstOrDefault(m => m.Ingreso.Date == dia.Date);

                // Si hay una marca
                if (marcaDelDia != null)
                {
                    var item = new ListViewItem(marcaDelDia.Ingreso.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(marcaDelDia.Ingreso.ToString("HH:mm"));
                    item.SubItems.Add(marcaDelDia.Egreso.ToString("HH:mm"));
                    item.SubItems.Add(marcaDelDia.HsTrabajadas.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.HsExtra.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.HsDoble.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.Ingreso.ToString("dddd"));

                    listaMarcas.Items.Add(item);
                }
                else
                {
                   
                    var item = new ListViewItem(dia.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(""); // Ingreso vacío
                    item.SubItems.Add(""); // Egreso vacío
                    item.SubItems.Add(""); // Horas trabajadas vacías
                    item.SubItems.Add(""); // Horas extra vacías
                    item.SubItems.Add(""); // Horas doble vacías
                    item.SubItems.Add(dia.ToString("dddd"));

                    listaMarcas.Items.Add(item);
                }
            }
        }

    }
}

using DAL.Service.Liquidacion.Modesl.MarcasDTOs;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using UI.Utils;

namespace UI.Screens.Marcas
{
    public partial class MarcasForm : Form
    {
        public MarcasForm()
        {
            InitializeComponent();

            var listaMarcas = new List<MarcaVista>().DefaultIfEmpty().ToList();

            this.CargarTablaMarcas(listaMarcas);
        }


        private void CargarTablaMarcas(List<MarcaVista>? marcas)
        {
            var periodo = new Quincena(); //TODO: cambiar la logica para ver marcas
            DateTime fechaInicio = periodo.Inicio;
            DateTime fechaFin = periodo.Fin;


            if (fechaFin.Day > 15)
            {
                fechaInicio = new DateTime(periodo.Inicio.Year, periodo.Inicio.Month, 1);
            }


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

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            Dialog.Error("esta funcionalidad aun no esta disponible");
        }
    }
}

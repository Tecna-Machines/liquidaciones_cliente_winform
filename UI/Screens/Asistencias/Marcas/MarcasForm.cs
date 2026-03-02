using DAL.Service.ApiLiquidacion.Features.Asistencias.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado;
using UI.Screens.Asistencias.Marcas;
using UI.Utils;

namespace UI.Screens.Marcas
{
    public partial class MarcasForm : Form
    {
        private readonly IAsistenciasService _asistencias;
        private readonly AgregarMarcaForm _crearMarcaForm;
        private string? _dni;
        public MarcasForm(IAsistenciasService asistencias, AgregarMarcaForm crearMarcaForm)
        {
            InitializeComponent();
            _asistencias = asistencias;
            _crearMarcaForm = crearMarcaForm;
        }

        public async Task GetAsistenciasYCargarTabla(MarcasRequest req)
        {
            int diaFin;
            _dni = req.DniEmpleado;

            diaFin = DateTime.DaysInMonth(req.Anio, req.Mes);


            DateTime fechaInicio = new DateTime(req.Anio, req.Mes, 1);
            DateTime fechaFin = new DateTime(req.Anio, req.Mes, diaFin);

            //TODO: esto es asincronico pero la funcion es void no tiene sentido hacerla Task o si ?
            var response = await _asistencias.GetAsistencia(req.DniEmpleado, fechaInicio, fechaFin);

            CargarTablaMarcas(fechaInicio, fechaFin, response.Asistencias.ToList());
        }

        private void CargarTablaMarcas(DateTime fechaInicio, DateTime fechaFin, List<GetEmpleadoAsistenciaResponse>? marcas)
        {

            if (fechaFin.Day > 15)
            {
                fechaInicio = new DateTime(fechaInicio.Year, fechaInicio.Month, 1);
            }


            tablaMarcas.Items.Clear();

            // Iterar sobre cada día en el período
            for (DateTime dia = fechaInicio; dia <= fechaFin; dia = dia.AddDays(1))
            {

                GetEmpleadoAsistenciaResponse? marcaDelDia = marcas?.FirstOrDefault(m => m.Ingreso.Date == dia.Date);

                bool esFinde = dia.DayOfWeek == DayOfWeek.Saturday || dia.DayOfWeek == DayOfWeek.Sunday;

                ListViewItem item;

                // Si hay una marca
                if (marcaDelDia != null)
                {
                    item = new ListViewItem(marcaDelDia.Ingreso.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(marcaDelDia.Ingreso.ToString("HH:mm"));
                    item.SubItems.Add(marcaDelDia.Egreso.ToString("HH:mm"));
                    item.SubItems.Add(marcaDelDia.HsComunes.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.HsExtra.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.HsTotales.ToString("F2"));
                    item.SubItems.Add(marcaDelDia.Ingreso.ToString("dddd"));

                }
                else
                {

                    item = new ListViewItem(dia.ToString("dd/MM/yyyy"));
                    item.SubItems.Add(esFinde ? "" : "FALTA"); // Ingreso vacío
                    item.SubItems.Add(""); // Egreso vacío
                    item.SubItems.Add(""); // Horas trabajadas vacías
                    item.SubItems.Add(""); // Horas extra vacías
                    item.SubItems.Add(""); // Horas doble vacías
                    item.SubItems.Add(dia.ToString("dddd"));
                    item.BackColor = Color.Red;

                }

                if (esFinde)
                {
                    item.BackColor = Color.Khaki;
                }


                item.UseItemStyleForSubItems = true;
                tablaMarcas.Items.Add(item);
            }
        }

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            _crearMarcaForm.SetDni(_dni ?? "error");
           _crearMarcaForm.ShowDialog();
        }
    }
}

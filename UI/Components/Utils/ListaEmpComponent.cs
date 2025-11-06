using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

namespace UI.Components.Utils
{
    public partial class ListaEmpComponent : UserControl
    {
        private string dniEmp;
        private List<GetEmpleadoResponse> _empleados;
        public event EventHandler<string>? EventDniSeleccionado;
        public event EventHandler<GetEmpleadoResponse> EventEmpleadoSeleccionado;
        private readonly IEmpleadoService _empleadoService;

        private List<ListViewItem> listaOriginal = new List<ListViewItem>();
        public ListaEmpComponent(IEmpleadoService service)
        {
            this.dniEmp = string.Empty;
            this._empleados = new();
            InitializeComponent();
            _empleadoService = service;
        }

        public ListaEmpComponent()
        {
            InitializeComponent();
            _empleadoService = Program.ServiceProvider.GetRequiredService<IEmpleadoService>();
            this.dniEmp = string.Empty;
            this._empleados = new();

        }


        public async void ForzarCargarLista()
        {

            var response = await _empleadoService.GetAll();
            this.CargarLista(response.Empleados);
        }
        public void CargarLista(List<GetEmpleadoResponse> lista)
        {
            this._empleados = lista;
            listEmp.Items.Clear();
            listaOriginal.Clear();


            lista.ForEach(emp =>
            {
                var item = new ListViewItem(emp.Nombre);
                item.SubItems.Add(emp.Apellido);
                item.SubItems.Add(emp.Dni);

                if (emp.AcuerdoId.Length <= 0)
                {
                    item.BackColor = Color.Red;
                }

                listEmp.Items.Add(item);
                listaOriginal.Add((ListViewItem)item.Clone());
            });

        }

        private void BuscarEmpUsandoNombre(object sender, EventArgs e)
        {
            string nombreBuscado = this.barraBusqueda.Text.ToLower();

            // Desactivar el redibujado para evitar parpadeos
            listEmp.BeginUpdate();
            listEmp.Items.Clear(); // Limpiar la lista actual

            // Si la búsqueda está vacía, restauramos todos los ítems originales
            if (string.IsNullOrWhiteSpace(nombreBuscado))
            {
                listEmp.Items.AddRange(listaOriginal.ToArray());
            }
            else
            {
                // Si hay texto en la búsqueda, filtramos los ítems coincidentes usando foreach
                foreach (var item in listaOriginal)
                {
                    string nombre = item.Text.ToLower();                 // Nombre está en item.Text
                    string apellido = item.SubItems[1].Text.ToLower();   // Apellido está en la segunda columna

                    if (nombre.Contains(nombreBuscado) || apellido.Contains(nombreBuscado))
                    {
                        listEmp.Items.Add((ListViewItem)item.Clone());
                    }
                }
            }

            // Reactivar el redibujado
            listEmp.EndUpdate();
        }


        private void ClickEnEmpleado(object sender, EventArgs e)
        {
            if (listEmp.SelectedItems.Count > 0)
            {
                // Obtener el primer elemento seleccionado
                ListViewItem selectedItem = listEmp.SelectedItems[0];
                string nombre = selectedItem.SubItems[0].Text;
                string dniEmp = selectedItem.SubItems[2].Text;
                this.dniEmp = dniEmp;

                var emp = this._empleados.Where(e => e.Dni.Equals(this.dniEmp)).FirstOrDefault();

                EventDniSeleccionado?.Invoke(this, dniEmp);
                EventEmpleadoSeleccionado?.Invoke(this, emp!);

                this.dniEmp = dniEmp;
            }
        }

        public string GetDniEmpleado()
        {
            return this.dniEmp;
        }
    }
}

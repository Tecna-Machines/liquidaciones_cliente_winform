using System.Net.NetworkInformation;

namespace UI.Utils
{
    internal  static class ListUtils
    {
        public static void AjustarColumnas(ListView listView)
        {
            // Primero, aseguramos que el ListView use el modo de dibujo propietario para ajustar el tamaño
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            // Ajustar todas las columnas a su contenido
            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = -2; // Ajustar automáticamente al contenido
            }

            // Ajustar la columna más ancha para ocupar el espacio restante
            int totalWidth = listView.ClientSize.Width;
            int totalColumnsWidth = 0;

            foreach (ColumnHeader column in listView.Columns)
            {
                if (column.Width > 0)
                {
                    totalColumnsWidth += column.Width;
                }
            }

            // Ajustar las columnas restantes para que ocupen el ancho total
            foreach (ColumnHeader column in listView.Columns)
            {
                if (column.Width > 0)
                {
                    // Ajustar proporcionalmente
                    column.Width = (int)((float)column.Width / totalColumnsWidth * totalWidth);
                }
            }

            // Ajustar la última columna para ocupar el ancho restante
            int totalAdjustedWidth = 0;
            foreach (ColumnHeader column in listView.Columns)
            {
                totalAdjustedWidth += column.Width;
            }
            if (listView.Columns.Count > 0)
            {
                ColumnHeader lastColumn = listView.Columns[listView.Columns.Count - 1];
                lastColumn.Width += (totalWidth - totalAdjustedWidth);
            }
        }

        public static void LimpiarElementos(ListView listView)
        {
            listView.Items.Clear();

        }

    }
}

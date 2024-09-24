namespace UI.Components.Screens
{
    partial class BuscarLiquiComponent
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            listaLiquidaciones = new ListView();
            columnCod = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnFecha = new ColumnHeader();
            columnPeriodo = new ColumnHeader();
            columnRemu = new ColumnHeader();
            btnFiltrarLiq = new Button();
            btnPagAnterior = new Button();
            btnPagSiguiente = new Button();
            labelPagina = new Label();
            labelTotalResult = new Label();
            SuspendLayout();
            // 
            // listaLiquidaciones
            // 
            listaLiquidaciones.Columns.AddRange(new ColumnHeader[] { columnCod, columnDesc, columnFecha, columnPeriodo, columnRemu });
            listaLiquidaciones.FullRowSelect = true;
            listaLiquidaciones.GridLines = true;
            listaLiquidaciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaLiquidaciones.Location = new Point(12, 84);
            listaLiquidaciones.Name = "listaLiquidaciones";
            listaLiquidaciones.Size = new Size(572, 219);
            listaLiquidaciones.TabIndex = 21;
            listaLiquidaciones.UseCompatibleStateImageBehavior = false;
            listaLiquidaciones.View = View.Details;
            // 
            // columnCod
            // 
            columnCod.Text = "CODIGO";
            columnCod.Width = 100;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descripcion";
            columnDesc.Width = 160;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            columnFecha.Width = 80;
            // 
            // columnPeriodo
            // 
            columnPeriodo.Text = "Periodo";
            columnPeriodo.Width = 110;
            // 
            // columnRemu
            // 
            columnRemu.Text = "Total Remunerativo";
            columnRemu.Width = 110;
            // 
            // btnFiltrarLiq
            // 
            btnFiltrarLiq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFiltrarLiq.Location = new Point(12, 15);
            btnFiltrarLiq.Name = "btnFiltrarLiq";
            btnFiltrarLiq.Size = new Size(125, 46);
            btnFiltrarLiq.TabIndex = 22;
            btnFiltrarLiq.Text = "BUSCAR";
            btnFiltrarLiq.UseVisualStyleBackColor = true;
            // 
            // btnPagAnterior
            // 
            btnPagAnterior.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagAnterior.Location = new Point(143, 15);
            btnPagAnterior.Name = "btnPagAnterior";
            btnPagAnterior.Size = new Size(75, 46);
            btnPagAnterior.TabIndex = 23;
            btnPagAnterior.Text = "<<";
            btnPagAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPagSiguiente
            // 
            btnPagSiguiente.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagSiguiente.Location = new Point(356, 15);
            btnPagSiguiente.Name = "btnPagSiguiente";
            btnPagSiguiente.Size = new Size(75, 46);
            btnPagSiguiente.TabIndex = 24;
            btnPagSiguiente.Text = ">>";
            btnPagSiguiente.UseVisualStyleBackColor = true;
            // 
            // labelPagina
            // 
            labelPagina.AutoSize = true;
            labelPagina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelPagina.Location = new Point(232, 31);
            labelPagina.Name = "labelPagina";
            labelPagina.Size = new Size(112, 19);
            labelPagina.TabIndex = 25;
            labelPagina.Text = "0 de 0 pagina/s";
            // 
            // labelTotalResult
            // 
            labelTotalResult.AutoSize = true;
            labelTotalResult.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalResult.Location = new Point(437, 32);
            labelTotalResult.Name = "labelTotalResult";
            labelTotalResult.Size = new Size(148, 19);
            labelTotalResult.TabIndex = 26;
            labelTotalResult.Text = "Cant. resultados: 000";
            // 
            // BuscarLiquiComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelTotalResult);
            Controls.Add(labelPagina);
            Controls.Add(btnPagSiguiente);
            Controls.Add(btnPagAnterior);
            Controls.Add(btnFiltrarLiq);
            Controls.Add(listaLiquidaciones);
            Name = "BuscarLiquiComponent";
            Size = new Size(596, 313);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listaLiquidaciones;
        private ColumnHeader columnCod;
        private ColumnHeader columnFecha;
        private ColumnHeader columnPeriodo;
        private ColumnHeader columnRemu;
        private ColumnHeader columnDesc;
        private Button btnFiltrarLiq;
        private Button btnPagAnterior;
        private Button btnPagSiguiente;
        private Label labelPagina;
        private Label labelTotalResult;
    }
}

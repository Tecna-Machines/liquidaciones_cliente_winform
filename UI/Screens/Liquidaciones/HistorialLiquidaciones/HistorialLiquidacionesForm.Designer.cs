namespace UI.Screens.Liquidaciones.HistorialLiquidaciones
{
    partial class HistorialLiquidacionesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablaLiquidaciones = new ListView();
            columnCodigo = new ColumnHeader();
            columnEmpleadoNombre = new ColumnHeader();
            columnDni = new ColumnHeader();
            columnFechaCreacion = new ColumnHeader();
            ColumnFechaSello = new ColumnHeader();
            columnEstado = new ColumnHeader();
            comboBoxYear = new ComboBox();
            labelAnio = new Label();
            comboBoxMeses = new ComboBox();
            labelFecha = new Label();
            label1 = new Label();
            comboBoxQuincena = new ComboBox();
            labelFiltro = new Label();
            BtnBuscar = new Button();
            SuspendLayout();
            // 
            // tablaLiquidaciones
            // 
            tablaLiquidaciones.Columns.AddRange(new ColumnHeader[] { columnCodigo, columnEmpleadoNombre, columnDni, columnFechaCreacion, ColumnFechaSello, columnEstado });
            tablaLiquidaciones.FullRowSelect = true;
            tablaLiquidaciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaLiquidaciones.Location = new Point(21, 87);
            tablaLiquidaciones.Name = "tablaLiquidaciones";
            tablaLiquidaciones.Size = new Size(710, 339);
            tablaLiquidaciones.TabIndex = 0;
            tablaLiquidaciones.UseCompatibleStateImageBehavior = false;
            tablaLiquidaciones.View = View.Details;
            tablaLiquidaciones.MouseDoubleClick += TablaLiquidaciones_MouseDoubleClick;
            // 
            // columnCodigo
            // 
            columnCodigo.Text = "Codigo";
            columnCodigo.Width = 120;
            // 
            // columnEmpleadoNombre
            // 
            columnEmpleadoNombre.Text = "Empleado";
            columnEmpleadoNombre.Width = 180;
            // 
            // columnDni
            // 
            columnDni.Text = "Dni";
            columnDni.Width = 80;
            // 
            // columnFechaCreacion
            // 
            columnFechaCreacion.Text = "Creada";
            columnFechaCreacion.Width = 100;
            // 
            // ColumnFechaSello
            // 
            ColumnFechaSello.Text = "Fecha sellada";
            ColumnFechaSello.Width = 100;
            // 
            // columnEstado
            // 
            columnEstado.Text = "ESTADO";
            columnEstado.Width = 100;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(490, 30);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(121, 23);
            comboBoxYear.TabIndex = 11;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.BackColor = SystemColors.ActiveCaption;
            labelAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnio.Location = new Point(442, 34);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(25, 15);
            labelAnio.TabIndex = 10;
            labelAnio.Text = "DE:";
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMeses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(281, 30);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(155, 23);
            comboBoxMeses.TabIndex = 9;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = SystemColors.ActiveCaption;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(223, 34);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(52, 15);
            labelFecha.TabIndex = 8;
            labelFecha.Text = "MES DE:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 12;
            label1.Text = "QUINCENA:";
            // 
            // comboBoxQuincena
            // 
            comboBoxQuincena.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxQuincena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxQuincena.FormattingEnabled = true;
            comboBoxQuincena.Items.AddRange(new object[] { "1", "2" });
            comboBoxQuincena.Location = new Point(128, 30);
            comboBoxQuincena.Name = "comboBoxQuincena";
            comboBoxQuincena.Size = new Size(72, 23);
            comboBoxQuincena.TabIndex = 13;
            // 
            // labelFiltro
            // 
            labelFiltro.BackColor = SystemColors.ActiveCaption;
            labelFiltro.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFiltro.Location = new Point(21, 18);
            labelFiltro.Name = "labelFiltro";
            labelFiltro.Padding = new Padding(3);
            labelFiltro.Size = new Size(710, 44);
            labelFiltro.TabIndex = 14;
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = SystemColors.ButtonHighlight;
            BtnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(634, 30);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 15;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // HistorialLiquidacionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(BtnBuscar);
            Controls.Add(comboBoxQuincena);
            Controls.Add(label1);
            Controls.Add(comboBoxYear);
            Controls.Add(labelAnio);
            Controls.Add(comboBoxMeses);
            Controls.Add(labelFecha);
            Controls.Add(tablaLiquidaciones);
            Controls.Add(labelFiltro);
            MaximizeBox = false;
            Name = "HistorialLiquidacionesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "historial";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView tablaLiquidaciones;
        private ColumnHeader columnCodigo;
        private ColumnHeader columnEmpleadoNombre;
        private ColumnHeader columnDni;
        private ColumnHeader columnFechaCreacion;
        private ColumnHeader ColumnFechaSello;
        private ColumnHeader columnEstado;
        private ComboBox comboBoxYear;
        private Label labelAnio;
        private ComboBox comboBoxMeses;
        private Label labelFecha;
        private Label label1;
        private ComboBox comboBoxQuincena;
        private Label labelFiltro;
        private Button BtnBuscar;
    }
}
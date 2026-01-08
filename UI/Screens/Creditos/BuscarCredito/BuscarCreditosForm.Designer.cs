namespace UI.Screens.Creditos.BuscarCredito
{
    partial class BuscarCreditosForm
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
            BtnBuscar = new Button();
            comboBoxEstado = new ComboBox();
            label1 = new Label();
            labelAnio = new Label();
            labelFecha = new Label();
            textBoxDni = new TextBox();
            fechaDesde = new DateTimePicker();
            fechaHasta = new DateTimePicker();
            label2 = new Label();
            textMontoMinimo = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            textMontoMaximo = new TextBox();
            labelResultados = new Label();
            tablaDeResultados = new ListView();
            columnCod = new ColumnHeader();
            columnDni = new ColumnHeader();
            columnDescripcion = new ColumnHeader();
            columnCuotas = new ColumnHeader();
            columnMontoPrestado = new ColumnHeader();
            columnEstado = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.BackColor = SystemColors.ButtonHighlight;
            BtnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBuscar.Location = new Point(47, 87);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(263, 35);
            BtnBuscar.TabIndex = 23;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "COMPLETADO", "ANULADO", "INCOMPLETO", "SUSPENDIDO" });
            comboBoxEstado.Location = new Point(210, 43);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(100, 23);
            comboBoxEstado.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 47);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 20;
            label1.Text = "DNI:";
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.BackColor = SystemColors.ActiveCaption;
            labelAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnio.Location = new Point(314, 47);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(47, 15);
            labelAnio.TabIndex = 18;
            labelAnio.Text = "DESDE:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.BackColor = SystemColors.ActiveCaption;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(151, 47);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(55, 15);
            labelFecha.TabIndex = 16;
            labelFecha.Text = "ESTADO:";
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(47, 43);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(100, 23);
            textBoxDni.TabIndex = 24;
            // 
            // fechaDesde
            // 
            fechaDesde.Checked = false;
            fechaDesde.Format = DateTimePickerFormat.Short;
            fechaDesde.Location = new Point(365, 43);
            fechaDesde.Name = "fechaDesde";
            fechaDesde.ShowCheckBox = true;
            fechaDesde.Size = new Size(100, 23);
            fechaDesde.TabIndex = 25;
            // 
            // fechaHasta
            // 
            fechaHasta.Checked = false;
            fechaHasta.Format = DateTimePickerFormat.Short;
            fechaHasta.Location = new Point(521, 43);
            fechaHasta.Name = "fechaHasta";
            fechaHasta.ShowCheckBox = true;
            fechaHasta.Size = new Size(100, 23);
            fechaHasta.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(469, 47);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 26;
            label2.Text = "HASTA:";
            // 
            // textMontoMinimo
            // 
            textMontoMinimo.Location = new Point(741, 43);
            textMontoMinimo.Name = "textMontoMinimo";
            textMontoMinimo.Size = new Size(100, 23);
            textMontoMinimo.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(625, 47);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 29;
            label3.Text = "PRESTADO (min) $:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(845, 47);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 30;
            label4.Text = "PRESTADO (max) $:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textMontoMaximo);
            panel1.Controls.Add(BtnBuscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBoxDni);
            panel1.Controls.Add(textMontoMinimo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(comboBoxEstado);
            panel1.Controls.Add(fechaHasta);
            panel1.Controls.Add(labelAnio);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fechaDesde);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 140);
            panel1.TabIndex = 31;
            // 
            // textMontoMaximo
            // 
            textMontoMaximo.Location = new Point(964, 43);
            textMontoMaximo.Name = "textMontoMaximo";
            textMontoMaximo.Size = new Size(100, 23);
            textMontoMaximo.TabIndex = 31;
            // 
            // labelResultados
            // 
            labelResultados.BackColor = SystemColors.GradientActiveCaption;
            labelResultados.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelResultados.Location = new Point(11, 180);
            labelResultados.Name = "labelResultados";
            labelResultados.Padding = new Padding(3);
            labelResultados.Size = new Size(1053, 24);
            labelResultados.TabIndex = 32;
            labelResultados.Text = "Resultados: 0";
            // 
            // tablaDeResultados
            // 
            tablaDeResultados.Columns.AddRange(new ColumnHeader[] { columnCod, columnDni, columnDescripcion, columnCuotas, columnMontoPrestado, columnEstado });
            tablaDeResultados.FullRowSelect = true;
            tablaDeResultados.GridLines = true;
            tablaDeResultados.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaDeResultados.Location = new Point(11, 217);
            tablaDeResultados.Name = "tablaDeResultados";
            tablaDeResultados.Size = new Size(1053, 288);
            tablaDeResultados.TabIndex = 33;
            tablaDeResultados.UseCompatibleStateImageBehavior = false;
            tablaDeResultados.View = View.Details;
            tablaDeResultados.MouseDoubleClick += TablaDeResultados_MouseDoubleClick;
            // 
            // columnCod
            // 
            columnCod.Text = "Codigo";
            columnCod.Width = 180;
            // 
            // columnDni
            // 
            columnDni.Text = "DNI";
            columnDni.Width = 90;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Descripcion";
            columnDescripcion.Width = 270;
            // 
            // columnCuotas
            // 
            columnCuotas.Text = "Cuotas";
            columnCuotas.Width = 70;
            // 
            // columnMontoPrestado
            // 
            columnMontoPrestado.Text = "Prestado ($)";
            columnMontoPrestado.Width = 100;
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            columnEstado.Width = 120;
            // 
            // BuscarCreditosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 538);
            Controls.Add(tablaDeResultados);
            Controls.Add(labelResultados);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "BuscarCreditosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BuscarCreditosForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBuscar;
        private ComboBox comboBoxEstado;
        private Label label1;
        private Label labelAnio;
        private Label labelFecha;
        private TextBox textBoxDni;
        private DateTimePicker fechaDesde;
        private DateTimePicker fechaHasta;
        private Label label2;
        private TextBox textMontoMinimo;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private TextBox textMontoMaximo;
        private Label labelResultados;
        private ListView tablaDeResultados;
        private ColumnHeader columnCod;
        private ColumnHeader columnDni;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnCuotas;
        private ColumnHeader columnMontoPrestado;
        private ColumnHeader columnEstado;
    }
}
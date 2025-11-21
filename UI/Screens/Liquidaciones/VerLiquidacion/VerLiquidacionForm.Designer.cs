namespace UI.Screens.VerLiquidacion
{
    partial class VerLiquidacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLiquidacionForm));
            textBoxCodigoLiq = new TextBox();
            labelCod = new Label();
            label1 = new Label();
            textBoxPeriodo = new TextBox();
            label4 = new Label();
            textBoxDni = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxFechaIng = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label12 = new Label();
            listaPagos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            textBoxFechaCreacion = new TextBox();
            label20 = new Label();
            progressBar = new ProgressBar();
            btnPagos = new Button();
            listContrato = new ListView();
            columnItem = new ColumnHeader();
            columValor = new ColumnHeader();
            labelaAcuerdo = new Label();
            listaSueldoBillete = new ListView();
            columDescrip = new ColumnHeader();
            columnRemu = new ColumnHeader();
            columnDescuento = new ColumnHeader();
            columFecha = new ColumnHeader();
            listaSueldoBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnFecha = new ColumnHeader();
            labelRetenciones = new Label();
            labelRemuneraciones = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBoxCodigoLiq
            // 
            textBoxCodigoLiq.BackColor = SystemColors.HighlightText;
            textBoxCodigoLiq.Location = new Point(103, 54);
            textBoxCodigoLiq.Name = "textBoxCodigoLiq";
            textBoxCodigoLiq.ReadOnly = true;
            textBoxCodigoLiq.Size = new Size(158, 23);
            textBoxCodigoLiq.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCod.Location = new Point(26, 56);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(68, 19);
            labelCod.TabIndex = 2;
            labelCod.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 56);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 4;
            label1.Text = "PERIODO:";
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = SystemColors.HighlightText;
            textBoxPeriodo.Location = new Point(353, 54);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.ReadOnly = true;
            textBoxPeriodo.Size = new Size(158, 23);
            textBoxPeriodo.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 98);
            label4.Name = "label4";
            label4.Size = new Size(1001, 23);
            label4.TabIndex = 9;
            label4.Text = "Detalle Empleado";
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.HighlightText;
            textBoxDni.Location = new Point(69, 133);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(134, 23);
            textBoxDni.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.HighlightText;
            textBoxNombre.Location = new Point(294, 133);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(158, 23);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = SystemColors.HighlightText;
            textBoxApellido.Location = new Point(544, 133);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ReadOnly = true;
            textBoxApellido.Size = new Size(158, 23);
            textBoxApellido.TabIndex = 12;
            // 
            // textBoxFechaIng
            // 
            textBoxFechaIng.BackColor = SystemColors.HighlightText;
            textBoxFechaIng.Location = new Point(770, 133);
            textBoxFechaIng.Name = "textBoxFechaIng";
            textBoxFechaIng.ReadOnly = true;
            textBoxFechaIng.Size = new Size(104, 23);
            textBoxFechaIng.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 135);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 14;
            label5.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(208, 135);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 15;
            label6.Text = "Nombre/s:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(457, 135);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 16;
            label7.Text = "Apellido/s:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(707, 135);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 17;
            label8.Text = "Ingreso:";
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(26, 644);
            label12.Name = "label12";
            label12.Size = new Size(665, 23);
            label12.TabIndex = 23;
            label12.Text = "Pagos";
            // 
            // listaPagos
            // 
            listaPagos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listaPagos.FullRowSelect = true;
            listaPagos.GridLines = true;
            listaPagos.Location = new Point(26, 670);
            listaPagos.Name = "listaPagos";
            listaPagos.Size = new Size(665, 85);
            listaPagos.TabIndex = 37;
            listaPagos.UseCompatibleStateImageBehavior = false;
            listaPagos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Monto";
            columnHeader3.Width = 95;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(709, 644);
            button1.Name = "button1";
            button1.Size = new Size(315, 54);
            button1.TabIndex = 38;
            button1.Text = "Descargar recibo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClickBtnGenerarRecibo;
            // 
            // textBoxFechaCreacion
            // 
            textBoxFechaCreacion.BackColor = SystemColors.HighlightText;
            textBoxFechaCreacion.Location = new Point(920, 133);
            textBoxFechaCreacion.Name = "textBoxFechaCreacion";
            textBoxFechaCreacion.ReadOnly = true;
            textBoxFechaCreacion.Size = new Size(104, 23);
            textBoxFechaCreacion.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(879, 135);
            label20.Name = "label20";
            label20.Size = new Size(40, 19);
            label20.TabIndex = 40;
            label20.Text = "Alta:";
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.AppWorkspace;
            progressBar.Location = new Point(312, 388);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(493, 51);
            progressBar.TabIndex = 41;
            progressBar.Visible = false;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.Honeydew;
            btnPagos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.Location = new Point(709, 704);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(315, 51);
            btnPagos.TabIndex = 42;
            btnPagos.Text = "Agregar pago";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += BtnPagos_Click;
            // 
            // listContrato
            // 
            listContrato.Columns.AddRange(new ColumnHeader[] { columnItem, columValor });
            listContrato.FullRowSelect = true;
            listContrato.GridLines = true;
            listContrato.Location = new Point(709, 195);
            listContrato.Name = "listContrato";
            listContrato.Scrollable = false;
            listContrato.Size = new Size(318, 436);
            listContrato.TabIndex = 48;
            listContrato.UseCompatibleStateImageBehavior = false;
            listContrato.View = View.Details;
            // 
            // columnItem
            // 
            columnItem.Text = "Item";
            columnItem.Width = 130;
            // 
            // columValor
            // 
            columValor.Text = "Valor";
            columValor.Width = 130;
            // 
            // labelaAcuerdo
            // 
            labelaAcuerdo.BackColor = SystemColors.GradientActiveCaption;
            labelaAcuerdo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelaAcuerdo.Location = new Point(709, 168);
            labelaAcuerdo.Name = "labelaAcuerdo";
            labelaAcuerdo.Padding = new Padding(3);
            labelaAcuerdo.Size = new Size(318, 24);
            labelaAcuerdo.TabIndex = 47;
            labelaAcuerdo.Text = "Acuerdo";
            // 
            // listaSueldoBillete
            // 
            listaSueldoBillete.Columns.AddRange(new ColumnHeader[] { columDescrip, columnRemu, columnDescuento, columFecha });
            listaSueldoBillete.FullRowSelect = true;
            listaSueldoBillete.GridLines = true;
            listaSueldoBillete.Location = new Point(26, 458);
            listaSueldoBillete.Name = "listaSueldoBillete";
            listaSueldoBillete.Size = new Size(667, 173);
            listaSueldoBillete.TabIndex = 46;
            listaSueldoBillete.UseCompatibleStateImageBehavior = false;
            listaSueldoBillete.View = View.Details;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Conceptos";
            columDescrip.Width = 350;
            // 
            // columnRemu
            // 
            columnRemu.DisplayIndex = 2;
            columnRemu.Text = "Remunerativo";
            // 
            // columnDescuento
            // 
            columnDescuento.DisplayIndex = 3;
            columnDescuento.Text = "Descuentos";
            // 
            // columFecha
            // 
            columFecha.DisplayIndex = 1;
            columFecha.Text = "Fecha";
            columFecha.Width = 90;
            // 
            // listaSueldoBlanco
            // 
            listaSueldoBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnRemunerativo, columnNORemu, columnDesc, columnFecha });
            listaSueldoBlanco.FullRowSelect = true;
            listaSueldoBlanco.GridLines = true;
            listaSueldoBlanco.Location = new Point(26, 195);
            listaSueldoBlanco.Name = "listaSueldoBlanco";
            listaSueldoBlanco.Size = new Size(670, 219);
            listaSueldoBlanco.TabIndex = 45;
            listaSueldoBlanco.UseCompatibleStateImageBehavior = false;
            listaSueldoBlanco.View = View.Details;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Conceptos";
            columnDescripcion.Width = 180;
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.DisplayIndex = 2;
            columnRemunerativo.Text = "Remuneraciones";
            columnRemunerativo.Width = 95;
            // 
            // columnNORemu
            // 
            columnNORemu.DisplayIndex = 3;
            columnNORemu.Text = "No Remunerativo";
            columnNORemu.Width = 120;
            // 
            // columnDesc
            // 
            columnDesc.DisplayIndex = 4;
            columnDesc.Text = "Descuentos";
            columnDesc.Width = 90;
            // 
            // columnFecha
            // 
            columnFecha.DisplayIndex = 1;
            columnFecha.Text = "Fecha";
            // 
            // labelRetenciones
            // 
            labelRetenciones.BackColor = SystemColors.ActiveCaption;
            labelRetenciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRetenciones.Location = new Point(26, 431);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 44;
            labelRetenciones.Text = "Detalle ";
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(26, 168);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 43;
            labelRemuneraciones.Text = " Detalle en blanco";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(520, 56);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 49;
            label2.Text = "ESTADO:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(595, 54);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(158, 23);
            textBox1.TabIndex = 50;
            // 
            // VerLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 767);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(listContrato);
            Controls.Add(labelaAcuerdo);
            Controls.Add(listaSueldoBillete);
            Controls.Add(listaSueldoBlanco);
            Controls.Add(labelRetenciones);
            Controls.Add(labelRemuneraciones);
            Controls.Add(btnPagos);
            Controls.Add(label20);
            Controls.Add(textBoxFechaCreacion);
            Controls.Add(button1);
            Controls.Add(listaPagos);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxFechaIng);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDni);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(textBoxPeriodo);
            Controls.Add(labelCod);
            Controls.Add(textBoxCodigoLiq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerLiquidacionForm";
            Text = "VerLiquidacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCodigoLiq;
        private Label labelCod;
        private Label label1;
        private TextBox textBoxPeriodo;
        private Label label4;
        private TextBox textBoxDni;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxFechaIng;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label12;
        private ListView listaPagos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private TextBox textBoxFechaCreacion;
        private Label label20;
        private ProgressBar progressBar;
        private Button btnPagos;
        private ListView listContrato;
        private ColumnHeader columnItem;
        private ColumnHeader columValor;
        private Label labelaAcuerdo;
        private ListView listaSueldoBillete;
        private ColumnHeader columDescrip;
        private ColumnHeader columnRemu;
        private ColumnHeader columnDescuento;
        private ColumnHeader columFecha;
        private ListView listaSueldoBlanco;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnRemunerativo;
        private ColumnHeader columnNORemu;
        private ColumnHeader columnDesc;
        private ColumnHeader columnFecha;
        private Label labelRetenciones;
        private Label labelRemuneraciones;
        private Label label2;
        private TextBox textBox1;
    }
}
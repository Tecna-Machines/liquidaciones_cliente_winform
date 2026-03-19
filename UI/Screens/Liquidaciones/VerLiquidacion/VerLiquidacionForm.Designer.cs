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
            tablaPagos = new ListView();
            columId = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnDescrip = new ColumnHeader();
            columnModo = new ColumnHeader();
            BtnDescargarRecibo = new Button();
            textBoxFechaAlta = new TextBox();
            label20 = new Label();
            progressBar = new ProgressBar();
            btnPagos = new Button();
            tablaAcuerdo = new ListView();
            columnItem = new ColumnHeader();
            columValor = new ColumnHeader();
            labelaAcuerdo = new Label();
            tablaDetalleNegro = new ListView();
            columDescrip = new ColumnHeader();
            columnRemu = new ColumnHeader();
            columnDescuento = new ColumnHeader();
            columFecha = new ColumnHeader();
            tablaDetalleBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnFecha = new ColumnHeader();
            labelRetenciones = new Label();
            labelRemuneraciones = new Label();
            label2 = new Label();
            textBoxEstado = new TextBox();
            columnContab = new ColumnHeader();
            SuspendLayout();
            // 
            // textBoxCodigoLiq
            // 
            textBoxCodigoLiq.BackColor = SystemColors.HighlightText;
            textBoxCodigoLiq.Location = new Point(103, 16);
            textBoxCodigoLiq.Name = "textBoxCodigoLiq";
            textBoxCodigoLiq.ReadOnly = true;
            textBoxCodigoLiq.Size = new Size(158, 23);
            textBoxCodigoLiq.TabIndex = 1;
            textBoxCodigoLiq.TabStop = false;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelCod.Location = new Point(26, 18);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(68, 19);
            labelCod.TabIndex = 2;
            labelCod.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(270, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 4;
            label1.Text = "PERIODO:";
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = SystemColors.HighlightText;
            textBoxPeriodo.Location = new Point(353, 16);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.ReadOnly = true;
            textBoxPeriodo.Size = new Size(158, 23);
            textBoxPeriodo.TabIndex = 3;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 60);
            label4.Name = "label4";
            label4.Size = new Size(1001, 23);
            label4.TabIndex = 9;
            label4.Text = "Detalle Empleado";
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.HighlightText;
            textBoxDni.Location = new Point(69, 95);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(134, 23);
            textBoxDni.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.HighlightText;
            textBoxNombre.Location = new Point(294, 95);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(158, 23);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = SystemColors.HighlightText;
            textBoxApellido.Location = new Point(544, 95);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ReadOnly = true;
            textBoxApellido.Size = new Size(158, 23);
            textBoxApellido.TabIndex = 12;
            // 
            // textBoxFechaIng
            // 
            textBoxFechaIng.BackColor = SystemColors.HighlightText;
            textBoxFechaIng.Location = new Point(770, 95);
            textBoxFechaIng.Name = "textBoxFechaIng";
            textBoxFechaIng.ReadOnly = true;
            textBoxFechaIng.Size = new Size(104, 23);
            textBoxFechaIng.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(26, 97);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 14;
            label5.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(208, 97);
            label6.Name = "label6";
            label6.Size = new Size(81, 19);
            label6.TabIndex = 15;
            label6.Text = "Nombre/s:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(457, 97);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 16;
            label7.Text = "Apellido/s:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(707, 97);
            label8.Name = "label8";
            label8.Size = new Size(63, 19);
            label8.TabIndex = 17;
            label8.Text = "Ingreso:";
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(26, 606);
            label12.Name = "label12";
            label12.Size = new Size(665, 23);
            label12.TabIndex = 23;
            label12.Text = "Pagos";
            // 
            // tablaPagos
            // 
            tablaPagos.Columns.AddRange(new ColumnHeader[] { columId, columnMonto, columnHeader3, columnDescrip, columnModo, columnContab });
            tablaPagos.FullRowSelect = true;
            tablaPagos.GridLines = true;
            tablaPagos.Location = new Point(26, 632);
            tablaPagos.Name = "tablaPagos";
            tablaPagos.Size = new Size(665, 123);
            tablaPagos.TabIndex = 37;
            tablaPagos.UseCompatibleStateImageBehavior = false;
            tablaPagos.View = View.Details;
            // 
            // columId
            // 
            columId.Text = "ID";
            columId.Width = 120;
            // 
            // columnMonto
            // 
            columnMonto.Text = "Monto";
            columnMonto.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Fecha";
            columnHeader3.Width = 80;
            // 
            // columnDescrip
            // 
            columnDescrip.Text = "Descripcion";
            columnDescrip.Width = 190;
            // 
            // columnModo
            // 
            columnModo.Text = "MODO";
            columnModo.Width = 100;
            // 
            // BtnDescargarRecibo
            // 
            BtnDescargarRecibo.BackColor = SystemColors.GradientActiveCaption;
            BtnDescargarRecibo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDescargarRecibo.Location = new Point(709, 606);
            BtnDescargarRecibo.Name = "BtnDescargarRecibo";
            BtnDescargarRecibo.Size = new Size(315, 58);
            BtnDescargarRecibo.TabIndex = 38;
            BtnDescargarRecibo.Text = "Descargar recibo";
            BtnDescargarRecibo.UseVisualStyleBackColor = false;
            BtnDescargarRecibo.Click += ClickBtnGenerarRecibo;
            // 
            // textBoxFechaAlta
            // 
            textBoxFechaAlta.BackColor = SystemColors.HighlightText;
            textBoxFechaAlta.Location = new Point(920, 95);
            textBoxFechaAlta.Name = "textBoxFechaAlta";
            textBoxFechaAlta.ReadOnly = true;
            textBoxFechaAlta.Size = new Size(104, 23);
            textBoxFechaAlta.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(879, 97);
            label20.Name = "label20";
            label20.Size = new Size(40, 19);
            label20.TabIndex = 40;
            label20.Text = "Alta:";
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.AppWorkspace;
            progressBar.Location = new Point(312, 350);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(493, 51);
            progressBar.TabIndex = 41;
            progressBar.Visible = false;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = Color.Honeydew;
            btnPagos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.Location = new Point(709, 697);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(315, 58);
            btnPagos.TabIndex = 42;
            btnPagos.Text = "Agregar pago";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += BtnPagos_Click;
            // 
            // tablaAcuerdo
            // 
            tablaAcuerdo.Columns.AddRange(new ColumnHeader[] { columnItem, columValor });
            tablaAcuerdo.FullRowSelect = true;
            tablaAcuerdo.GridLines = true;
            tablaAcuerdo.Location = new Point(709, 157);
            tablaAcuerdo.Name = "tablaAcuerdo";
            tablaAcuerdo.Scrollable = false;
            tablaAcuerdo.Size = new Size(318, 436);
            tablaAcuerdo.TabIndex = 48;
            tablaAcuerdo.UseCompatibleStateImageBehavior = false;
            tablaAcuerdo.View = View.Details;
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
            labelaAcuerdo.Location = new Point(709, 130);
            labelaAcuerdo.Name = "labelaAcuerdo";
            labelaAcuerdo.Padding = new Padding(3);
            labelaAcuerdo.Size = new Size(318, 24);
            labelaAcuerdo.TabIndex = 47;
            labelaAcuerdo.Text = "Acuerdo";
            // 
            // tablaDetalleNegro
            // 
            tablaDetalleNegro.Columns.AddRange(new ColumnHeader[] { columDescrip, columnRemu, columnDescuento, columFecha });
            tablaDetalleNegro.FullRowSelect = true;
            tablaDetalleNegro.GridLines = true;
            tablaDetalleNegro.Location = new Point(26, 420);
            tablaDetalleNegro.Name = "tablaDetalleNegro";
            tablaDetalleNegro.Size = new Size(667, 173);
            tablaDetalleNegro.TabIndex = 46;
            tablaDetalleNegro.UseCompatibleStateImageBehavior = false;
            tablaDetalleNegro.View = View.Details;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Conceptos";
            columDescrip.Width = 320;
            // 
            // columnRemu
            // 
            columnRemu.Text = "Remunerativo";
            columnRemu.Width = 90;
            // 
            // columnDescuento
            // 
            columnDescuento.Text = "Descuentos";
            columnDescuento.Width = 90;
            // 
            // columFecha
            // 
            columFecha.Text = "Fecha";
            columFecha.Width = 100;
            // 
            // tablaDetalleBlanco
            // 
            tablaDetalleBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnDesc, columnRemunerativo, columnNORemu, columnFecha });
            tablaDetalleBlanco.FullRowSelect = true;
            tablaDetalleBlanco.GridLines = true;
            tablaDetalleBlanco.Location = new Point(26, 157);
            tablaDetalleBlanco.Name = "tablaDetalleBlanco";
            tablaDetalleBlanco.Size = new Size(670, 219);
            tablaDetalleBlanco.TabIndex = 45;
            tablaDetalleBlanco.UseCompatibleStateImageBehavior = false;
            tablaDetalleBlanco.View = View.Details;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Conceptos";
            columnDescripcion.Width = 210;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descuentos";
            columnDesc.Width = 90;
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.Text = "Remuneraciones";
            columnRemunerativo.Width = 100;
            // 
            // columnNORemu
            // 
            columnNORemu.Text = "No Remunerativo";
            columnNORemu.Width = 120;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            columnFecha.Width = 110;
            // 
            // labelRetenciones
            // 
            labelRetenciones.BackColor = SystemColors.ActiveCaption;
            labelRetenciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRetenciones.Location = new Point(26, 393);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 44;
            labelRetenciones.Text = "Detalle Interno";
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(26, 130);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 43;
            labelRemuneraciones.Text = " Detalle Oficial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(520, 18);
            label2.Name = "label2";
            label2.Size = new Size(66, 19);
            label2.TabIndex = 49;
            label2.Text = "ESTADO:";
            // 
            // textBoxEstado
            // 
            textBoxEstado.BackColor = SystemColors.HighlightText;
            textBoxEstado.Location = new Point(595, 16);
            textBoxEstado.Name = "textBoxEstado";
            textBoxEstado.ReadOnly = true;
            textBoxEstado.Size = new Size(158, 23);
            textBoxEstado.TabIndex = 50;
            // 
            // columnContab
            // 
            columnContab.Text = "Pago Contab";
            columnContab.Width = 90;
            // 
            // VerLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 767);
            Controls.Add(textBoxEstado);
            Controls.Add(label2);
            Controls.Add(progressBar);
            Controls.Add(tablaAcuerdo);
            Controls.Add(labelaAcuerdo);
            Controls.Add(tablaDetalleNegro);
            Controls.Add(tablaDetalleBlanco);
            Controls.Add(labelRetenciones);
            Controls.Add(labelRemuneraciones);
            Controls.Add(btnPagos);
            Controls.Add(label20);
            Controls.Add(textBoxFechaAlta);
            Controls.Add(BtnDescargarRecibo);
            Controls.Add(tablaPagos);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerLiquidacionForm";
            StartPosition = FormStartPosition.CenterParent;
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
        private ListView tablaPagos;
        private ColumnHeader columId;
        private ColumnHeader columnMonto;
        private ColumnHeader columnHeader3;
        private Button BtnDescargarRecibo;
        private TextBox textBoxFechaAlta;
        private Label label20;
        private ProgressBar progressBar;
        private Button btnPagos;
        private ListView tablaAcuerdo;
        private ColumnHeader columnItem;
        private ColumnHeader columValor;
        private Label labelaAcuerdo;
        private ListView tablaDetalleNegro;
        private ColumnHeader columDescrip;
        private ColumnHeader columnRemu;
        private ColumnHeader columnDescuento;
        private ColumnHeader columFecha;
        private ListView tablaDetalleBlanco;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnRemunerativo;
        private ColumnHeader columnNORemu;
        private ColumnHeader columnDesc;
        private ColumnHeader columnFecha;
        private Label labelRetenciones;
        private Label labelRemuneraciones;
        private Label label2;
        private TextBox textBoxEstado;
        private ColumnHeader columnDescrip;
        private ColumnHeader columnModo;
        private ColumnHeader columnContab;
    }
}
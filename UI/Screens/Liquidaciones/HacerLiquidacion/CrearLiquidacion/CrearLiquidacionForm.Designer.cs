namespace UI.Screens.HacerLiquidacion
{
    partial class CrearLiquidacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearLiquidacionForm));
            listaConBuscador = new UI.Components.Utils.ListaEmpComponent();
            panelDatos = new Panel();
            label4 = new Label();
            textBoxEmpleado = new TextBox();
            label3 = new Label();
            textBoxPeriodo = new TextBox();
            labelRemuneraciones = new Label();
            labelRetenciones = new Label();
            tablaDetalleEnBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnFecha = new ColumnHeader();
            tablaDetalleEnNegro = new ListView();
            columDescrip = new ColumnHeader();
            columnRemu = new ColumnHeader();
            columnDescuento = new ColumnHeader();
            columFecha = new ColumnHeader();
            labelaAcuerdo = new Label();
            tablaAcuerdo = new ListView();
            columnItem = new ColumnHeader();
            columValor = new ColumnHeader();
            BtnRecalcular = new Button();
            BtnSellar = new Button();
            btnMarcas = new Button();
            BtnItem = new Button();
            groupBoxMontosPagar = new GroupBox();
            BtnDarAdelanto = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnPagarInternoNeto = new Button();
            BtnPagarOficialNeto = new Button();
            LabelMontoInternoFaltaPagar = new Label();
            LabelMontoOficialFaltaPagar = new Label();
            lvTotales = new ListView();
            Totales = new ColumnHeader();
            remuneraciones = new ColumnHeader();
            descuentos = new ColumnHeader();
            noRemunerativo = new ColumnHeader();
            fecha = new ColumnHeader();
            lvTotalesInterno = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            BtnCargarPago = new Button();
            label5 = new Label();
            lvPagos = new ListView();
            columnHeader7 = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columCuenta = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            panelDatos.SuspendLayout();
            groupBoxMontosPagar.SuspendLayout();
            SuspendLayout();
            // 
            // listaConBuscador
            // 
            listaConBuscador.Dock = DockStyle.Left;
            listaConBuscador.Location = new Point(0, 0);
            listaConBuscador.Name = "listaConBuscador";
            listaConBuscador.ServiceProvider = null;
            listaConBuscador.Size = new Size(314, 821);
            listaConBuscador.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(textBoxEmpleado);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(textBoxPeriodo);
            panelDatos.Dock = DockStyle.Top;
            panelDatos.Location = new Point(314, 0);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1252, 85);
            panelDatos.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(324, 20);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(579, 24);
            label4.TabIndex = 22;
            label4.Text = "DNI / APELLIDO Y NOMBRE";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEmpleado
            // 
            textBoxEmpleado.BackColor = SystemColors.ButtonHighlight;
            textBoxEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxEmpleado.Location = new Point(324, 47);
            textBoxEmpleado.Name = "textBoxEmpleado";
            textBoxEmpleado.ReadOnly = true;
            textBoxEmpleado.Size = new Size(579, 29);
            textBoxEmpleado.TabIndex = 21;
            textBoxEmpleado.Text = "00000000 - Mariano Mirian Leguizamol";
            textBoxEmpleado.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(18, 20);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(290, 24);
            label3.TabIndex = 20;
            label3.Text = "Periodo abonado";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = SystemColors.ButtonHighlight;
            textBoxPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxPeriodo.Location = new Point(18, 47);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.ReadOnly = true;
            textBoxPeriodo.Size = new Size(290, 29);
            textBoxPeriodo.TabIndex = 0;
            textBoxPeriodo.Text = "1ra Quincena - Diciembre 1990";
            textBoxPeriodo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRemuneraciones.Location = new Point(314, 147);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 3;
            labelRemuneraciones.Text = " Detalle oficial";
            // 
            // labelRetenciones
            // 
            labelRetenciones.BackColor = SystemColors.ActiveCaption;
            labelRetenciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRetenciones.Location = new Point(316, 437);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 4;
            labelRetenciones.Text = "Detalle interno";
            // 
            // tablaDetalleEnBlanco
            // 
            tablaDetalleEnBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnRemunerativo, columnDesc, columnNORemu, columnFecha });
            tablaDetalleEnBlanco.FullRowSelect = true;
            tablaDetalleEnBlanco.GridLines = true;
            tablaDetalleEnBlanco.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaDetalleEnBlanco.Location = new Point(314, 174);
            tablaDetalleEnBlanco.Name = "tablaDetalleEnBlanco";
            tablaDetalleEnBlanco.Size = new Size(670, 219);
            tablaDetalleEnBlanco.TabIndex = 6;
            tablaDetalleEnBlanco.UseCompatibleStateImageBehavior = false;
            tablaDetalleEnBlanco.View = View.Details;
            tablaDetalleEnBlanco.MouseDoubleClick += TablaDetalleEnBlanco_MouseDoubleClick;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Conceptos";
            columnDescripcion.Width = 210;
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.Text = "Remuneraciones";
            columnRemunerativo.TextAlign = HorizontalAlignment.Right;
            columnRemunerativo.Width = 110;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descuentos";
            columnDesc.TextAlign = HorizontalAlignment.Right;
            columnDesc.Width = 110;
            // 
            // columnNORemu
            // 
            columnNORemu.Text = "No Remunerativo";
            columnNORemu.TextAlign = HorizontalAlignment.Right;
            columnNORemu.Width = 110;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            columnFecha.TextAlign = HorizontalAlignment.Right;
            columnFecha.Width = 100;
            // 
            // tablaDetalleEnNegro
            // 
            tablaDetalleEnNegro.Columns.AddRange(new ColumnHeader[] { columDescrip, columnRemu, columnDescuento, columFecha });
            tablaDetalleEnNegro.FullRowSelect = true;
            tablaDetalleEnNegro.GridLines = true;
            tablaDetalleEnNegro.Location = new Point(316, 466);
            tablaDetalleEnNegro.Name = "tablaDetalleEnNegro";
            tablaDetalleEnNegro.Size = new Size(667, 186);
            tablaDetalleEnNegro.TabIndex = 7;
            tablaDetalleEnNegro.UseCompatibleStateImageBehavior = false;
            tablaDetalleEnNegro.View = View.Details;
            tablaDetalleEnNegro.MouseDoubleClick += TablaDetalleEnNegro_MouseDoubleClick;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Conceptos";
            columDescrip.Width = 210;
            // 
            // columnRemu
            // 
            columnRemu.Text = "Remunerativo";
            columnRemu.TextAlign = HorizontalAlignment.Right;
            columnRemu.Width = 110;
            // 
            // columnDescuento
            // 
            columnDescuento.Text = "Descuentos";
            columnDescuento.TextAlign = HorizontalAlignment.Right;
            columnDescuento.Width = 110;
            // 
            // columFecha
            // 
            columFecha.Text = "Fecha";
            columFecha.TextAlign = HorizontalAlignment.Right;
            columFecha.Width = 100;
            // 
            // labelaAcuerdo
            // 
            labelaAcuerdo.BackColor = SystemColors.GradientActiveCaption;
            labelaAcuerdo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelaAcuerdo.Location = new Point(997, 147);
            labelaAcuerdo.Name = "labelaAcuerdo";
            labelaAcuerdo.Padding = new Padding(3);
            labelaAcuerdo.Size = new Size(553, 24);
            labelaAcuerdo.TabIndex = 8;
            labelaAcuerdo.Text = "Acuerdo";
            // 
            // tablaAcuerdo
            // 
            tablaAcuerdo.Columns.AddRange(new ColumnHeader[] { columnItem, columValor });
            tablaAcuerdo.FullRowSelect = true;
            tablaAcuerdo.GridLines = true;
            tablaAcuerdo.Location = new Point(997, 174);
            tablaAcuerdo.Name = "tablaAcuerdo";
            tablaAcuerdo.Size = new Size(553, 256);
            tablaAcuerdo.TabIndex = 9;
            tablaAcuerdo.UseCompatibleStateImageBehavior = false;
            tablaAcuerdo.View = View.Details;
            // 
            // columnItem
            // 
            columnItem.Text = "Item";
            columnItem.Width = 300;
            // 
            // columValor
            // 
            columValor.Text = "Valor";
            columValor.Width = 200;
            // 
            // BtnRecalcular
            // 
            BtnRecalcular.BackColor = SystemColors.Info;
            BtnRecalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnRecalcular.Location = new Point(632, 96);
            BtnRecalcular.Name = "BtnRecalcular";
            BtnRecalcular.Size = new Size(109, 41);
            BtnRecalcular.TabIndex = 10;
            BtnRecalcular.Text = "RECALCULAR";
            BtnRecalcular.UseVisualStyleBackColor = false;
            BtnRecalcular.Click += BtnRecalcular_Click;
            // 
            // BtnSellar
            // 
            BtnSellar.BackColor = Color.Gold;
            BtnSellar.BackgroundImageLayout = ImageLayout.None;
            BtnSellar.Cursor = Cursors.Hand;
            BtnSellar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSellar.Location = new Point(872, 96);
            BtnSellar.Name = "BtnSellar";
            BtnSellar.Size = new Size(109, 41);
            BtnSellar.TabIndex = 11;
            BtnSellar.Text = "SELLAR";
            BtnSellar.UseVisualStyleBackColor = false;
            BtnSellar.Click += BtnSellar_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.BackColor = SystemColors.GradientActiveCaption;
            btnMarcas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMarcas.Location = new Point(314, 96);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(149, 41);
            btnMarcas.TabIndex = 17;
            btnMarcas.Text = "VER MARCAS";
            btnMarcas.UseVisualStyleBackColor = false;
            btnMarcas.Click += ClickBtnMarcas;
            // 
            // BtnItem
            // 
            BtnItem.BackColor = SystemColors.GradientActiveCaption;
            BtnItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnItem.Location = new Point(474, 96);
            BtnItem.Name = "BtnItem";
            BtnItem.Size = new Size(147, 41);
            BtnItem.TabIndex = 18;
            BtnItem.Text = "AGREGAR ITEM";
            BtnItem.UseVisualStyleBackColor = false;
            BtnItem.Click += ClickBtnAgregarItem;
            // 
            // groupBoxMontosPagar
            // 
            groupBoxMontosPagar.Controls.Add(BtnDarAdelanto);
            groupBoxMontosPagar.Controls.Add(label2);
            groupBoxMontosPagar.Controls.Add(label1);
            groupBoxMontosPagar.Controls.Add(BtnPagarInternoNeto);
            groupBoxMontosPagar.Controls.Add(BtnPagarOficialNeto);
            groupBoxMontosPagar.Controls.Add(LabelMontoInternoFaltaPagar);
            groupBoxMontosPagar.Controls.Add(LabelMontoOficialFaltaPagar);
            groupBoxMontosPagar.Font = new Font("Consolas", 10F, FontStyle.Bold);
            groupBoxMontosPagar.Location = new Point(316, 696);
            groupBoxMontosPagar.Name = "groupBoxMontosPagar";
            groupBoxMontosPagar.Size = new Size(665, 113);
            groupBoxMontosPagar.TabIndex = 19;
            groupBoxMontosPagar.TabStop = false;
            groupBoxMontosPagar.Text = "Pagar al empleado:";
            // 
            // BtnDarAdelanto
            // 
            BtnDarAdelanto.Cursor = Cursors.Hand;
            BtnDarAdelanto.ForeColor = SystemColors.Highlight;
            BtnDarAdelanto.Location = new Point(511, 71);
            BtnDarAdelanto.Name = "BtnDarAdelanto";
            BtnDarAdelanto.Size = new Size(135, 23);
            BtnDarAdelanto.TabIndex = 40;
            BtnDarAdelanto.Text = "PAGAR ADELANTO";
            BtnDarAdelanto.UseVisualStyleBackColor = true;
            BtnDarAdelanto.Click += BtnDarAdelanto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(24, 74);
            label2.Name = "label2";
            label2.Size = new Size(152, 17);
            label2.TabIndex = 39;
            label2.Text = "interno por pagar:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(16, 33);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 38;
            label1.Text = " oficial por pagar:";
            // 
            // BtnPagarInternoNeto
            // 
            BtnPagarInternoNeto.Cursor = Cursors.Hand;
            BtnPagarInternoNeto.ForeColor = SystemColors.Highlight;
            BtnPagarInternoNeto.Location = new Point(347, 71);
            BtnPagarInternoNeto.Name = "BtnPagarInternoNeto";
            BtnPagarInternoNeto.Size = new Size(151, 23);
            BtnPagarInternoNeto.TabIndex = 37;
            BtnPagarInternoNeto.Text = "PAGAR INTERNO";
            BtnPagarInternoNeto.UseVisualStyleBackColor = true;
            BtnPagarInternoNeto.Click += BtnPagarInternoNeto_Click;
            // 
            // BtnPagarOficialNeto
            // 
            BtnPagarOficialNeto.Cursor = Cursors.Hand;
            BtnPagarOficialNeto.ForeColor = Color.SeaGreen;
            BtnPagarOficialNeto.Location = new Point(347, 30);
            BtnPagarOficialNeto.Name = "BtnPagarOficialNeto";
            BtnPagarOficialNeto.Size = new Size(151, 23);
            BtnPagarOficialNeto.TabIndex = 36;
            BtnPagarOficialNeto.Text = "PAGAR OFICIAL";
            BtnPagarOficialNeto.UseVisualStyleBackColor = true;
            BtnPagarOficialNeto.Click += BtnPagarOficialNeto_Click;
            // 
            // LabelMontoInternoFaltaPagar
            // 
            LabelMontoInternoFaltaPagar.AutoSize = true;
            LabelMontoInternoFaltaPagar.Font = new Font("Consolas", 14F, FontStyle.Bold);
            LabelMontoInternoFaltaPagar.ForeColor = SystemColors.Highlight;
            LabelMontoInternoFaltaPagar.Location = new Point(186, 71);
            LabelMontoInternoFaltaPagar.Name = "LabelMontoInternoFaltaPagar";
            LabelMontoInternoFaltaPagar.Size = new Size(150, 22);
            LabelMontoInternoFaltaPagar.TabIndex = 1;
            LabelMontoInternoFaltaPagar.Text = "$ 2.000.000,00";
            // 
            // LabelMontoOficialFaltaPagar
            // 
            LabelMontoOficialFaltaPagar.AutoSize = true;
            LabelMontoOficialFaltaPagar.Font = new Font("Consolas", 14F, FontStyle.Bold);
            LabelMontoOficialFaltaPagar.ForeColor = Color.SeaGreen;
            LabelMontoOficialFaltaPagar.Location = new Point(186, 30);
            LabelMontoOficialFaltaPagar.Name = "LabelMontoOficialFaltaPagar";
            LabelMontoOficialFaltaPagar.Size = new Size(150, 22);
            LabelMontoOficialFaltaPagar.TabIndex = 0;
            LabelMontoOficialFaltaPagar.Text = "$ 8.000.000,00";
            // 
            // lvTotales
            // 
            lvTotales.BorderStyle = BorderStyle.FixedSingle;
            lvTotales.Columns.AddRange(new ColumnHeader[] { Totales, remuneraciones, descuentos, noRemunerativo, fecha });
            lvTotales.Enabled = false;
            lvTotales.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lvTotales.FullRowSelect = true;
            lvTotales.HeaderStyle = ColumnHeaderStyle.None;
            lvTotales.LabelWrap = false;
            lvTotales.Location = new Point(314, 395);
            lvTotales.MultiSelect = false;
            lvTotales.Name = "lvTotales";
            lvTotales.Scrollable = false;
            lvTotales.Size = new Size(670, 35);
            lvTotales.TabIndex = 31;
            lvTotales.UseCompatibleStateImageBehavior = false;
            lvTotales.View = View.Details;
            // 
            // Totales
            // 
            Totales.Width = 210;
            // 
            // remuneraciones
            // 
            remuneraciones.TextAlign = HorizontalAlignment.Right;
            remuneraciones.Width = 110;
            // 
            // descuentos
            // 
            descuentos.TextAlign = HorizontalAlignment.Right;
            descuentos.Width = 110;
            // 
            // noRemunerativo
            // 
            noRemunerativo.TextAlign = HorizontalAlignment.Right;
            noRemunerativo.Width = 110;
            // 
            // fecha
            // 
            fecha.Width = 100;
            // 
            // lvTotalesInterno
            // 
            lvTotalesInterno.BorderStyle = BorderStyle.FixedSingle;
            lvTotalesInterno.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvTotalesInterno.Enabled = false;
            lvTotalesInterno.Font = new Font("Consolas", 9F, FontStyle.Bold);
            lvTotalesInterno.FullRowSelect = true;
            lvTotalesInterno.HeaderStyle = ColumnHeaderStyle.None;
            lvTotalesInterno.LabelWrap = false;
            lvTotalesInterno.Location = new Point(316, 655);
            lvTotalesInterno.MultiSelect = false;
            lvTotalesInterno.Name = "lvTotalesInterno";
            lvTotalesInterno.Scrollable = false;
            lvTotalesInterno.Size = new Size(667, 35);
            lvTotalesInterno.TabIndex = 32;
            lvTotalesInterno.UseCompatibleStateImageBehavior = false;
            lvTotalesInterno.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.TextAlign = HorizontalAlignment.Right;
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            columnHeader5.Width = 100;
            // 
            // BtnCargarPago
            // 
            BtnCargarPago.BackColor = Color.PaleGreen;
            BtnCargarPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnCargarPago.Location = new Point(752, 96);
            BtnCargarPago.Name = "BtnCargarPago";
            BtnCargarPago.Size = new Size(109, 41);
            BtnCargarPago.TabIndex = 33;
            BtnCargarPago.Text = "CARGAR PAGO";
            BtnCargarPago.UseVisualStyleBackColor = false;
            BtnCargarPago.Click += BtnCargarPago_Click;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.GradientActiveCaption;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(997, 437);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(553, 24);
            label5.TabIndex = 34;
            label5.Text = "Pagos";
            // 
            // lvPagos
            // 
            lvPagos.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnMonto, columCuenta, columnHeader6 });
            lvPagos.Location = new Point(997, 466);
            lvPagos.Name = "lvPagos";
            lvPagos.Scrollable = false;
            lvPagos.Size = new Size(553, 186);
            lvPagos.TabIndex = 35;
            lvPagos.UseCompatibleStateImageBehavior = false;
            lvPagos.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Descripcion";
            columnHeader7.Width = 200;
            // 
            // columnMonto
            // 
            columnMonto.Text = "Monto";
            columnMonto.Width = 100;
            // 
            // columCuenta
            // 
            columCuenta.Text = "Fecha";
            columCuenta.Width = 110;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Pago Contab";
            columnHeader6.Width = 90;
            // 
            // CrearLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1566, 821);
            Controls.Add(lvPagos);
            Controls.Add(label5);
            Controls.Add(BtnCargarPago);
            Controls.Add(lvTotalesInterno);
            Controls.Add(lvTotales);
            Controls.Add(groupBoxMontosPagar);
            Controls.Add(BtnItem);
            Controls.Add(btnMarcas);
            Controls.Add(BtnSellar);
            Controls.Add(BtnRecalcular);
            Controls.Add(tablaAcuerdo);
            Controls.Add(labelaAcuerdo);
            Controls.Add(tablaDetalleEnNegro);
            Controls.Add(tablaDetalleEnBlanco);
            Controls.Add(labelRetenciones);
            Controls.Add(labelRemuneraciones);
            Controls.Add(panelDatos);
            Controls.Add(listaConBuscador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearLiquidacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearLiquidacion";
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            groupBoxMontosPagar.ResumeLayout(false);
            groupBoxMontosPagar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaConBuscador;
        private Panel panelDatos;
        private Label labelDescuentos;
        private Label labelRemuneraciones;
        private Label labelRetenciones;
        private ListView tablaDetalleEnBlanco;
        private Label labelNoRemuneraciones;
        private ListView tablaAcuerdo;
        private ListView tablaDetalleEnNegro;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnRemunerativo;
        private ColumnHeader columnNORemu;
        private ListView listView3;
        private ColumnHeader columnFecha;
        private ColumnHeader columnDesc;
        private ColumnHeader columDescrip;
        private ColumnHeader columFecha;
        private Label labelaAcuerdo;
        private ColumnHeader columnItem;
        private ColumnHeader columValor;
        private Button BtnRecalcular;
        private Button BtnSellar;
        private Button btnMarcas;
        private Button BtnItem;
        private ColumnHeader columnRemu;
        private ColumnHeader columnDescuento;
        private GroupBox groupBoxMontosPagar;
        private Label LabelMontoOficialFaltaPagar;
        private Label LabelMontoInternoFaltaPagar;
        private TextBox textBoxPeriodo;
        private Label label3;
        private Label label4;
        private TextBox textBoxEmpleado;
        private ListView lvTotales;
        private ColumnHeader Totales;
        private ColumnHeader descuentos;
        private ColumnHeader remuneraciones;
        private ColumnHeader noRemunerativo;
        private ColumnHeader fecha;
        private ListView lvTotalesInterno;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button BtnCargarPago;
        private Label label5;
        private ListView lvPagos;
        private ColumnHeader columnMonto;
        private ColumnHeader columCuenta;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button BtnPagarInternoNeto;
        private Button BtnPagarOficialNeto;
        private Button BtnDarAdelanto;
        private Label label2;
        private Label label1;
    }
}
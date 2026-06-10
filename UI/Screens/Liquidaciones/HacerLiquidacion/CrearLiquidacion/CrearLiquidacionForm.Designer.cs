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
            columnDesc = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
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
            label2 = new Label();
            label1 = new Label();
            valorPagarNegro = new Label();
            valorPagarBlanco = new Label();
            labelSubTotalRemunerativo = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            labelSubtotalDescuentosOficial = new Label();
            groupBox3 = new GroupBox();
            labelSubTotalNoRemunerativo = new Label();
            groupBox4 = new GroupBox();
            labelSubtotalRemunerativoInterno = new Label();
            groupBox5 = new GroupBox();
            labelSubTotalDescuentosInterno = new Label();
            panelDatos.SuspendLayout();
            groupBoxMontosPagar.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
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
            panelDatos.Size = new Size(1021, 109);
            panelDatos.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(224, 35);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(579, 24);
            label4.TabIndex = 22;
            label4.Text = "EMPLEADO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxEmpleado
            // 
            textBoxEmpleado.BackColor = SystemColors.ButtonHighlight;
            textBoxEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxEmpleado.Location = new Point(224, 62);
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
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(181, 24);
            label3.TabIndex = 20;
            label3.Text = "PERIODO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = SystemColors.ButtonHighlight;
            textBoxPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            textBoxPeriodo.Location = new Point(18, 62);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.ReadOnly = true;
            textBoxPeriodo.Size = new Size(181, 29);
            textBoxPeriodo.TabIndex = 0;
            textBoxPeriodo.Text = "1ra Diciembre 1990";
            textBoxPeriodo.TextAlign = HorizontalAlignment.Center;
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRemuneraciones.Location = new Point(314, 172);
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
            labelRetenciones.Location = new Point(316, 473);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 4;
            labelRetenciones.Text = "Detalle interno";
            // 
            // tablaDetalleEnBlanco
            // 
            tablaDetalleEnBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnDesc, columnRemunerativo, columnNORemu, columnFecha });
            tablaDetalleEnBlanco.FullRowSelect = true;
            tablaDetalleEnBlanco.GridLines = true;
            tablaDetalleEnBlanco.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaDetalleEnBlanco.Location = new Point(314, 199);
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
            columnDescripcion.Width = 190;
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
            columnFecha.Width = 120;
            // 
            // tablaDetalleEnNegro
            // 
            tablaDetalleEnNegro.Columns.AddRange(new ColumnHeader[] { columDescrip, columnRemu, columnDescuento, columFecha });
            tablaDetalleEnNegro.FullRowSelect = true;
            tablaDetalleEnNegro.GridLines = true;
            tablaDetalleEnNegro.Location = new Point(316, 502);
            tablaDetalleEnNegro.Name = "tablaDetalleEnNegro";
            tablaDetalleEnNegro.Size = new Size(667, 173);
            tablaDetalleEnNegro.TabIndex = 7;
            tablaDetalleEnNegro.UseCompatibleStateImageBehavior = false;
            tablaDetalleEnNegro.View = View.Details;
            tablaDetalleEnNegro.MouseDoubleClick += TablaDetalleEnNegro_MouseDoubleClick;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Conceptos";
            columDescrip.Width = 300;
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
            columFecha.Width = 120;
            // 
            // labelaAcuerdo
            // 
            labelaAcuerdo.BackColor = SystemColors.GradientActiveCaption;
            labelaAcuerdo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelaAcuerdo.Location = new Point(997, 172);
            labelaAcuerdo.Name = "labelaAcuerdo";
            labelaAcuerdo.Padding = new Padding(3);
            labelaAcuerdo.Size = new Size(318, 24);
            labelaAcuerdo.TabIndex = 8;
            labelaAcuerdo.Text = "Acuerdo";
            // 
            // tablaAcuerdo
            // 
            tablaAcuerdo.Columns.AddRange(new ColumnHeader[] { columnItem, columValor });
            tablaAcuerdo.FullRowSelect = true;
            tablaAcuerdo.GridLines = true;
            tablaAcuerdo.Location = new Point(997, 199);
            tablaAcuerdo.Name = "tablaAcuerdo";
            tablaAcuerdo.Scrollable = false;
            tablaAcuerdo.Size = new Size(318, 476);
            tablaAcuerdo.TabIndex = 9;
            tablaAcuerdo.UseCompatibleStateImageBehavior = false;
            tablaAcuerdo.View = View.Details;
            // 
            // columnItem
            // 
            columnItem.Text = "Item";
            columnItem.Width = 160;
            // 
            // columValor
            // 
            columValor.Text = "Valor";
            columValor.Width = 130;
            // 
            // BtnRecalcular
            // 
            BtnRecalcular.BackColor = Color.MediumSeaGreen;
            BtnRecalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnRecalcular.Location = new Point(714, 115);
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
            BtnSellar.Location = new Point(875, 115);
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
            btnMarcas.Location = new Point(314, 115);
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
            BtnItem.Location = new Point(515, 115);
            BtnItem.Name = "BtnItem";
            BtnItem.Size = new Size(147, 41);
            BtnItem.TabIndex = 18;
            BtnItem.Text = "AGREGAR ITEM";
            BtnItem.UseVisualStyleBackColor = false;
            BtnItem.Click += ClickBtnAgregarItem;
            // 
            // groupBoxMontosPagar
            // 
            groupBoxMontosPagar.Controls.Add(label2);
            groupBoxMontosPagar.Controls.Add(label1);
            groupBoxMontosPagar.Controls.Add(valorPagarNegro);
            groupBoxMontosPagar.Controls.Add(valorPagarBlanco);
            groupBoxMontosPagar.Font = new Font("Consolas", 13F, FontStyle.Bold);
            groupBoxMontosPagar.Location = new Point(682, 681);
            groupBoxMontosPagar.Name = "groupBoxMontosPagar";
            groupBoxMontosPagar.Size = new Size(633, 112);
            groupBoxMontosPagar.TabIndex = 19;
            groupBoxMontosPagar.TabStop = false;
            groupBoxMontosPagar.Text = "Pagar al empleado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(237, 64);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 3;
            label2.Text = "INTERNO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(52, 64);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 2;
            label1.Text = "OFICIAL";
            // 
            // valorPagarNegro
            // 
            valorPagarNegro.AutoSize = true;
            valorPagarNegro.Font = new Font("Consolas", 14F, FontStyle.Bold);
            valorPagarNegro.ForeColor = SystemColors.Highlight;
            valorPagarNegro.Location = new Point(217, 34);
            valorPagarNegro.Name = "valorPagarNegro";
            valorPagarNegro.Size = new Size(120, 22);
            valorPagarNegro.TabIndex = 1;
            valorPagarNegro.Text = "$ 2.000.000";
            // 
            // valorPagarBlanco
            // 
            valorPagarBlanco.AutoSize = true;
            valorPagarBlanco.Font = new Font("Consolas", 14F, FontStyle.Bold);
            valorPagarBlanco.ForeColor = Color.SeaGreen;
            valorPagarBlanco.Location = new Point(32, 34);
            valorPagarBlanco.Name = "valorPagarBlanco";
            valorPagarBlanco.Size = new Size(120, 22);
            valorPagarBlanco.TabIndex = 0;
            valorPagarBlanco.Text = "$ 8.000.000";
            // 
            // labelSubTotalRemunerativo
            // 
            labelSubTotalRemunerativo.AutoSize = true;
            labelSubTotalRemunerativo.Dock = DockStyle.Right;
            labelSubTotalRemunerativo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelSubTotalRemunerativo.Location = new Point(56, 19);
            labelSubTotalRemunerativo.Name = "labelSubTotalRemunerativo";
            labelSubTotalRemunerativo.Size = new Size(105, 14);
            labelSubTotalRemunerativo.TabIndex = 21;
            labelSubTotalRemunerativo.Text = "$ 1.000.000,00";
            labelSubTotalRemunerativo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSubTotalRemunerativo);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(314, 428);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 42);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Subtotal Remunerativo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelSubtotalDescuentosOficial);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(496, 428);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 42);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Subtotal Descuentos:";
            // 
            // labelSubtotalDescuentosOficial
            // 
            labelSubtotalDescuentosOficial.AutoSize = true;
            labelSubtotalDescuentosOficial.Dock = DockStyle.Right;
            labelSubtotalDescuentosOficial.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelSubtotalDescuentosOficial.Location = new Point(56, 19);
            labelSubtotalDescuentosOficial.Name = "labelSubtotalDescuentosOficial";
            labelSubtotalDescuentosOficial.Size = new Size(105, 14);
            labelSubtotalDescuentosOficial.TabIndex = 21;
            labelSubtotalDescuentosOficial.Text = "$ 1.000.000,00";
            labelSubtotalDescuentosOficial.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(labelSubTotalNoRemunerativo);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(682, 428);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(179, 42);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Subtotal No Remunerativo:";
            // 
            // labelSubTotalNoRemunerativo
            // 
            labelSubTotalNoRemunerativo.AutoSize = true;
            labelSubTotalNoRemunerativo.Dock = DockStyle.Right;
            labelSubTotalNoRemunerativo.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelSubTotalNoRemunerativo.Location = new Point(71, 19);
            labelSubTotalNoRemunerativo.Name = "labelSubTotalNoRemunerativo";
            labelSubTotalNoRemunerativo.Size = new Size(105, 14);
            labelSubTotalNoRemunerativo.TabIndex = 21;
            labelSubTotalNoRemunerativo.Text = "$ 1.000.000,00";
            labelSubTotalNoRemunerativo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(labelSubtotalRemunerativoInterno);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox4.Location = new Point(314, 681);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(164, 42);
            groupBox4.TabIndex = 25;
            groupBox4.TabStop = false;
            groupBox4.Text = "Subtotal Remunerativo:";
            // 
            // labelSubtotalRemunerativoInterno
            // 
            labelSubtotalRemunerativoInterno.AutoSize = true;
            labelSubtotalRemunerativoInterno.Dock = DockStyle.Right;
            labelSubtotalRemunerativoInterno.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelSubtotalRemunerativoInterno.Location = new Point(56, 19);
            labelSubtotalRemunerativoInterno.Name = "labelSubtotalRemunerativoInterno";
            labelSubtotalRemunerativoInterno.Size = new Size(105, 14);
            labelSubtotalRemunerativoInterno.TabIndex = 21;
            labelSubtotalRemunerativoInterno.Text = "$ 1.000.000,00";
            labelSubtotalRemunerativoInterno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelSubTotalDescuentosInterno);
            groupBox5.FlatStyle = FlatStyle.Flat;
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox5.Location = new Point(498, 681);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(164, 42);
            groupBox5.TabIndex = 26;
            groupBox5.TabStop = false;
            groupBox5.Text = "Subtotal Descuentos:";
            // 
            // labelSubTotalDescuentosInterno
            // 
            labelSubTotalDescuentosInterno.AutoSize = true;
            labelSubTotalDescuentosInterno.Dock = DockStyle.Right;
            labelSubTotalDescuentosInterno.Font = new Font("Consolas", 9F, FontStyle.Bold);
            labelSubTotalDescuentosInterno.Location = new Point(56, 19);
            labelSubTotalDescuentosInterno.Name = "labelSubTotalDescuentosInterno";
            labelSubTotalDescuentosInterno.Size = new Size(105, 14);
            labelSubTotalDescuentosInterno.TabIndex = 21;
            labelSubTotalDescuentosInterno.Text = "$ 1.000.000,00";
            labelSubTotalDescuentosInterno.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CrearLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 821);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
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
        private Label valorPagarBlanco;
        private Label label1;
        private Label valorPagarNegro;
        private Label label2;
        private TextBox textBoxPeriodo;
        private Label label3;
        private Label label4;
        private TextBox textBoxEmpleado;
        private Label labelSubTotalRemunerativo;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelSubtotalDescuentosOficial;
        private GroupBox groupBox3;
        private Label labelSubTotalNoRemunerativo;
        private GroupBox groupBox4;
        private Label labelSubtotalRemunerativoInterno;
        private GroupBox groupBox5;
        private Label labelSubTotalDescuentosInterno;
    }
}
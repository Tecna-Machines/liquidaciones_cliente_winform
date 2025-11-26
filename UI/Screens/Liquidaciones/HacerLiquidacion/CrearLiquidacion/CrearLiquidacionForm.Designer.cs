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
            listaEmpComponent1 = new UI.Components.Utils.ListaEmpComponent();
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
            listaSueldoBillete = new ListView();
            columDescrip = new ColumnHeader();
            columnRemu = new ColumnHeader();
            columnDescuento = new ColumnHeader();
            columFecha = new ColumnHeader();
            labelaAcuerdo = new Label();
            tablaAcuerdo = new ListView();
            columnItem = new ColumnHeader();
            columValor = new ColumnHeader();
            BtnRecalcular = new Button();
            btnSellar = new Button();
            btnMarcas = new Button();
            btnItem = new Button();
            groupBoxMontosPagar = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            valorPagarNegro = new Label();
            valorPagarBlanco = new Label();
            panelDatos.SuspendLayout();
            groupBoxMontosPagar.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(12, 12);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.ServiceProvider = null;
            listaEmpComponent1.Size = new Size(314, 682);
            listaEmpComponent1.TabIndex = 0;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(textBoxEmpleado);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(textBoxPeriodo);
            panelDatos.Location = new Point(314, 42);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(1001, 109);
            panelDatos.TabIndex = 1;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            textBoxEmpleado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            textBoxPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
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
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(314, 221);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 3;
            labelRemuneraciones.Text = " Detalle en blanco";
            // 
            // labelRetenciones
            // 
            labelRetenciones.BackColor = SystemColors.ActiveCaption;
            labelRetenciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRetenciones.Location = new Point(314, 484);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 4;
            labelRetenciones.Text = "Detalle ";
            // 
            // tablaDetalleEnBlanco
            // 
            tablaDetalleEnBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnDesc, columnRemunerativo, columnNORemu, columnFecha });
            tablaDetalleEnBlanco.FullRowSelect = true;
            tablaDetalleEnBlanco.GridLines = true;
            tablaDetalleEnBlanco.Location = new Point(314, 248);
            tablaDetalleEnBlanco.Name = "tablaDetalleEnBlanco";
            tablaDetalleEnBlanco.Size = new Size(670, 219);
            tablaDetalleEnBlanco.TabIndex = 6;
            tablaDetalleEnBlanco.UseCompatibleStateImageBehavior = false;
            tablaDetalleEnBlanco.View = View.Details;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Conceptos";
            columnDescripcion.Width = 180;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descuentos";
            columnDesc.Width = 90;
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.Text = "Remuneraciones";
            columnRemunerativo.Width = 95;
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
            // listaSueldoBillete
            // 
            listaSueldoBillete.Columns.AddRange(new ColumnHeader[] { columDescrip, columnRemu, columnDescuento, columFecha });
            listaSueldoBillete.FullRowSelect = true;
            listaSueldoBillete.GridLines = true;
            listaSueldoBillete.Location = new Point(314, 511);
            listaSueldoBillete.Name = "listaSueldoBillete";
            listaSueldoBillete.Size = new Size(667, 173);
            listaSueldoBillete.TabIndex = 7;
            listaSueldoBillete.UseCompatibleStateImageBehavior = false;
            listaSueldoBillete.View = View.Details;
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
            labelaAcuerdo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelaAcuerdo.Location = new Point(997, 221);
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
            tablaAcuerdo.Location = new Point(997, 248);
            tablaAcuerdo.Name = "tablaAcuerdo";
            tablaAcuerdo.Scrollable = false;
            tablaAcuerdo.Size = new Size(318, 436);
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
            BtnRecalcular.BackColor = SystemColors.GradientActiveCaption;
            BtnRecalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRecalcular.Location = new Point(751, 157);
            BtnRecalcular.Name = "BtnRecalcular";
            BtnRecalcular.Size = new Size(109, 41);
            BtnRecalcular.TabIndex = 10;
            BtnRecalcular.Text = "RECALCULAR";
            BtnRecalcular.UseVisualStyleBackColor = false;
            BtnRecalcular.Click += BtnRecalcular_Click;
            // 
            // btnSellar
            // 
            btnSellar.BackColor = Color.Gold;
            btnSellar.BackgroundImageLayout = ImageLayout.None;
            btnSellar.Cursor = Cursors.Hand;
            btnSellar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSellar.Location = new Point(872, 157);
            btnSellar.Name = "btnSellar";
            btnSellar.Size = new Size(109, 41);
            btnSellar.TabIndex = 11;
            btnSellar.Text = "SELLAR";
            btnSellar.UseVisualStyleBackColor = false;
            btnSellar.Click += ClickBtnConfirmarLiquidacion;
            // 
            // btnMarcas
            // 
            btnMarcas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnMarcas.Location = new Point(431, 157);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(149, 41);
            btnMarcas.TabIndex = 17;
            btnMarcas.Text = "CONSULTAR ASISTENCIAS";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += ClickBtnMarcas;
            // 
            // btnItem
            // 
            btnItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnItem.Location = new Point(592, 157);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(147, 41);
            btnItem.TabIndex = 18;
            btnItem.Text = "AGREGAR ITEM";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += ClickBtnAgregarItem;
            // 
            // groupBoxMontosPagar
            // 
            groupBoxMontosPagar.Controls.Add(label2);
            groupBoxMontosPagar.Controls.Add(label1);
            groupBoxMontosPagar.Controls.Add(valorPagarNegro);
            groupBoxMontosPagar.Controls.Add(valorPagarBlanco);
            groupBoxMontosPagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxMontosPagar.Location = new Point(314, 690);
            groupBoxMontosPagar.Name = "groupBoxMontosPagar";
            groupBoxMontosPagar.Size = new Size(328, 112);
            groupBoxMontosPagar.TabIndex = 19;
            groupBoxMontosPagar.TabStop = false;
            groupBoxMontosPagar.Text = "Pago neto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(195, 64);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 3;
            label2.Text = "EN NEGRO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(36, 64);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 2;
            label1.Text = "EN BLANCO";
            // 
            // valorPagarNegro
            // 
            valorPagarNegro.AutoSize = true;
            valorPagarNegro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            valorPagarNegro.ForeColor = Color.Tomato;
            valorPagarNegro.Location = new Point(178, 34);
            valorPagarNegro.Name = "valorPagarNegro";
            valorPagarNegro.Size = new Size(124, 28);
            valorPagarNegro.TabIndex = 1;
            valorPagarNegro.Text = "$ 2.000.000";
            // 
            // valorPagarBlanco
            // 
            valorPagarBlanco.AutoSize = true;
            valorPagarBlanco.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            valorPagarBlanco.ForeColor = Color.SeaGreen;
            valorPagarBlanco.Location = new Point(24, 34);
            valorPagarBlanco.Name = "valorPagarBlanco";
            valorPagarBlanco.Size = new Size(124, 28);
            valorPagarBlanco.TabIndex = 0;
            valorPagarBlanco.Text = "$ 8.000.000";
            // 
            // CrearLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 821);
            Controls.Add(groupBoxMontosPagar);
            Controls.Add(btnItem);
            Controls.Add(btnMarcas);
            Controls.Add(btnSellar);
            Controls.Add(BtnRecalcular);
            Controls.Add(tablaAcuerdo);
            Controls.Add(labelaAcuerdo);
            Controls.Add(listaSueldoBillete);
            Controls.Add(tablaDetalleEnBlanco);
            Controls.Add(labelRetenciones);
            Controls.Add(labelRemuneraciones);
            Controls.Add(panelDatos);
            Controls.Add(listaEmpComponent1);
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

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private Panel panelDatos;
        private Label labelDescuentos;
        private Label labelRemuneraciones;
        private Label labelRetenciones;
        private ListView tablaDetalleEnBlanco;
        private Label labelNoRemuneraciones;
        private ListView tablaAcuerdo;
        private ListView listaSueldoBillete;
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
        private Button btnSellar;
        private Button btnMarcas;
        private Button btnItem;
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
    }
}
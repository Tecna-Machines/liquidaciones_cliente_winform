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
            panel1 = new Panel();
            labelQuincena = new Label();
            labelPeriodo = new Label();
            nombreLabel = new Label();
            dniLabel = new Label();
            labelRemuneraciones = new Label();
            labelRetenciones = new Label();
            listaSueldoBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnFecha = new ColumnHeader();
            listaSueldoBillete = new ListView();
            columDescrip = new ColumnHeader();
            columFecha = new ColumnHeader();
            labelaAcuerdo = new Label();
            listContrato = new ListView();
            columnItem = new ColumnHeader();
            columValor = new ColumnHeader();
            btnRecalcularRetenciones = new Button();
            btnSellar = new Button();
            btnMarcas = new Button();
            btnItem = new Button();
            columnRemu = new ColumnHeader();
            columnDescuento = new ColumnHeader();
            groupBoxMontosPagar = new GroupBox();
            valorPagarBlanco = new Label();
            valorPagarNegro = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(labelQuincena);
            panel1.Controls.Add(labelPeriodo);
            panel1.Controls.Add(nombreLabel);
            panel1.Controls.Add(dniLabel);
            panel1.Location = new Point(314, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 100);
            panel1.TabIndex = 1;
            // 
            // labelQuincena
            // 
            labelQuincena.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuincena.Location = new Point(201, 0);
            labelQuincena.Name = "labelQuincena";
            labelQuincena.Size = new Size(283, 38);
            labelQuincena.TabIndex = 3;
            labelQuincena.Text = "[QUINCENA]";
            // 
            // labelPeriodo
            // 
            labelPeriodo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPeriodo.Location = new Point(530, 0);
            labelPeriodo.Name = "labelPeriodo";
            labelPeriodo.Size = new Size(433, 38);
            labelPeriodo.TabIndex = 2;
            labelPeriodo.Text = "<error de periodo>";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nombreLabel.Location = new Point(3, 52);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new Size(133, 21);
            nombreLabel.TabIndex = 1;
            nombreLabel.Text = "<sin seleccionar>";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            dniLabel.Location = new Point(3, 10);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new Size(165, 28);
            dniLabel.TabIndex = 0;
            dniLabel.Text = "<sin seleccionar>";
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
            // listaSueldoBlanco
            // 
            listaSueldoBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnRemunerativo, columnNORemu, columnDesc, columnFecha });
            listaSueldoBlanco.FullRowSelect = true;
            listaSueldoBlanco.GridLines = true;
            listaSueldoBlanco.Location = new Point(314, 248);
            listaSueldoBlanco.Name = "listaSueldoBlanco";
            listaSueldoBlanco.Size = new Size(670, 219);
            listaSueldoBlanco.TabIndex = 6;
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
            columDescrip.Width = 350;
            // 
            // columFecha
            // 
            columFecha.DisplayIndex = 1;
            columFecha.Text = "Fecha";
            columFecha.Width = 90;
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
            // listContrato
            // 
            listContrato.Columns.AddRange(new ColumnHeader[] { columnItem, columValor });
            listContrato.FullRowSelect = true;
            listContrato.GridLines = true;
            listContrato.Location = new Point(997, 248);
            listContrato.Name = "listContrato";
            listContrato.Scrollable = false;
            listContrato.Size = new Size(318, 436);
            listContrato.TabIndex = 9;
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
            // btnRecalcularRetenciones
            // 
            btnRecalcularRetenciones.BackColor = SystemColors.GradientActiveCaption;
            btnRecalcularRetenciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRecalcularRetenciones.Location = new Point(751, 157);
            btnRecalcularRetenciones.Name = "btnRecalcularRetenciones";
            btnRecalcularRetenciones.Size = new Size(109, 41);
            btnRecalcularRetenciones.TabIndex = 10;
            btnRecalcularRetenciones.Text = "RECALCULAR";
            btnRecalcularRetenciones.UseVisualStyleBackColor = false;
            btnRecalcularRetenciones.Click += ClickBtnPreLiquidar;
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
            // CrearLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 821);
            Controls.Add(groupBoxMontosPagar);
            Controls.Add(btnItem);
            Controls.Add(btnMarcas);
            Controls.Add(btnSellar);
            Controls.Add(btnRecalcularRetenciones);
            Controls.Add(listContrato);
            Controls.Add(labelaAcuerdo);
            Controls.Add(listaSueldoBillete);
            Controls.Add(listaSueldoBlanco);
            Controls.Add(labelRetenciones);
            Controls.Add(labelRemuneraciones);
            Controls.Add(panel1);
            Controls.Add(listaEmpComponent1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearLiquidacionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearLiquidacion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBoxMontosPagar.ResumeLayout(false);
            groupBoxMontosPagar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private Panel panel1;
        private Label dniLabel;
        private Label nombreLabel;
        private Label labelDescuentos;
        private Label labelRemuneraciones;
        private Label labelRetenciones;
        private ListView listaSueldoBlanco;
        private Label labelNoRemuneraciones;
        private ListView listContrato;
        private ListView listaSueldoBillete;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnRemunerativo;
        private ColumnHeader columnNORemu;
        private Label labelPeriodo;
        private ListView listView3;
        private ColumnHeader columnFecha;
        private ColumnHeader columnDesc;
        private ColumnHeader columDescrip;
        private ColumnHeader columFecha;
        private Label labelaAcuerdo;
        private ColumnHeader columnItem;
        private ColumnHeader columValor;
        private Button btnRecalcularRetenciones;
        private Button btnSellar;
        private Button btnMarcas;
        private Button btnItem;
        private Label labelQuincena;
        private ColumnHeader columnRemu;
        private ColumnHeader columnDescuento;
        private GroupBox groupBoxMontosPagar;
        private Label valorPagarBlanco;
        private Label label1;
        private Label valorPagarNegro;
        private Label label2;
    }
}
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "EN EL BANCO" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point));
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "EN EL SOBRE" }, -1, Color.Empty, Color.Empty, new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearLiquidacionForm));
            listaEmpComponent1 = new Components.Utils.ListaEmpComponent();
            panel1 = new Panel();
            labelQuincena = new Label();
            labelPeriodo = new Label();
            nombreLabel = new Label();
            dniLabel = new Label();
            labelRemuneraciones = new Label();
            labelRetenciones = new Label();
            listaSueldoBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnFecha = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnDesc = new ColumnHeader();
            listaSueldoBillete = new ListView();
            columDescrip = new ColumnHeader();
            columFecha = new ColumnHeader();
            columMonto = new ColumnHeader();
            labelaAcuerdo = new Label();
            listContrato = new ListView();
            columnNumero = new ColumnHeader();
            columSueldo = new ColumnHeader();
            columMontoHora = new ColumnHeader();
            columModalidad = new ColumnHeader();
            columnBlanco = new ColumnHeader();
            btnPreLiquidar = new Button();
            btnLiquidarCompleta = new Button();
            labelSubtotales = new Label();
            listaSubtotales = new ListView();
            columnTipo = new ColumnHeader();
            columnMonto = new ColumnHeader();
            labelPagarEmpleado = new Label();
            listaPagarEmpleado = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            btnMarcas = new Button();
            btnItem = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(12, 12);
            listaEmpComponent1.Name = "listaEmpComponent1";
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
            labelRemuneraciones.BackColor = Color.LightGreen;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(314, 231);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 3;
            labelRemuneraciones.Text = "DETALLE DE SUELDO (blanco)";
            // 
            // labelRetenciones
            // 
            labelRetenciones.BackColor = Color.Tomato;
            labelRetenciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRetenciones.Location = new Point(314, 494);
            labelRetenciones.Name = "labelRetenciones";
            labelRetenciones.Padding = new Padding(3);
            labelRetenciones.Size = new Size(667, 24);
            labelRetenciones.TabIndex = 4;
            labelRetenciones.Text = "Detalle de sueldo (billete)";
            // 
            // listaSueldoBlanco
            // 
            listaSueldoBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnFecha, columnRemunerativo, columnNORemu, columnDesc });
            listaSueldoBlanco.FullRowSelect = true;
            listaSueldoBlanco.GridLines = true;
            listaSueldoBlanco.Location = new Point(314, 258);
            listaSueldoBlanco.Name = "listaSueldoBlanco";
            listaSueldoBlanco.Size = new Size(670, 219);
            listaSueldoBlanco.TabIndex = 6;
            listaSueldoBlanco.UseCompatibleStateImageBehavior = false;
            listaSueldoBlanco.View = View.Details;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Descripcion";
            columnDescripcion.Width = 180;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.Text = "Remunerativo";
            columnRemunerativo.Width = 95;
            // 
            // columnNORemu
            // 
            columnNORemu.Text = "No Remunerativo";
            columnNORemu.Width = 120;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descuento";
            columnDesc.Width = 90;
            // 
            // listaSueldoBillete
            // 
            listaSueldoBillete.Columns.AddRange(new ColumnHeader[] { columDescrip, columFecha, columMonto });
            listaSueldoBillete.FullRowSelect = true;
            listaSueldoBillete.GridLines = true;
            listaSueldoBillete.Location = new Point(314, 521);
            listaSueldoBillete.Name = "listaSueldoBillete";
            listaSueldoBillete.Size = new Size(667, 173);
            listaSueldoBillete.TabIndex = 7;
            listaSueldoBillete.UseCompatibleStateImageBehavior = false;
            listaSueldoBillete.View = View.Details;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Descripcion";
            columDescrip.Width = 350;
            // 
            // columFecha
            // 
            columFecha.Text = "Fecha";
            columFecha.Width = 90;
            // 
            // columMonto
            // 
            columMonto.Text = "Monto";
            columMonto.Width = 87;
            // 
            // labelaAcuerdo
            // 
            labelaAcuerdo.BackColor = Color.LightSkyBlue;
            labelaAcuerdo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelaAcuerdo.Location = new Point(314, 130);
            labelaAcuerdo.Name = "labelaAcuerdo";
            labelaAcuerdo.Padding = new Padding(3);
            labelaAcuerdo.Size = new Size(670, 24);
            labelaAcuerdo.TabIndex = 8;
            labelaAcuerdo.Text = "Acuerdo actual";
            // 
            // listContrato
            // 
            listContrato.Columns.AddRange(new ColumnHeader[] { columnNumero, columSueldo, columMontoHora, columModalidad, columnBlanco });
            listContrato.FullRowSelect = true;
            listContrato.GridLines = true;
            listContrato.Location = new Point(314, 157);
            listContrato.Name = "listContrato";
            listContrato.Scrollable = false;
            listContrato.Size = new Size(670, 55);
            listContrato.TabIndex = 9;
            listContrato.UseCompatibleStateImageBehavior = false;
            listContrato.View = View.Details;
            // 
            // columnNumero
            // 
            columnNumero.Text = "N° de acuerdo";
            columnNumero.Width = 130;
            // 
            // columSueldo
            // 
            columSueldo.Text = "Monto bruto total";
            columSueldo.Width = 130;
            // 
            // columMontoHora
            // 
            columMontoHora.Text = "Monto por hora";
            columMontoHora.Width = 120;
            // 
            // columModalidad
            // 
            columModalidad.Text = "Modalidad";
            columModalidad.Width = 120;
            // 
            // columnBlanco
            // 
            columnBlanco.Text = "Parte blanca";
            columnBlanco.Width = 90;
            // 
            // btnPreLiquidar
            // 
            btnPreLiquidar.BackColor = Color.LightSalmon;
            btnPreLiquidar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreLiquidar.Location = new Point(1015, 171);
            btnPreLiquidar.Name = "btnPreLiquidar";
            btnPreLiquidar.Size = new Size(109, 41);
            btnPreLiquidar.TabIndex = 10;
            btnPreLiquidar.Text = "SIMULAR";
            btnPreLiquidar.UseVisualStyleBackColor = false;
            btnPreLiquidar.Click += ClickBtnPreLiquidar;
            // 
            // btnLiquidarCompleta
            // 
            btnLiquidarCompleta.BackColor = Color.SpringGreen;
            btnLiquidarCompleta.BackgroundImageLayout = ImageLayout.None;
            btnLiquidarCompleta.Cursor = Cursors.Hand;
            btnLiquidarCompleta.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLiquidarCompleta.Location = new Point(1015, 124);
            btnLiquidarCompleta.Name = "btnLiquidarCompleta";
            btnLiquidarCompleta.Size = new Size(109, 41);
            btnLiquidarCompleta.TabIndex = 11;
            btnLiquidarCompleta.Text = "CONFIRMAR";
            btnLiquidarCompleta.UseVisualStyleBackColor = false;
            btnLiquidarCompleta.Click += ClickBtnConfirmarLiquidacion;
            // 
            // labelSubtotales
            // 
            labelSubtotales.BackColor = Color.SlateBlue;
            labelSubtotales.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubtotales.Location = new Point(1006, 231);
            labelSubtotales.Name = "labelSubtotales";
            labelSubtotales.Padding = new Padding(3);
            labelSubtotales.Size = new Size(271, 24);
            labelSubtotales.TabIndex = 12;
            labelSubtotales.Text = "Subtotales";
            // 
            // listaSubtotales
            // 
            listaSubtotales.Columns.AddRange(new ColumnHeader[] { columnTipo, columnMonto });
            listaSubtotales.FullRowSelect = true;
            listaSubtotales.GridLines = true;
            listaSubtotales.Location = new Point(1006, 258);
            listaSubtotales.Name = "listaSubtotales";
            listaSubtotales.Size = new Size(271, 219);
            listaSubtotales.TabIndex = 13;
            listaSubtotales.UseCompatibleStateImageBehavior = false;
            listaSubtotales.View = View.Details;
            // 
            // columnTipo
            // 
            columnTipo.Text = "TIPO";
            columnTipo.Width = 100;
            // 
            // columnMonto
            // 
            columnMonto.Text = "MONTO";
            columnMonto.Width = 100;
            // 
            // labelPagarEmpleado
            // 
            labelPagarEmpleado.BackColor = Color.LightGoldenrodYellow;
            labelPagarEmpleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPagarEmpleado.Location = new Point(1006, 494);
            labelPagarEmpleado.Name = "labelPagarEmpleado";
            labelPagarEmpleado.Padding = new Padding(3);
            labelPagarEmpleado.Size = new Size(271, 24);
            labelPagarEmpleado.TabIndex = 14;
            labelPagarEmpleado.Text = "Pagar a empleado";
            // 
            // listaPagarEmpleado
            // 
            listaPagarEmpleado.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listaPagarEmpleado.FullRowSelect = true;
            listaPagarEmpleado.GridLines = true;
            listaPagarEmpleado.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
            listaPagarEmpleado.Location = new Point(1006, 521);
            listaPagarEmpleado.Name = "listaPagarEmpleado";
            listaPagarEmpleado.Size = new Size(271, 68);
            listaPagarEmpleado.TabIndex = 15;
            listaPagarEmpleado.UseCompatibleStateImageBehavior = false;
            listaPagarEmpleado.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "TIPO";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "MONTO";
            columnHeader2.Width = 100;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(1130, 171);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(147, 41);
            btnMarcas.TabIndex = 17;
            btnMarcas.Text = "Ver marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += ClickBtnMarcas;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(1130, 124);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(147, 41);
            btnItem.TabIndex = 18;
            btnItem.Text = "Agregar item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += ClickBtnAgregarItem;
            // 
            // CrearLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 706);
            Controls.Add(btnItem);
            Controls.Add(btnMarcas);
            Controls.Add(listaPagarEmpleado);
            Controls.Add(labelPagarEmpleado);
            Controls.Add(listaSubtotales);
            Controls.Add(labelSubtotales);
            Controls.Add(btnLiquidarCompleta);
            Controls.Add(btnPreLiquidar);
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
        private ColumnHeader columMonto;
        private Label labelaAcuerdo;
        private ColumnHeader columnNumero;
        private ColumnHeader columSueldo;
        private ColumnHeader columMontoHora;
        private ColumnHeader columModalidad;
        private Button btnPreLiquidar;
        private Button btnLiquidarCompleta;
        private Label labelSubtotales;
        private ListView listaSubtotales;
        private ColumnHeader columnTipo;
        private ColumnHeader columnMonto;
        private Label labelPagarEmpleado;
        private ListView listaPagarEmpleado;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button btnMarcas;
        private Button btnItem;
        private ColumnHeader columnBlanco;
        private Label labelQuincena;
    }
}
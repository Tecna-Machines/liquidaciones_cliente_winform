namespace UI.Screens.VerContratos
{
    partial class VerAcuerdosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAcuerdosForm));
            listaEmpleados = new UI.Components.Utils.ListaEmpComponent();
            listHistorial = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            tableLayoutPanelAcuerdo = new TableLayoutPanel();
            label1 = new Label();
            label47 = new Label();
            label46 = new Label();
            DataLbNotas = new Label();
            label44 = new Label();
            DataLbTipoSueldo = new Label();
            label42 = new Label();
            DataLbCodSueldo = new Label();
            label40 = new Label();
            DataLbJornal = new Label();
            label38 = new Label();
            DataLbSueldo = new Label();
            label36 = new Label();
            DataLbValorHora = new Label();
            label34 = new Label();
            DataLbFechaCreacionAcuerdo = new Label();
            label32 = new Label();
            DataLbCodAcuerdo = new Label();
            label30 = new Label();
            label29 = new Label();
            DataLbApellido = new Label();
            label27 = new Label();
            DataLbNombre = new Label();
            label25 = new Label();
            DataLbCuil = new Label();
            label23 = new Label();
            DataLbDni = new Label();
            label21 = new Label();
            label16 = new Label();
            listRetenciones = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listAdicionales = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            tableLayoutPanelAcuerdo.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpleados
            // 
            listaEmpleados.Dock = DockStyle.Left;
            listaEmpleados.Location = new Point(0, 0);
            listaEmpleados.Name = "listaEmpleados";
            listaEmpleados.ServiceProvider = null;
            listaEmpleados.Size = new Size(301, 685);
            listaEmpleados.TabIndex = 5;
            // 
            // listHistorial
            // 
            listHistorial.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            tableLayoutPanelAcuerdo.SetColumnSpan(listHistorial, 2);
            listHistorial.Dock = DockStyle.Fill;
            listHistorial.FullRowSelect = true;
            listHistorial.GridLines = true;
            listHistorial.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listHistorial.Location = new Point(3, 564);
            listHistorial.MultiSelect = false;
            listHistorial.Name = "listHistorial";
            listHistorial.Size = new Size(824, 118);
            listHistorial.TabIndex = 0;
            listHistorial.UseCompatibleStateImageBehavior = false;
            listHistorial.View = View.Details;
            listHistorial.SelectedIndexChanged += Select_AcuerdoDeHistorial;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Codigo";
            columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Valor hora";
            columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Sueldo";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Fecha Creacion";
            columnHeader10.Width = 180;
            // 
            // tableLayoutPanelAcuerdo
            // 
            tableLayoutPanelAcuerdo.BackColor = SystemColors.ButtonHighlight;
            tableLayoutPanelAcuerdo.ColumnCount = 2;
            tableLayoutPanelAcuerdo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.518074F));
            tableLayoutPanelAcuerdo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.481926F));
            tableLayoutPanelAcuerdo.Controls.Add(listHistorial, 0, 19);
            tableLayoutPanelAcuerdo.Controls.Add(label1, 0, 18);
            tableLayoutPanelAcuerdo.Controls.Add(label47, 0, 16);
            tableLayoutPanelAcuerdo.Controls.Add(label46, 0, 14);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbNotas, 1, 13);
            tableLayoutPanelAcuerdo.Controls.Add(label44, 0, 13);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbTipoSueldo, 1, 12);
            tableLayoutPanelAcuerdo.Controls.Add(label42, 0, 12);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbCodSueldo, 1, 11);
            tableLayoutPanelAcuerdo.Controls.Add(label40, 0, 11);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbJornal, 1, 10);
            tableLayoutPanelAcuerdo.Controls.Add(label38, 0, 10);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbSueldo, 1, 9);
            tableLayoutPanelAcuerdo.Controls.Add(label36, 0, 9);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbValorHora, 1, 8);
            tableLayoutPanelAcuerdo.Controls.Add(label34, 0, 8);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbFechaCreacionAcuerdo, 1, 7);
            tableLayoutPanelAcuerdo.Controls.Add(label32, 0, 7);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbCodAcuerdo, 1, 6);
            tableLayoutPanelAcuerdo.Controls.Add(label30, 0, 6);
            tableLayoutPanelAcuerdo.Controls.Add(label29, 0, 5);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbApellido, 1, 4);
            tableLayoutPanelAcuerdo.Controls.Add(label27, 0, 4);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbNombre, 1, 3);
            tableLayoutPanelAcuerdo.Controls.Add(label25, 0, 3);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbCuil, 1, 2);
            tableLayoutPanelAcuerdo.Controls.Add(label23, 0, 2);
            tableLayoutPanelAcuerdo.Controls.Add(DataLbDni, 1, 1);
            tableLayoutPanelAcuerdo.Controls.Add(label21, 0, 1);
            tableLayoutPanelAcuerdo.Controls.Add(label16, 0, 0);
            tableLayoutPanelAcuerdo.Controls.Add(listRetenciones, 0, 15);
            tableLayoutPanelAcuerdo.Controls.Add(listAdicionales, 0, 17);
            tableLayoutPanelAcuerdo.Dock = DockStyle.Fill;
            tableLayoutPanelAcuerdo.Location = new Point(301, 0);
            tableLayoutPanelAcuerdo.Margin = new Padding(10);
            tableLayoutPanelAcuerdo.Name = "tableLayoutPanelAcuerdo";
            tableLayoutPanelAcuerdo.RowCount = 20;
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle(SizeType.Absolute, 185F));
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle(SizeType.Absolute, 91F));
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle());
            tableLayoutPanelAcuerdo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanelAcuerdo.Size = new Size(830, 685);
            tableLayoutPanelAcuerdo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            tableLayoutPanelAcuerdo.SetColumnSpan(label1, 2);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 540);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(830, 21);
            label1.TabIndex = 34;
            label1.Text = "Historial";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.BackColor = SystemColors.HotTrack;
            tableLayoutPanelAcuerdo.SetColumnSpan(label47, 2);
            label47.Dock = DockStyle.Fill;
            label47.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label47.ForeColor = SystemColors.ControlLightLight;
            label47.Location = new Point(0, 428);
            label47.Margin = new Padding(0);
            label47.Name = "label47";
            label47.Size = new Size(830, 21);
            label47.TabIndex = 32;
            label47.Text = "Adicionales";
            label47.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = SystemColors.HotTrack;
            tableLayoutPanelAcuerdo.SetColumnSpan(label46, 2);
            label46.Dock = DockStyle.Fill;
            label46.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label46.ForeColor = SystemColors.ControlLightLight;
            label46.Location = new Point(0, 222);
            label46.Margin = new Padding(0);
            label46.Name = "label46";
            label46.Size = new Size(830, 21);
            label46.TabIndex = 30;
            label46.Text = "Retenciones";
            label46.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataLbNotas
            // 
            DataLbNotas.AutoSize = true;
            DataLbNotas.BackColor = SystemColors.ScrollBar;
            DataLbNotas.Dock = DockStyle.Fill;
            DataLbNotas.Location = new Point(411, 207);
            DataLbNotas.Margin = new Padding(0);
            DataLbNotas.Name = "DataLbNotas";
            DataLbNotas.Size = new Size(419, 15);
            DataLbNotas.TabIndex = 29;
            DataLbNotas.Text = "se pagan $2 por dia";
            DataLbNotas.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.BackColor = SystemColors.ScrollBar;
            label44.Dock = DockStyle.Fill;
            label44.Location = new Point(0, 207);
            label44.Margin = new Padding(0);
            label44.Name = "label44";
            label44.Size = new Size(411, 15);
            label44.TabIndex = 28;
            label44.Text = "Notas:";
            label44.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbTipoSueldo
            // 
            DataLbTipoSueldo.AutoSize = true;
            DataLbTipoSueldo.BackColor = SystemColors.ControlLightLight;
            DataLbTipoSueldo.Dock = DockStyle.Fill;
            DataLbTipoSueldo.Location = new Point(411, 192);
            DataLbTipoSueldo.Margin = new Padding(0);
            DataLbTipoSueldo.Name = "DataLbTipoSueldo";
            DataLbTipoSueldo.Size = new Size(419, 15);
            DataLbTipoSueldo.TabIndex = 27;
            DataLbTipoSueldo.Text = "Quincenal fijo";
            DataLbTipoSueldo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = SystemColors.ControlLightLight;
            label42.Dock = DockStyle.Fill;
            label42.Location = new Point(0, 192);
            label42.Margin = new Padding(0);
            label42.Name = "label42";
            label42.Size = new Size(411, 15);
            label42.TabIndex = 26;
            label42.Text = "Tipo de Sueldo:";
            label42.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbCodSueldo
            // 
            DataLbCodSueldo.AutoSize = true;
            DataLbCodSueldo.BackColor = SystemColors.ScrollBar;
            DataLbCodSueldo.Dock = DockStyle.Fill;
            DataLbCodSueldo.Location = new Point(411, 177);
            DataLbCodSueldo.Margin = new Padding(0);
            DataLbCodSueldo.Name = "DataLbCodSueldo";
            DataLbCodSueldo.Size = new Size(419, 15);
            DataLbCodSueldo.TabIndex = 25;
            DataLbCodSueldo.Text = "35";
            DataLbCodSueldo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.BackColor = SystemColors.ScrollBar;
            label40.Dock = DockStyle.Fill;
            label40.Location = new Point(0, 177);
            label40.Margin = new Padding(0);
            label40.Name = "label40";
            label40.Size = new Size(411, 15);
            label40.TabIndex = 24;
            label40.Text = "Cod. tipo de sueldo:";
            label40.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbJornal
            // 
            DataLbJornal.AutoSize = true;
            DataLbJornal.BackColor = SystemColors.ControlLightLight;
            DataLbJornal.Dock = DockStyle.Fill;
            DataLbJornal.Location = new Point(411, 162);
            DataLbJornal.Margin = new Padding(0);
            DataLbJornal.Name = "DataLbJornal";
            DataLbJornal.Size = new Size(419, 15);
            DataLbJornal.TabIndex = 22;
            DataLbJornal.Text = "$ 366.666";
            DataLbJornal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.BackColor = SystemColors.ControlLightLight;
            label38.Dock = DockStyle.Fill;
            label38.Location = new Point(0, 162);
            label38.Margin = new Padding(0);
            label38.Name = "label38";
            label38.Size = new Size(411, 15);
            label38.TabIndex = 21;
            label38.Text = "Sueldo/Jornal (oficial):";
            label38.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbSueldo
            // 
            DataLbSueldo.AutoSize = true;
            DataLbSueldo.BackColor = SystemColors.ScrollBar;
            DataLbSueldo.Dock = DockStyle.Fill;
            DataLbSueldo.Location = new Point(411, 147);
            DataLbSueldo.Margin = new Padding(0);
            DataLbSueldo.Name = "DataLbSueldo";
            DataLbSueldo.Size = new Size(419, 15);
            DataLbSueldo.TabIndex = 20;
            DataLbSueldo.Text = "$ 1.500.785";
            DataLbSueldo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.BackColor = SystemColors.ScrollBar;
            label36.Dock = DockStyle.Fill;
            label36.Location = new Point(0, 147);
            label36.Margin = new Padding(0);
            label36.Name = "label36";
            label36.Size = new Size(411, 15);
            label36.TabIndex = 19;
            label36.Text = "Sueldo:";
            label36.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbValorHora
            // 
            DataLbValorHora.AutoSize = true;
            DataLbValorHora.BackColor = SystemColors.ControlLightLight;
            DataLbValorHora.Dock = DockStyle.Fill;
            DataLbValorHora.Location = new Point(411, 132);
            DataLbValorHora.Margin = new Padding(0);
            DataLbValorHora.Name = "DataLbValorHora";
            DataLbValorHora.Size = new Size(419, 15);
            DataLbValorHora.TabIndex = 18;
            DataLbValorHora.Text = "$ 12.000";
            DataLbValorHora.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = SystemColors.ControlLightLight;
            label34.Dock = DockStyle.Fill;
            label34.Location = new Point(0, 132);
            label34.Margin = new Padding(0);
            label34.Name = "label34";
            label34.Size = new Size(411, 15);
            label34.TabIndex = 17;
            label34.Text = "Valor hora:";
            label34.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbFechaCreacionAcuerdo
            // 
            DataLbFechaCreacionAcuerdo.AutoSize = true;
            DataLbFechaCreacionAcuerdo.BackColor = SystemColors.ScrollBar;
            DataLbFechaCreacionAcuerdo.Dock = DockStyle.Fill;
            DataLbFechaCreacionAcuerdo.Location = new Point(411, 117);
            DataLbFechaCreacionAcuerdo.Margin = new Padding(0);
            DataLbFechaCreacionAcuerdo.Name = "DataLbFechaCreacionAcuerdo";
            DataLbFechaCreacionAcuerdo.Size = new Size(419, 15);
            DataLbFechaCreacionAcuerdo.TabIndex = 16;
            DataLbFechaCreacionAcuerdo.Text = "20/05/2099 15:45HS";
            DataLbFechaCreacionAcuerdo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.BackColor = SystemColors.ScrollBar;
            label32.Dock = DockStyle.Fill;
            label32.Location = new Point(0, 117);
            label32.Margin = new Padding(0);
            label32.Name = "label32";
            label32.Size = new Size(411, 15);
            label32.TabIndex = 15;
            label32.Text = "Fecha creacion:";
            label32.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbCodAcuerdo
            // 
            DataLbCodAcuerdo.AutoSize = true;
            DataLbCodAcuerdo.BackColor = SystemColors.ControlLightLight;
            DataLbCodAcuerdo.Dock = DockStyle.Fill;
            DataLbCodAcuerdo.ForeColor = SystemColors.ButtonHighlight;
            DataLbCodAcuerdo.Location = new Point(411, 102);
            DataLbCodAcuerdo.Margin = new Padding(0);
            DataLbCodAcuerdo.Name = "DataLbCodAcuerdo";
            DataLbCodAcuerdo.Size = new Size(419, 15);
            DataLbCodAcuerdo.TabIndex = 14;
            DataLbCodAcuerdo.Text = "458215421684";
            DataLbCodAcuerdo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.BackColor = SystemColors.ControlLightLight;
            label30.Dock = DockStyle.Fill;
            label30.Location = new Point(0, 102);
            label30.Margin = new Padding(0);
            label30.Name = "label30";
            label30.Size = new Size(411, 15);
            label30.TabIndex = 13;
            label30.Text = "Codigo:";
            label30.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.BackColor = SystemColors.HotTrack;
            tableLayoutPanelAcuerdo.SetColumnSpan(label29, 2);
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label29.ForeColor = SystemColors.ControlLightLight;
            label29.Location = new Point(0, 81);
            label29.Margin = new Padding(0);
            label29.Name = "label29";
            label29.Size = new Size(830, 21);
            label29.TabIndex = 12;
            label29.Text = "Datos Acuerdo";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DataLbApellido
            // 
            DataLbApellido.AutoSize = true;
            DataLbApellido.BackColor = SystemColors.ScrollBar;
            DataLbApellido.Dock = DockStyle.Fill;
            DataLbApellido.Location = new Point(411, 66);
            DataLbApellido.Margin = new Padding(0);
            DataLbApellido.Name = "DataLbApellido";
            DataLbApellido.Size = new Size(419, 15);
            DataLbApellido.TabIndex = 11;
            DataLbApellido.Text = "Apellido rrelargo";
            DataLbApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.BackColor = SystemColors.ScrollBar;
            label27.Dock = DockStyle.Fill;
            label27.Location = new Point(0, 66);
            label27.Margin = new Padding(0);
            label27.Name = "label27";
            label27.Size = new Size(411, 15);
            label27.TabIndex = 10;
            label27.Text = "Apellido/s:";
            label27.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbNombre
            // 
            DataLbNombre.AutoSize = true;
            DataLbNombre.BackColor = SystemColors.ControlLightLight;
            DataLbNombre.Dock = DockStyle.Fill;
            DataLbNombre.Location = new Point(411, 51);
            DataLbNombre.Margin = new Padding(0);
            DataLbNombre.Name = "DataLbNombre";
            DataLbNombre.Size = new Size(419, 15);
            DataLbNombre.TabIndex = 9;
            DataLbNombre.Text = "Nombre rrelargo";
            DataLbNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = SystemColors.ControlLightLight;
            label25.Dock = DockStyle.Fill;
            label25.Location = new Point(0, 51);
            label25.Margin = new Padding(0);
            label25.Name = "label25";
            label25.Size = new Size(411, 15);
            label25.TabIndex = 8;
            label25.Text = "Nombre/s:";
            label25.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbCuil
            // 
            DataLbCuil.AutoSize = true;
            DataLbCuil.BackColor = SystemColors.ScrollBar;
            DataLbCuil.Dock = DockStyle.Fill;
            DataLbCuil.Location = new Point(411, 36);
            DataLbCuil.Margin = new Padding(0);
            DataLbCuil.Name = "DataLbCuil";
            DataLbCuil.Size = new Size(419, 15);
            DataLbCuil.TabIndex = 7;
            DataLbCuil.Text = "20458512698";
            DataLbCuil.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = SystemColors.ScrollBar;
            label23.Dock = DockStyle.Fill;
            label23.Location = new Point(0, 36);
            label23.Margin = new Padding(0);
            label23.Name = "label23";
            label23.Size = new Size(411, 15);
            label23.TabIndex = 6;
            label23.Text = "Cuil:";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataLbDni
            // 
            DataLbDni.AutoSize = true;
            DataLbDni.BackColor = SystemColors.ControlLightLight;
            DataLbDni.Dock = DockStyle.Fill;
            DataLbDni.Location = new Point(411, 21);
            DataLbDni.Margin = new Padding(0);
            DataLbDni.Name = "DataLbDni";
            DataLbDni.Size = new Size(419, 15);
            DataLbDni.TabIndex = 5;
            DataLbDni.Text = "45851269";
            DataLbDni.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = SystemColors.ControlLightLight;
            label21.Dock = DockStyle.Fill;
            label21.Location = new Point(0, 21);
            label21.Margin = new Padding(0);
            label21.Name = "label21";
            label21.Size = new Size(411, 15);
            label21.TabIndex = 2;
            label21.Text = "Dni:";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.HotTrack;
            tableLayoutPanelAcuerdo.SetColumnSpan(label16, 2);
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.ForeColor = SystemColors.ControlLightLight;
            label16.Location = new Point(0, 0);
            label16.Margin = new Padding(0);
            label16.Name = "label16";
            label16.Size = new Size(830, 21);
            label16.TabIndex = 1;
            label16.Text = "Datos empleado";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listRetenciones
            // 
            listRetenciones.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            tableLayoutPanelAcuerdo.SetColumnSpan(listRetenciones, 2);
            listRetenciones.Dock = DockStyle.Fill;
            listRetenciones.FullRowSelect = true;
            listRetenciones.GridLines = true;
            listRetenciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listRetenciones.Location = new Point(3, 246);
            listRetenciones.MultiSelect = false;
            listRetenciones.Name = "listRetenciones";
            listRetenciones.Size = new Size(824, 179);
            listRetenciones.TabIndex = 31;
            listRetenciones.UseCompatibleStateImageBehavior = false;
            listRetenciones.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Concepto";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Unidades";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Quincena descontar";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // listAdicionales
            // 
            listAdicionales.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6 });
            tableLayoutPanelAcuerdo.SetColumnSpan(listAdicionales, 2);
            listAdicionales.Dock = DockStyle.Fill;
            listAdicionales.FullRowSelect = true;
            listAdicionales.GridLines = true;
            listAdicionales.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAdicionales.Location = new Point(3, 452);
            listAdicionales.MultiSelect = false;
            listAdicionales.Name = "listAdicionales";
            listAdicionales.Size = new Size(824, 85);
            listAdicionales.TabIndex = 33;
            listAdicionales.UseCompatibleStateImageBehavior = false;
            listAdicionales.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Concepto";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Monto";
            columnHeader6.Width = 200;
            // 
            // VerAcuerdosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 685);
            Controls.Add(tableLayoutPanelAcuerdo);
            Controls.Add(listaEmpleados);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerAcuerdosForm";
            Text = "Acuerdos";
            tableLayoutPanelAcuerdo.ResumeLayout(false);
            tableLayoutPanelAcuerdo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Components.Utils.ListaEmpComponent listaEmpleados;
        private ListView listHistorial;
        private TableLayoutPanel tableLayoutPanelAcuerdo;
        private Label DataLbNombre;
        private Label label25;
        private Label DataLbCuil;
        private Label label23;
        private Label DataLbDni;
        private Label label21;
        private Label label16;
        private Label DataLbJornal;
        private Label label38;
        private Label DataLbSueldo;
        private Label label36;
        private Label DataLbValorHora;
        private Label label34;
        private Label DataLbFechaCreacionAcuerdo;
        private Label label32;
        private Label DataLbCodAcuerdo;
        private Label label30;
        private Label label29;
        private Label DataLbApellido;
        private Label label27;
        private Label label46;
        private Label DataLbNotas;
        private Label label44;
        private Label DataLbTipoSueldo;
        private Label label42;
        private Label DataLbCodSueldo;
        private Label label40;
        private ListView listRetenciones;
        private Label label47;
        private ListView listAdicionales;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}
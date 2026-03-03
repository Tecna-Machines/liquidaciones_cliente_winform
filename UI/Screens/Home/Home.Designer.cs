namespace UI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelPrincipal = new Panel();
            labelServer = new Label();
            labelVersion = new Label();
            serverUrl = new TextBox();
            appVersion = new TextBox();
            labelNombre = new Label();
            pictureBoxLogo = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripInicio = new ToolStripLabel();
            toolStripEmpleado = new ToolStripDropDownButton();
            crearEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            toolStripButtonAcuerdos = new ToolStripDropDownButton();
            crearAcuerdoToolStripMenuItem = new ToolStripMenuItem();
            verAcuerdosToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownLiquidacion = new ToolStripDropDownButton();
            crearLiquidacionToolStripMenuItem = new ToolStripMenuItem();
            historialLiquidacionesToolStrip = new ToolStripMenuItem();
            toolStripDropDownCreditos = new ToolStripDropDownButton();
            crearCreditoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            toolStripDias = new ToolStripDropDownButton();
            asistenciasToolStripMenuItem = new ToolStripMenuItem();
            feriadosToolStripFeriados = new ToolStripMenuItem();
            crearFeriadoToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(labelServer);
            panelPrincipal.Controls.Add(labelVersion);
            panelPrincipal.Controls.Add(serverUrl);
            panelPrincipal.Controls.Add(appVersion);
            panelPrincipal.Controls.Add(labelNombre);
            panelPrincipal.Controls.Add(pictureBoxLogo);
            panelPrincipal.Location = new Point(12, 39);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(587, 296);
            panelPrincipal.TabIndex = 4;
            // 
            // labelServer
            // 
            labelServer.AutoSize = true;
            labelServer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelServer.Location = new Point(238, 227);
            labelServer.Name = "labelServer";
            labelServer.Size = new Size(50, 15);
            labelServer.TabIndex = 12;
            labelServer.Text = "SERVER";
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelVersion.Location = new Point(64, 227);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(58, 15);
            labelVersion.TabIndex = 11;
            labelVersion.Text = "VERSION";
            // 
            // serverUrl
            // 
            serverUrl.BackColor = SystemColors.ActiveCaption;
            serverUrl.Location = new Point(296, 223);
            serverUrl.Name = "serverUrl";
            serverUrl.ReadOnly = true;
            serverUrl.Size = new Size(235, 23);
            serverUrl.TabIndex = 10;
            serverUrl.TabStop = false;
            serverUrl.Text = "0.0.0";
            // 
            // appVersion
            // 
            appVersion.BackColor = SystemColors.ActiveCaption;
            appVersion.Location = new Point(130, 223);
            appVersion.Name = "appVersion";
            appVersion.ReadOnly = true;
            appVersion.Size = new Size(100, 23);
            appVersion.TabIndex = 9;
            appVersion.TabStop = false;
            appVersion.Text = "0.0.0";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.ForeColor = Color.FromArgb(82, 169, 97);
            labelNombre.Location = new Point(258, 81);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(250, 72);
            labelNombre.TabIndex = 4;
            labelNombre.Text = "AKER LQ";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Resources.rat;
            pictureBoxLogo.Location = new Point(106, 54);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(133, 127);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripInicio, toolStripEmpleado, toolStripButtonAcuerdos, toolStripDropDownLiquidacion, toolStripDropDownCreditos, toolStripDias });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(616, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripInicio
            // 
            toolStripInicio.Name = "toolStripInicio";
            toolStripInicio.Size = new Size(36, 22);
            toolStripInicio.Text = "Inicio";
            toolStripInicio.Click += ClickBtnInicio;
            // 
            // toolStripEmpleado
            // 
            toolStripEmpleado.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripEmpleado.DropDownItems.AddRange(new ToolStripItem[] { crearEmpleadoToolStripMenuItem });
            toolStripEmpleado.Image = (Image)resources.GetObject("toolStripEmpleado.Image");
            toolStripEmpleado.ImageTransparentColor = Color.Magenta;
            toolStripEmpleado.Name = "toolStripEmpleado";
            toolStripEmpleado.Size = new Size(78, 22);
            toolStripEmpleado.Text = "Empleados";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            crearEmpleadoToolStripMenuItem.Size = new Size(158, 22);
            crearEmpleadoToolStripMenuItem.Text = "Crear empleado";
            crearEmpleadoToolStripMenuItem.Click += CrearEmpleadoToolStripMenuItem_Click;
            // 
            // toolStripButtonAcuerdos
            // 
            toolStripButtonAcuerdos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAcuerdos.DropDownItems.AddRange(new ToolStripItem[] { crearAcuerdoToolStripMenuItem, verAcuerdosToolStripMenuItem });
            toolStripButtonAcuerdos.Image = (Image)resources.GetObject("toolStripButtonAcuerdos.Image");
            toolStripButtonAcuerdos.ImageTransparentColor = Color.Magenta;
            toolStripButtonAcuerdos.Name = "toolStripButtonAcuerdos";
            toolStripButtonAcuerdos.Size = new Size(70, 22);
            toolStripButtonAcuerdos.Text = "Acuerdos";
            // 
            // crearAcuerdoToolStripMenuItem
            // 
            crearAcuerdoToolStripMenuItem.Name = "crearAcuerdoToolStripMenuItem";
            crearAcuerdoToolStripMenuItem.Size = new Size(148, 22);
            crearAcuerdoToolStripMenuItem.Text = "Crear acuerdo";
            crearAcuerdoToolStripMenuItem.Click += CrearAcuerdoToolStripMenuItem_Click;
            // 
            // verAcuerdosToolStripMenuItem
            // 
            verAcuerdosToolStripMenuItem.Name = "verAcuerdosToolStripMenuItem";
            verAcuerdosToolStripMenuItem.Size = new Size(148, 22);
            verAcuerdosToolStripMenuItem.Text = "Ver acuerdos";
            verAcuerdosToolStripMenuItem.Click += VerAcuerdosToolStripMenuItem_Click;
            // 
            // toolStripDropDownLiquidacion
            // 
            toolStripDropDownLiquidacion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownLiquidacion.DropDownItems.AddRange(new ToolStripItem[] { crearLiquidacionToolStripMenuItem, historialLiquidacionesToolStrip });
            toolStripDropDownLiquidacion.Image = (Image)resources.GetObject("toolStripDropDownLiquidacion.Image");
            toolStripDropDownLiquidacion.ImageTransparentColor = Color.Magenta;
            toolStripDropDownLiquidacion.Name = "toolStripDropDownLiquidacion";
            toolStripDropDownLiquidacion.Size = new Size(93, 22);
            toolStripDropDownLiquidacion.Text = "Liquidaciones";
            // 
            // crearLiquidacionToolStripMenuItem
            // 
            crearLiquidacionToolStripMenuItem.Name = "crearLiquidacionToolStripMenuItem";
            crearLiquidacionToolStripMenuItem.Size = new Size(164, 22);
            crearLiquidacionToolStripMenuItem.Text = "Crear liquidacion";
            crearLiquidacionToolStripMenuItem.Click += CrearLiquidacionToolStripMenuItem_Click;
            // 
            // historialLiquidacionesToolStrip
            // 
            historialLiquidacionesToolStrip.Name = "historialLiquidacionesToolStrip";
            historialLiquidacionesToolStrip.Size = new Size(164, 22);
            historialLiquidacionesToolStrip.Text = "Historial";
            historialLiquidacionesToolStrip.Click += HistorialLiquidacionesToolStripMenuItem_Click;
            // 
            // toolStripDropDownCreditos
            // 
            toolStripDropDownCreditos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownCreditos.DropDownItems.AddRange(new ToolStripItem[] { crearCreditoToolStripMenuItem, consultarToolStripMenuItem });
            toolStripDropDownCreditos.Image = (Image)resources.GetObject("toolStripDropDownCreditos.Image");
            toolStripDropDownCreditos.ImageTransparentColor = Color.Magenta;
            toolStripDropDownCreditos.Name = "toolStripDropDownCreditos";
            toolStripDropDownCreditos.Size = new Size(64, 22);
            toolStripDropDownCreditos.Text = "Creditos";
            // 
            // crearCreditoToolStripMenuItem
            // 
            crearCreditoToolStripMenuItem.Name = "crearCreditoToolStripMenuItem";
            crearCreditoToolStripMenuItem.Size = new Size(125, 22);
            crearCreditoToolStripMenuItem.Text = "Crear";
            crearCreditoToolStripMenuItem.Click += CrearCreditoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(125, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += ConsultarToolStripMenuItem_Click;
            // 
            // toolStripDias
            // 
            toolStripDias.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDias.DropDownItems.AddRange(new ToolStripItem[] { asistenciasToolStripMenuItem, feriadosToolStripFeriados });
            toolStripDias.Image = (Image)resources.GetObject("toolStripDias.Image");
            toolStripDias.ImageTransparentColor = Color.Magenta;
            toolStripDias.Name = "toolStripDias";
            toolStripDias.Size = new Size(132, 22);
            toolStripDias.Text = "Asistencias y feriados";
            // 
            // asistenciasToolStripMenuItem
            // 
            asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            asistenciasToolStripMenuItem.Size = new Size(180, 22);
            asistenciasToolStripMenuItem.Text = "Asistencias";
            // 
            // feriadosToolStripFeriados
            // 
            feriadosToolStripFeriados.DropDownItems.AddRange(new ToolStripItem[] { crearFeriadoToolStripMenuItem });
            feriadosToolStripFeriados.Name = "feriadosToolStripFeriados";
            feriadosToolStripFeriados.Size = new Size(180, 22);
            feriadosToolStripFeriados.Text = "Feriados";
            // 
            // crearFeriadoToolStripMenuItem
            // 
            crearFeriadoToolStripMenuItem.Name = "crearFeriadoToolStripMenuItem";
            crearFeriadoToolStripMenuItem.Size = new Size(180, 22);
            crearFeriadoToolStripMenuItem.Text = "Crear feriado";
            crearFeriadoToolStripMenuItem.Click += CrearFeriadoToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(616, 361);
            Controls.Add(toolStrip1);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPrincipal;
        private PictureBox pictureBoxLogo;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripEmpleado;
        private ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private ToolStripDropDownButton toolStripButtonAcuerdos;
        private ToolStripMenuItem crearAcuerdoToolStripMenuItem;
        private ToolStripMenuItem verAcuerdosToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownLiquidacion;
        private ToolStripMenuItem crearLiquidacionToolStripMenuItem;
        private ToolStripMenuItem historialLiquidacionesToolStrip;
        private Label labelNombre;
        private TextBox serverUrl;
        private TextBox appVersion;
        private Label labelServer;
        private Label labelVersion;
        private ToolStripLabel toolStripInicio;
        private ToolStripDropDownButton toolStripDropDownCreditos;
        private ToolStripMenuItem crearCreditoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripDropDownButton toolStripDias;
        private ToolStripMenuItem asistenciasToolStripMenuItem;
        private ToolStripMenuItem feriadosToolStripFeriados;
        private ToolStripMenuItem crearFeriadoToolStripMenuItem;
    }
}

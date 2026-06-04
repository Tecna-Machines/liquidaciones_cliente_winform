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
            barraDeEstado = new StatusStrip();
            toolStripStatusLabelServidor = new ToolStripStatusLabel();
            toolStripStatusVersion = new ToolStripStatusLabel();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            toolStrip1.SuspendLayout();
            barraDeEstado.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(pictureBoxLogo);
            panelPrincipal.Location = new Point(12, 39);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(587, 268);
            panelPrincipal.TabIndex = 4;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Resources.akerlq_ia;
            pictureBoxLogo.Location = new Point(22, 17);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(529, 248);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.GradientInactiveCaption;
            toolStrip1.Font = new Font("Segoe UI", 9F);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripInicio, toolStripEmpleado, toolStripButtonAcuerdos, toolStripDropDownLiquidacion, toolStripDropDownCreditos, toolStripDias });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(612, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripInicio
            // 
            toolStripInicio.BackColor = SystemColors.GradientInactiveCaption;
            toolStripInicio.Font = new Font("Segoe UI", 9F);
            toolStripInicio.ForeColor = SystemColors.ActiveCaptionText;
            toolStripInicio.Name = "toolStripInicio";
            toolStripInicio.Size = new Size(36, 22);
            toolStripInicio.Text = "Inicio";
            toolStripInicio.Click += ClickBtnInicio;
            // 
            // toolStripEmpleado
            // 
            toolStripEmpleado.BackColor = SystemColors.GradientInactiveCaption;
            toolStripEmpleado.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripEmpleado.DropDownItems.AddRange(new ToolStripItem[] { crearEmpleadoToolStripMenuItem });
            toolStripEmpleado.Font = new Font("Segoe UI", 9F);
            toolStripEmpleado.ForeColor = SystemColors.ActiveCaptionText;
            toolStripEmpleado.Image = (Image)resources.GetObject("toolStripEmpleado.Image");
            toolStripEmpleado.ImageTransparentColor = Color.Magenta;
            toolStripEmpleado.Name = "toolStripEmpleado";
            toolStripEmpleado.Size = new Size(78, 22);
            toolStripEmpleado.Text = "Empleados";
            // 
            // crearEmpleadoToolStripMenuItem
            // 
            crearEmpleadoToolStripMenuItem.Name = "crearEmpleadoToolStripMenuItem";
            crearEmpleadoToolStripMenuItem.Size = new Size(165, 22);
            crearEmpleadoToolStripMenuItem.Text = "Cargar empleado";
            crearEmpleadoToolStripMenuItem.Click += CrearEmpleadoToolStripMenuItem_Click;
            // 
            // toolStripButtonAcuerdos
            // 
            toolStripButtonAcuerdos.BackColor = SystemColors.GradientInactiveCaption;
            toolStripButtonAcuerdos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonAcuerdos.DropDownItems.AddRange(new ToolStripItem[] { crearAcuerdoToolStripMenuItem, verAcuerdosToolStripMenuItem });
            toolStripButtonAcuerdos.Font = new Font("Segoe UI", 9F);
            toolStripButtonAcuerdos.ForeColor = SystemColors.ActiveCaptionText;
            toolStripButtonAcuerdos.Image = (Image)resources.GetObject("toolStripButtonAcuerdos.Image");
            toolStripButtonAcuerdos.ImageTransparentColor = Color.Magenta;
            toolStripButtonAcuerdos.Name = "toolStripButtonAcuerdos";
            toolStripButtonAcuerdos.Size = new Size(70, 22);
            toolStripButtonAcuerdos.Text = "Acuerdos";
            // 
            // crearAcuerdoToolStripMenuItem
            // 
            crearAcuerdoToolStripMenuItem.Name = "crearAcuerdoToolStripMenuItem";
            crearAcuerdoToolStripMenuItem.Size = new Size(162, 22);
            crearAcuerdoToolStripMenuItem.Text = "Cargar acuerdo";
            crearAcuerdoToolStripMenuItem.Click += CrearAcuerdoToolStripMenuItem_Click;
            // 
            // verAcuerdosToolStripMenuItem
            // 
            verAcuerdosToolStripMenuItem.Name = "verAcuerdosToolStripMenuItem";
            verAcuerdosToolStripMenuItem.Size = new Size(162, 22);
            verAcuerdosToolStripMenuItem.Text = "Revisar acuerdos";
            verAcuerdosToolStripMenuItem.Click += VerAcuerdosToolStripMenuItem_Click;
            // 
            // toolStripDropDownLiquidacion
            // 
            toolStripDropDownLiquidacion.BackColor = SystemColors.GradientInactiveCaption;
            toolStripDropDownLiquidacion.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownLiquidacion.DropDownItems.AddRange(new ToolStripItem[] { crearLiquidacionToolStripMenuItem, historialLiquidacionesToolStrip });
            toolStripDropDownLiquidacion.Font = new Font("Segoe UI", 9F);
            toolStripDropDownLiquidacion.ForeColor = SystemColors.ActiveCaptionText;
            toolStripDropDownLiquidacion.Image = (Image)resources.GetObject("toolStripDropDownLiquidacion.Image");
            toolStripDropDownLiquidacion.ImageTransparentColor = Color.Magenta;
            toolStripDropDownLiquidacion.Name = "toolStripDropDownLiquidacion";
            toolStripDropDownLiquidacion.Size = new Size(93, 22);
            toolStripDropDownLiquidacion.Text = "Liquidaciones";
            // 
            // crearLiquidacionToolStripMenuItem
            // 
            crearLiquidacionToolStripMenuItem.Name = "crearLiquidacionToolStripMenuItem";
            crearLiquidacionToolStripMenuItem.Size = new Size(182, 22);
            crearLiquidacionToolStripMenuItem.Text = "Crear liquidacion";
            crearLiquidacionToolStripMenuItem.Click += CrearLiquidacionToolStripMenuItem_Click;
            // 
            // historialLiquidacionesToolStrip
            // 
            historialLiquidacionesToolStrip.Name = "historialLiquidacionesToolStrip";
            historialLiquidacionesToolStrip.Size = new Size(182, 22);
            historialLiquidacionesToolStrip.Text = "Buscar liquidaciones";
            historialLiquidacionesToolStrip.Click += HistorialLiquidacionesToolStripMenuItem_Click;
            // 
            // toolStripDropDownCreditos
            // 
            toolStripDropDownCreditos.BackColor = SystemColors.GradientInactiveCaption;
            toolStripDropDownCreditos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownCreditos.DropDownItems.AddRange(new ToolStripItem[] { crearCreditoToolStripMenuItem, consultarToolStripMenuItem });
            toolStripDropDownCreditos.Font = new Font("Segoe UI", 9F);
            toolStripDropDownCreditos.ForeColor = SystemColors.ActiveCaptionText;
            toolStripDropDownCreditos.Image = (Image)resources.GetObject("toolStripDropDownCreditos.Image");
            toolStripDropDownCreditos.ImageTransparentColor = Color.Magenta;
            toolStripDropDownCreditos.Name = "toolStripDropDownCreditos";
            toolStripDropDownCreditos.Size = new Size(64, 22);
            toolStripDropDownCreditos.Text = "Creditos";
            // 
            // crearCreditoToolStripMenuItem
            // 
            crearCreditoToolStripMenuItem.Name = "crearCreditoToolStripMenuItem";
            crearCreditoToolStripMenuItem.Size = new Size(154, 22);
            crearCreditoToolStripMenuItem.Text = "Cargar credito";
            crearCreditoToolStripMenuItem.Click += CrearCreditoToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(154, 22);
            consultarToolStripMenuItem.Text = "Buscar creditos";
            consultarToolStripMenuItem.Click += ConsultarToolStripMenuItem_Click;
            // 
            // toolStripDias
            // 
            toolStripDias.BackColor = SystemColors.GradientInactiveCaption;
            toolStripDias.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDias.DropDownItems.AddRange(new ToolStripItem[] { asistenciasToolStripMenuItem, feriadosToolStripFeriados });
            toolStripDias.Font = new Font("Segoe UI", 9F);
            toolStripDias.ForeColor = SystemColors.ActiveCaptionText;
            toolStripDias.Image = (Image)resources.GetObject("toolStripDias.Image");
            toolStripDias.ImageTransparentColor = Color.Magenta;
            toolStripDias.Name = "toolStripDias";
            toolStripDias.Size = new Size(132, 22);
            toolStripDias.Text = "Asistencias y feriados";
            // 
            // asistenciasToolStripMenuItem
            // 
            asistenciasToolStripMenuItem.Name = "asistenciasToolStripMenuItem";
            asistenciasToolStripMenuItem.Size = new Size(132, 22);
            asistenciasToolStripMenuItem.Text = "Asistencias";
            // 
            // feriadosToolStripFeriados
            // 
            feriadosToolStripFeriados.DropDownItems.AddRange(new ToolStripItem[] { crearFeriadoToolStripMenuItem });
            feriadosToolStripFeriados.Name = "feriadosToolStripFeriados";
            feriadosToolStripFeriados.Size = new Size(132, 22);
            feriadosToolStripFeriados.Text = "Feriados";
            // 
            // crearFeriadoToolStripMenuItem
            // 
            crearFeriadoToolStripMenuItem.Name = "crearFeriadoToolStripMenuItem";
            crearFeriadoToolStripMenuItem.Size = new Size(149, 22);
            crearFeriadoToolStripMenuItem.Text = "Cargar feriado";
            crearFeriadoToolStripMenuItem.Click += CrearFeriadoToolStripMenuItem_Click;
            // 
            // barraDeEstado
            // 
            barraDeEstado.BackColor = SystemColors.MenuHighlight;
            barraDeEstado.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelServidor, toolStripStatusVersion });
            barraDeEstado.Location = new Point(0, 319);
            barraDeEstado.Name = "barraDeEstado";
            barraDeEstado.Size = new Size(612, 22);
            barraDeEstado.TabIndex = 9;
            barraDeEstado.Text = "statusStrip1";
            // 
            // toolStripStatusLabelServidor
            // 
            toolStripStatusLabelServidor.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            toolStripStatusLabelServidor.ForeColor = SystemColors.ButtonHighlight;
            toolStripStatusLabelServidor.Name = "toolStripStatusLabelServidor";
            toolStripStatusLabelServidor.Size = new Size(88, 17);
            toolStripStatusLabelServidor.Text = "servidor: 0.0.0.0";
            // 
            // toolStripStatusVersion
            // 
            toolStripStatusVersion.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            toolStripStatusVersion.ForeColor = SystemColors.ButtonHighlight;
            toolStripStatusVersion.Margin = new Padding(10, 3, 0, 2);
            toolStripStatusVersion.Name = "toolStripStatusVersion";
            toolStripStatusVersion.Size = new Size(131, 17);
            toolStripStatusVersion.Text = "version del cliente: 0.0.0";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(612, 341);
            Controls.Add(barraDeEstado);
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            barraDeEstado.ResumeLayout(false);
            barraDeEstado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelPrincipal;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripEmpleado;
        private ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private ToolStripDropDownButton toolStripButtonAcuerdos;
        private ToolStripMenuItem crearAcuerdoToolStripMenuItem;
        private ToolStripMenuItem verAcuerdosToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownLiquidacion;
        private ToolStripMenuItem crearLiquidacionToolStripMenuItem;
        private ToolStripMenuItem historialLiquidacionesToolStrip;
        private ToolStripLabel toolStripInicio;
        private ToolStripDropDownButton toolStripDropDownCreditos;
        private ToolStripMenuItem crearCreditoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripDropDownButton toolStripDias;
        private ToolStripMenuItem asistenciasToolStripMenuItem;
        private ToolStripMenuItem feriadosToolStripFeriados;
        private ToolStripMenuItem crearFeriadoToolStripMenuItem;
        private StatusStrip barraDeEstado;
        private ToolStripStatusLabel toolStripStatusLabelServidor;
        private ToolStripStatusLabel toolStripStatusVersion;
        private PictureBox pictureBoxLogo;
    }
}

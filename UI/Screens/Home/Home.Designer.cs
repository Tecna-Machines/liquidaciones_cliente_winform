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
            labelServerInfo = new Label();
            pictureBoxLogo = new PictureBox();
            dataVersion = new Label();
            toolStrip1 = new ToolStrip();
            toolStripEmpleado = new ToolStripDropDownButton();
            crearEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            toolStripButtonAcuerdos = new ToolStripDropDownButton();
            crearAcuerdoToolStripMenuItem = new ToolStripMenuItem();
            verAcuerdosToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownLiquidacion = new ToolStripDropDownButton();
            crearLiquidacionToolStripMenuItem = new ToolStripMenuItem();
            historialLiquidacionesToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(labelServerInfo);
            panelPrincipal.Controls.Add(pictureBoxLogo);
            panelPrincipal.Controls.Add(dataVersion);
            panelPrincipal.Location = new Point(37, 39);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(547, 271);
            panelPrincipal.TabIndex = 4;
            // 
            // labelServerInfo
            // 
            labelServerInfo.AutoSize = true;
            labelServerInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelServerInfo.Location = new Point(205, 238);
            labelServerInfo.Name = "labelServerInfo";
            labelServerInfo.Size = new Size(84, 15);
            labelServerInfo.TabIndex = 3;
            labelServerInfo.Text = "<server info>";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Resources.logo_tecna_azul_rd;
            pictureBoxLogo.Location = new Point(16, 12);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(509, 180);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // dataVersion
            // 
            dataVersion.AutoSize = true;
            dataVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataVersion.Location = new Point(55, 210);
            dataVersion.Name = "dataVersion";
            dataVersion.Size = new Size(398, 15);
            dataVersion.TabIndex = 1;
            dataVersion.Text = "Cliente V0.0.1 - BETA    release date 22/10/2024 compatible con V0.1.2";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripEmpleado, toolStripButtonAcuerdos, toolStripDropDownLiquidacion });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(636, 25);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
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
            toolStripDropDownLiquidacion.DropDownItems.AddRange(new ToolStripItem[] { crearLiquidacionToolStripMenuItem, historialLiquidacionesToolStripMenuItem });
            toolStripDropDownLiquidacion.Image = (Image)resources.GetObject("toolStripDropDownLiquidacion.Image");
            toolStripDropDownLiquidacion.ImageTransparentColor = Color.Magenta;
            toolStripDropDownLiquidacion.Name = "toolStripDropDownLiquidacion";
            toolStripDropDownLiquidacion.Size = new Size(93, 22);
            toolStripDropDownLiquidacion.Text = "Liquidaciones";
            // 
            // crearLiquidacionToolStripMenuItem
            // 
            crearLiquidacionToolStripMenuItem.Name = "crearLiquidacionToolStripMenuItem";
            crearLiquidacionToolStripMenuItem.Size = new Size(191, 22);
            crearLiquidacionToolStripMenuItem.Text = "Crear liquidacion";
            crearLiquidacionToolStripMenuItem.Click += CrearLiquidacionToolStripMenuItem_Click;
            // 
            // historialLiquidacionesToolStripMenuItem
            // 
            historialLiquidacionesToolStripMenuItem.Name = "historialLiquidacionesToolStripMenuItem";
            historialLiquidacionesToolStripMenuItem.Size = new Size(191, 22);
            historialLiquidacionesToolStripMenuItem.Text = "Historial liquidaciones";
            historialLiquidacionesToolStripMenuItem.Click += HistorialLiquidacionesToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(636, 347);
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
        private Label dataVersion;
        private PictureBox pictureBoxLogo;
        private Label labelServerInfo;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripEmpleado;
        private ToolStripMenuItem crearEmpleadoToolStripMenuItem;
        private ToolStripDropDownButton toolStripButtonAcuerdos;
        private ToolStripMenuItem crearAcuerdoToolStripMenuItem;
        private ToolStripMenuItem verAcuerdosToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownLiquidacion;
        private ToolStripMenuItem crearLiquidacionToolStripMenuItem;
        private ToolStripMenuItem historialLiquidacionesToolStripMenuItem;
    }
}

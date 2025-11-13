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
            btnCrearEmpleado = new Button();
            btnCrearContrato = new Button();
            button1 = new Button();
            button2 = new Button();
            panelPrincipal = new Panel();
            labelServerInfo = new Label();
            pictureBoxLogo = new PictureBox();
            dataVersion = new Label();
            btnInicio = new Button();
            btnHistorialTrabajo = new Button();
            btnCreditos = new Button();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.BackColor = SystemColors.ButtonHighlight;
            btnCrearEmpleado.Cursor = Cursors.Hand;
            btnCrearEmpleado.FlatStyle = FlatStyle.Flat;
            btnCrearEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearEmpleado.Location = new Point(5, 63);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(131, 45);
            btnCrearEmpleado.TabIndex = 0;
            btnCrearEmpleado.Text = "CREAR EMPLEADO";
            btnCrearEmpleado.UseVisualStyleBackColor = false;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.BackColor = SystemColors.ActiveCaption;
            btnCrearContrato.Cursor = Cursors.Hand;
            btnCrearContrato.FlatStyle = FlatStyle.Flat;
            btnCrearContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearContrato.Location = new Point(5, 125);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(131, 45);
            btnCrearContrato.TabIndex = 1;
            btnCrearContrato.Text = "CREAR ACUERDO";
            btnCrearContrato.UseVisualStyleBackColor = false;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(141, 185);
            button1.Name = "button1";
            button1.Size = new Size(131, 45);
            button1.TabIndex = 2;
            button1.Text = "CREAR UNA LIQUIDACION";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClickBtnHacerLiquidacion;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(5, 185);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 3;
            button2.Text = "VER HISTORIAL LIQUIDACIONES";
            button2.UseVisualStyleBackColor = false;
            button2.Click += ClickBtnHistorialLiquidacion;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(labelServerInfo);
            panelPrincipal.Controls.Add(pictureBoxLogo);
            panelPrincipal.Controls.Add(dataVersion);
            panelPrincipal.Location = new Point(303, 48);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(528, 271);
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
            pictureBoxLogo.Size = new Size(495, 180);
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
            // btnInicio
            // 
            btnInicio.BackColor = SystemColors.ButtonHighlight;
            btnInicio.Cursor = Cursors.Hand;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(5, 249);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(267, 45);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.Click += ClickBtnInicio;
            // 
            // btnHistorialTrabajo
            // 
            btnHistorialTrabajo.BackColor = SystemColors.ActiveCaption;
            btnHistorialTrabajo.Cursor = Cursors.Hand;
            btnHistorialTrabajo.FlatStyle = FlatStyle.Flat;
            btnHistorialTrabajo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorialTrabajo.Location = new Point(141, 125);
            btnHistorialTrabajo.Name = "btnHistorialTrabajo";
            btnHistorialTrabajo.Size = new Size(131, 45);
            btnHistorialTrabajo.TabIndex = 6;
            btnHistorialTrabajo.Text = "VER ACUERDOS";
            btnHistorialTrabajo.UseVisualStyleBackColor = false;
            btnHistorialTrabajo.Click += btnHistorialTrabajo_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = SystemColors.ButtonHighlight;
            btnCreditos.Cursor = Cursors.Hand;
            btnCreditos.FlatStyle = FlatStyle.Flat;
            btnCreditos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreditos.Location = new Point(141, 63);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(131, 45);
            btnCreditos.TabIndex = 7;
            btnCreditos.Text = "VER CREDITOS";
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(870, 347);
            Controls.Add(btnCreditos);
            Controls.Add(btnHistorialTrabajo);
            Controls.Add(btnInicio);
            Controls.Add(btnCrearContrato);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCrearEmpleado);
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
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearEmpleado;
        private Button btnCrearContrato;
        private Button button1;
        private Button button2;
        private Panel panelPrincipal;
        private Label dataVersion;
        private PictureBox pictureBoxLogo;
        private Button btnInicio;
        private Label labelServerInfo;
        private Button btnHistorialTrabajo;
        private Button btnCreditos;
    }
}

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
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearEmpleado.Location = new Point(23, 91);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(150, 45);
            btnCrearEmpleado.TabIndex = 0;
            btnCrearEmpleado.Text = "AGREGAR EMPLEADO";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearContrato.Location = new Point(23, 154);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(150, 50);
            btnCrearContrato.TabIndex = 1;
            btnCrearContrato.Text = "CREAR CONTRATO DE TRABAJO";
            btnCrearContrato.UseVisualStyleBackColor = true;
            btnCrearContrato.Click += btnCrearContrato_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(23, 221);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 2;
            button1.Text = "HACER UNA LIQUIDACION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickBtnHacerLiquidacion;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(23, 367);
            button2.Name = "button2";
            button2.Size = new Size(150, 47);
            button2.TabIndex = 3;
            button2.Text = "VER HISTORIAL LIQUIDACIONES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickBtnHistorialLiquidacion;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(labelServerInfo);
            panelPrincipal.Controls.Add(pictureBoxLogo);
            panelPrincipal.Controls.Add(dataVersion);
            panelPrincipal.Location = new Point(197, 33);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(591, 381);
            panelPrincipal.TabIndex = 4;
            // 
            // labelServerInfo
            // 
            labelServerInfo.AutoSize = true;
            labelServerInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelServerInfo.Location = new Point(239, 309);
            labelServerInfo.Name = "labelServerInfo";
            labelServerInfo.Size = new Size(84, 15);
            labelServerInfo.TabIndex = 3;
            labelServerInfo.Text = "<server info>";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Resources.Resources.Logos_tecna_01;
            pictureBoxLogo.Location = new Point(57, 58);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(495, 180);
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // dataVersion
            // 
            dataVersion.AutoSize = true;
            dataVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataVersion.Location = new Point(129, 260);
            dataVersion.Name = "dataVersion";
            dataVersion.Size = new Size(368, 15);
            dataVersion.TabIndex = 1;
            dataVersion.Text = "Cliente V0.0.0 - BETA    release date 0/0/0/ compatible con V0.1.2";
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicio.Location = new Point(23, 33);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(150, 45);
            btnInicio.TabIndex = 5;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += ClickBtnInicio;
            // 
            // btnHistorialTrabajo
            // 
            btnHistorialTrabajo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHistorialTrabajo.Location = new Point(23, 293);
            btnHistorialTrabajo.Name = "btnHistorialTrabajo";
            btnHistorialTrabajo.Size = new Size(150, 50);
            btnHistorialTrabajo.TabIndex = 6;
            btnHistorialTrabajo.Text = "VER CONTRATOS";
            btnHistorialTrabajo.UseVisualStyleBackColor = true;
            btnHistorialTrabajo.Click += btnHistorialTrabajo_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnHistorialTrabajo);
            Controls.Add(btnInicio);
            Controls.Add(panelPrincipal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCrearContrato);
            Controls.Add(btnCrearEmpleado);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Home";
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
    }
}

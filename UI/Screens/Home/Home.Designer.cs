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
            btnCrearEmpleado = new Button();
            btnCrearContrato = new Button();
            button1 = new Button();
            button2 = new Button();
            panelPrincipal = new Panel();
            SuspendLayout();
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearEmpleado.Location = new Point(26, 57);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(140, 61);
            btnCrearEmpleado.TabIndex = 0;
            btnCrearEmpleado.Text = "AGREGAR EMPLEADO";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnCrearContrato
            // 
            btnCrearContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCrearContrato.Location = new Point(26, 147);
            btnCrearContrato.Name = "btnCrearContrato";
            btnCrearContrato.Size = new Size(140, 61);
            btnCrearContrato.TabIndex = 1;
            btnCrearContrato.Text = "CREAR CONTRATO DE TRABAJO";
            btnCrearContrato.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(26, 234);
            button1.Name = "button1";
            button1.Size = new Size(140, 61);
            button1.TabIndex = 2;
            button1.Text = "HACER UNA LIQUIDACION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickBtnHacerLiquidacion;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(26, 317);
            button2.Name = "button2";
            button2.Size = new Size(140, 61);
            button2.TabIndex = 3;
            button2.Text = "VER HISTORIAL LIQUIDACIONES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClickBtnHistorialLiquidacion;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Location = new Point(197, 57);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(591, 381);
            panelPrincipal.TabIndex = 4;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnCrearContrato);
            Controls.Add(btnCrearEmpleado);
            Name = "Home";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearEmpleado;
        private Button btnCrearContrato;
        private Button button1;
        private Button button2;
        private Panel panelPrincipal;
    }
}

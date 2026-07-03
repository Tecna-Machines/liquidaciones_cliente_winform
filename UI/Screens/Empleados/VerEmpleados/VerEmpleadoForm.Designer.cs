namespace UI.Screens.Empleados.VerEmpleados
{
    partial class VerEmpleadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEmpleadoForm));
            listaEmpComponent1 = new UI.Components.Utils.ListaEmpComponent();
            panelPrincipal = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Dock = DockStyle.Left;
            listaEmpComponent1.Location = new Point(0, 0);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.ServiceProvider = null;
            listaEmpComponent1.Size = new Size(304, 728);
            listaEmpComponent1.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(textBox4);
            panelPrincipal.Controls.Add(textBox3);
            panelPrincipal.Controls.Add(textBox2);
            panelPrincipal.Controls.Add(textBox1);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Dock = DockStyle.Fill;
            panelPrincipal.Location = new Point(304, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(715, 728);
            panelPrincipal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11F, FontStyle.Bold);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(25, 95);
            label1.Name = "label1";
            label1.Size = new Size(40, 18);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11F, FontStyle.Bold);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(25, 140);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 1;
            label2.Text = "CUIL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11F, FontStyle.Bold);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(25, 185);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 2;
            label3.Text = "NOMBRE:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(25, 230);
            label4.Name = "label4";
            label4.Size = new Size(80, 18);
            label4.TabIndex = 3;
            label4.Text = "APELLIDO:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(114, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(114, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Info;
            textBox3.Location = new Point(114, 228);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.Info;
            textBox4.Location = new Point(114, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(255, 23);
            textBox4.TabIndex = 7;
            // 
            // VerEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 728);
            Controls.Add(panelPrincipal);
            Controls.Add(listaEmpComponent1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerEmpleadoForm";
            Text = "Empleados";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private Panel panelPrincipal;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
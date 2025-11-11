namespace UI.Screens.CrearEmpleado
{
    partial class CrearEmpleadoForm
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
            textBoxDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNombres = new TextBox();
            label3 = new Label();
            textBoxApellidos = new TextBox();
            fechaIngreso = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            fechaAlta = new DateTimePicker();
            label6 = new Label();
            fechaNacimiento = new DateTimePicker();
            BtnConfirmarCrear = new Button();
            SuspendLayout();
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(101, 50);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(222, 23);
            textBoxDni.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 54);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 83);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE/S:";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Location = new Point(101, 79);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(222, 23);
            textBoxNombres.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(22, 112);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "APELLIDO/S:";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Location = new Point(101, 108);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(222, 23);
            textBoxApellidos.TabIndex = 4;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Location = new Point(414, 50);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(222, 23);
            fechaIngreso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(346, 54);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 7;
            label4.Text = "INGRESO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(368, 85);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "ALTA: ";
            // 
            // fechaAlta
            // 
            fechaAlta.Location = new Point(414, 81);
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Size = new Size(222, 23);
            fechaAlta.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(329, 116);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "NACIMIENTO:";
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Location = new Point(414, 112);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(222, 23);
            fechaNacimiento.TabIndex = 10;
            // 
            // BtnConfirmarCrear
            // 
            BtnConfirmarCrear.BackColor = SystemColors.Info;
            BtnConfirmarCrear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmarCrear.Location = new Point(414, 153);
            BtnConfirmarCrear.Name = "BtnConfirmarCrear";
            BtnConfirmarCrear.Size = new Size(222, 42);
            BtnConfirmarCrear.TabIndex = 12;
            BtnConfirmarCrear.Text = "CREAR EMPLEADO";
            BtnConfirmarCrear.UseVisualStyleBackColor = false;
            BtnConfirmarCrear.Click += BtnConfirmarCrear_Click;
            // 
            // CrearEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 207);
            Controls.Add(BtnConfirmarCrear);
            Controls.Add(label6);
            Controls.Add(fechaNacimiento);
            Controls.Add(label5);
            Controls.Add(fechaAlta);
            Controls.Add(label4);
            Controls.Add(fechaIngreso);
            Controls.Add(label3);
            Controls.Add(textBoxApellidos);
            Controls.Add(label2);
            Controls.Add(textBoxNombres);
            Controls.Add(label1);
            Controls.Add(textBoxDni);
            Name = "CrearEmpleadoForm";
            Text = "CrearEmpleadoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDni;
        private Label label1;
        private Label label2;
        private TextBox textBoxNombres;
        private Label label3;
        private TextBox textBoxApellidos;
        private DateTimePicker fechaIngreso;
        private Label label4;
        private Label label5;
        private DateTimePicker fechaAlta;
        private Label label6;
        private DateTimePicker fechaNacimiento;
        private Button BtnConfirmarCrear;
    }
}
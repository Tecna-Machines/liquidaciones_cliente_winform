namespace UI.Screens.VerCreditos
{
    partial class VerCreditosForm
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
            listaEmpComponent1 = new Components.Utils.ListaEmpComponent();
            btnCrearCredito = new Button();
            textBoxDni = new TextBox();
            labelDni = new Label();
            labelNombre = new Label();
            textBox1 = new TextBox();
            listCreditos = new ListView();
            columnHeaderCod = new ColumnHeader();
            columnHeaderConcepto = new ColumnHeader();
            columnHeaderCuotas = new ColumnHeader();
            columnHeaderMontoCuota = new ColumnHeader();
            columnHeaderMontoFaltante = new ColumnHeader();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(12, 12);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.Size = new Size(304, 690);
            listaEmpComponent1.TabIndex = 0;
            // 
            // btnCrearCredito
            // 
            btnCrearCredito.BackColor = Color.IndianRed;
            btnCrearCredito.BackgroundImageLayout = ImageLayout.Center;
            btnCrearCredito.FlatStyle = FlatStyle.Popup;
            btnCrearCredito.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearCredito.ForeColor = SystemColors.ControlText;
            btnCrearCredito.Location = new Point(867, 133);
            btnCrearCredito.Name = "btnCrearCredito";
            btnCrearCredito.Size = new Size(140, 43);
            btnCrearCredito.TabIndex = 1;
            btnCrearCredito.Text = "CREAR CREDITO";
            btnCrearCredito.UseVisualStyleBackColor = false;
            btnCrearCredito.Click += btnCrearCredito_Click;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Location = new Point(398, 143);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(119, 23);
            textBoxDni.TabIndex = 2;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(348, 144);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(44, 21);
            labelDni.TabIndex = 3;
            labelDni.Text = "DNI:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(525, 144);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(159, 21);
            labelNombre.TabIndex = 5;
            labelNombre.Text = "Nombre y Apellido:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(679, 143);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(171, 23);
            textBox1.TabIndex = 4;
            // 
            // listCreditos
            // 
            listCreditos.BackColor = SystemColors.InactiveBorder;
            listCreditos.Columns.AddRange(new ColumnHeader[] { columnHeaderCod, columnHeaderConcepto, columnHeaderCuotas, columnHeaderMontoCuota, columnHeaderMontoFaltante });
            listCreditos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listCreditos.FullRowSelect = true;
            listCreditos.GridLines = true;
            listCreditos.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listCreditos.Location = new Point(322, 216);
            listCreditos.Name = "listCreditos";
            listCreditos.Size = new Size(685, 472);
            listCreditos.TabIndex = 6;
            listCreditos.UseCompatibleStateImageBehavior = false;
            listCreditos.View = View.Details;
            // 
            // columnHeaderCod
            // 
            columnHeaderCod.Text = "CODIGO";
            columnHeaderCod.Width = 90;
            // 
            // columnHeaderConcepto
            // 
            columnHeaderConcepto.Text = "CONCEPTO";
            columnHeaderConcepto.Width = 110;
            // 
            // columnHeaderCuotas
            // 
            columnHeaderCuotas.Text = "CUOTAS FALTANTES";
            columnHeaderCuotas.Width = 180;
            // 
            // columnHeaderMontoCuota
            // 
            columnHeaderMontoCuota.Text = "MONTO CUOTA";
            columnHeaderMontoCuota.Width = 140;
            // 
            // columnHeaderMontoFaltante
            // 
            columnHeaderMontoFaltante.Text = "MONTO FALTANTE";
            columnHeaderMontoFaltante.Width = 160;
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.OrangeRed;
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(322, 190);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(685, 23);
            labelTitle.TabIndex = 22;
            labelTitle.Text = "lista de creditos del empleado";
            // 
            // VerCreditosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 700);
            Controls.Add(labelTitle);
            Controls.Add(listCreditos);
            Controls.Add(labelNombre);
            Controls.Add(textBox1);
            Controls.Add(labelDni);
            Controls.Add(textBoxDni);
            Controls.Add(btnCrearCredito);
            Controls.Add(listaEmpComponent1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "VerCreditosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerCreditosForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private Button btnCrearCredito;
        private TextBox textBoxDni;
        private Label labelDni;
        private Label labelNombre;
        private TextBox textBox1;
        private ListView listCreditos;
        private ColumnHeader columnHeaderCod;
        private ColumnHeader columnHeaderConcepto;
        private ColumnHeader columnHeaderCuotas;
        private ColumnHeader columnHeaderMontoCuota;
        private ColumnHeader columnHeaderMontoFaltante;
        private Label labelTitle;
    }
}
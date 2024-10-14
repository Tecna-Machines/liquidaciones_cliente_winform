namespace UI.Screens.CrearContrato
{
    partial class CrearContratoForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            listaEmpComponent1 = new Components.Utils.ListaEmpComponent();
            labelDni = new Label();
            labelNombre = new Label();
            groupBox = new GroupBox();
            textBoxNombre = new TextBox();
            textBoxDni = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxModalidad = new ComboBox();
            textBoxMontoBanco = new TextBox();
            textBoxMontoHora = new TextBox();
            textBoxMontoFijo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox2 = new GroupBox();
            label5 = new Label();
            btnConfirmarContrato = new Button();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(3, 12);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.Size = new Size(304, 690);
            listaEmpComponent1.TabIndex = 0;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(15, 34);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(44, 21);
            labelDni.TabIndex = 1;
            labelDni.Text = "DNI:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(6, 78);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(83, 21);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "NOMBRE:";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxNombre);
            groupBox.Controls.Add(textBoxDni);
            groupBox.Controls.Add(labelDni);
            groupBox.Controls.Add(labelNombre);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Location = new Point(313, 71);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(475, 141);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "datos personales";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.ButtonHighlight;
            textBoxNombre.Location = new Point(95, 80);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(374, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Location = new Point(74, 34);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(395, 23);
            textBoxDni.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxModalidad);
            groupBox1.Controls.Add(textBoxMontoBanco);
            groupBox1.Controls.Add(textBoxMontoHora);
            groupBox1.Controls.Add(textBoxMontoFijo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(313, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 143);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "datos del contrato";
            // 
            // comboBoxModalidad
            // 
            comboBoxModalidad.FormattingEnabled = true;
            comboBoxModalidad.Location = new Point(85, 83);
            comboBoxModalidad.Name = "comboBoxModalidad";
            comboBoxModalidad.Size = new Size(147, 23);
            comboBoxModalidad.TabIndex = 7;
            // 
            // textBoxMontoBanco
            // 
            textBoxMontoBanco.Location = new Point(354, 83);
            textBoxMontoBanco.Name = "textBoxMontoBanco";
            textBoxMontoBanco.Size = new Size(115, 23);
            textBoxMontoBanco.TabIndex = 6;
            textBoxMontoBanco.TextChanged += textBoxMontoFijo_TextChanged;
            // 
            // textBoxMontoHora
            // 
            textBoxMontoHora.Location = new Point(354, 41);
            textBoxMontoHora.Name = "textBoxMontoHora";
            textBoxMontoHora.Size = new Size(115, 23);
            textBoxMontoHora.TabIndex = 5;
            // 
            // textBoxMontoFijo
            // 
            textBoxMontoFijo.Location = new Point(85, 38);
            textBoxMontoFijo.Name = "textBoxMontoFijo";
            textBoxMontoFijo.Size = new Size(147, 23);
            textBoxMontoFijo.TabIndex = 4;
            textBoxMontoFijo.TextChanged += textBoxMontoFijo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(238, 86);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Monto en el banco";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 86);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Modalidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Monto por hora";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "Monto fijo";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(14, 22);
            chart.Name = "chart";
            chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(455, 202);
            chart.TabIndex = 5;
            chart.Text = "chart1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chart);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(313, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 243);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "grafico de distribucion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(409, 29);
            label5.Name = "label5";
            label5.Size = new Size(294, 25);
            label5.TabIndex = 7;
            label5.Text = "CREAR CONTRATO DE TRABAJO";
            // 
            // btnConfirmarContrato
            // 
            btnConfirmarContrato.BackColor = Color.Lime;
            btnConfirmarContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarContrato.Location = new Point(610, 650);
            btnConfirmarContrato.Name = "btnConfirmarContrato";
            btnConfirmarContrato.Size = new Size(178, 43);
            btnConfirmarContrato.TabIndex = 8;
            btnConfirmarContrato.Text = "CONFIRMAR";
            btnConfirmarContrato.UseVisualStyleBackColor = false;
            btnConfirmarContrato.Click += btnConfirmarContrato_Click;
            // 
            // CrearContratoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 705);
            Controls.Add(btnConfirmarContrato);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox);
            Controls.Add(listaEmpComponent1);
            Name = "CrearContratoForm";
            Text = "CrearContratoForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private Label labelDni;
        private Label labelNombre;
        private GroupBox groupBox;
        private TextBox textBoxNombre;
        private TextBox textBoxDni;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxModalidad;
        private TextBox textBoxMontoBanco;
        private TextBox textBoxMontoHora;
        private TextBox textBoxMontoFijo;
        private Label label4;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private GroupBox groupBox2;
        private Label label5;
        private Button btnConfirmarContrato;
    }
}
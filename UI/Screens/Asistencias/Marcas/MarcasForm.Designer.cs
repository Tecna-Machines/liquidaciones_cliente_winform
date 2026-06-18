namespace UI.Screens.Marcas
{
    partial class MarcasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcasForm));
            tablaMarcas = new ListView();
            columDate = new ColumnHeader();
            columnEnt = new ColumnHeader();
            columnSal = new ColumnHeader();
            columnHsTotales = new ColumnHeader();
            columHsExtr = new ColumnHeader();
            columnHsDoble = new ColumnHeader();
            columnTotales = new ColumnHeader();
            labelMarcas = new Label();
            btnAgregarMarca = new Button();
            BtnBuscarMarcas = new Button();
            textBoxDniEmp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxQuincena = new TextBox();
            textBoxMes = new TextBox();
            textBoxAnio = new TextBox();
            SuspendLayout();
            // 
            // tablaMarcas
            // 
            tablaMarcas.Columns.AddRange(new ColumnHeader[] { columDate, columnEnt, columnSal, columnHsTotales, columHsExtr, columnHsDoble, columnTotales });
            tablaMarcas.Dock = DockStyle.Right;
            tablaMarcas.FullRowSelect = true;
            tablaMarcas.GridLines = true;
            tablaMarcas.Location = new Point(381, 24);
            tablaMarcas.Name = "tablaMarcas";
            tablaMarcas.Size = new Size(566, 515);
            tablaMarcas.TabIndex = 20;
            tablaMarcas.UseCompatibleStateImageBehavior = false;
            tablaMarcas.View = View.Details;
            // 
            // columDate
            // 
            columDate.Text = "FECHA";
            columDate.Width = 120;
            // 
            // columnEnt
            // 
            columnEnt.Text = "ENTRADA";
            columnEnt.Width = 65;
            // 
            // columnSal
            // 
            columnSal.Text = "SALIDA";
            // 
            // columnHsTotales
            // 
            columnHsTotales.Text = "COMUNES";
            columnHsTotales.Width = 90;
            // 
            // columHsExtr
            // 
            columHsExtr.Text = "EXTRAS";
            // 
            // columnHsDoble
            // 
            columnHsDoble.Text = "DOBLE";
            // 
            // columnTotales
            // 
            columnTotales.Text = "TOTALES";
            // 
            // labelMarcas
            // 
            labelMarcas.BackColor = Color.DeepSkyBlue;
            labelMarcas.Dock = DockStyle.Top;
            labelMarcas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelMarcas.Location = new Point(0, 0);
            labelMarcas.Name = "labelMarcas";
            labelMarcas.Padding = new Padding(3);
            labelMarcas.Size = new Size(947, 24);
            labelMarcas.TabIndex = 19;
            labelMarcas.Text = "Marcas del periodo";
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarMarca.Location = new Point(102, 191);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(273, 56);
            btnAgregarMarca.TabIndex = 21;
            btnAgregarMarca.Text = "AGREGAR MARCA";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += BtnAgregarMarca_Click;
            // 
            // BtnBuscarMarcas
            // 
            BtnBuscarMarcas.BackColor = SystemColors.ActiveCaption;
            BtnBuscarMarcas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnBuscarMarcas.Location = new Point(102, 118);
            BtnBuscarMarcas.Name = "BtnBuscarMarcas";
            BtnBuscarMarcas.Size = new Size(273, 56);
            BtnBuscarMarcas.TabIndex = 22;
            BtnBuscarMarcas.Text = "BUSCAR MARCAS";
            BtnBuscarMarcas.UseVisualStyleBackColor = false;
            BtnBuscarMarcas.Click += BtnBuscarMarcas_Click;
            // 
            // textBoxDniEmp
            // 
            textBoxDniEmp.Location = new Point(102, 46);
            textBoxDniEmp.Name = "textBoxDniEmp";
            textBoxDniEmp.Size = new Size(273, 23);
            textBoxDniEmp.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 54);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 24;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 25;
            label2.Text = "quincena:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 84);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 26;
            label3.Text = "mes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 84);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 27;
            label4.Text = "año:";
            // 
            // textBoxQuincena
            // 
            textBoxQuincena.Location = new Point(102, 80);
            textBoxQuincena.Name = "textBoxQuincena";
            textBoxQuincena.Size = new Size(56, 23);
            textBoxQuincena.TabIndex = 28;
            // 
            // textBoxMes
            // 
            textBoxMes.Location = new Point(214, 80);
            textBoxMes.Name = "textBoxMes";
            textBoxMes.Size = new Size(56, 23);
            textBoxMes.TabIndex = 29;
            // 
            // textBoxAnio
            // 
            textBoxAnio.Location = new Point(319, 80);
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.Size = new Size(56, 23);
            textBoxAnio.TabIndex = 30;
            // 
            // MarcasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 539);
            Controls.Add(textBoxAnio);
            Controls.Add(textBoxMes);
            Controls.Add(textBoxQuincena);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxDniEmp);
            Controls.Add(BtnBuscarMarcas);
            Controls.Add(btnAgregarMarca);
            Controls.Add(tablaMarcas);
            Controls.Add(labelMarcas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MarcasForm";
            Text = "Marcas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView tablaMarcas;
        private ColumnHeader columDate;
        private ColumnHeader columnEnt;
        private ColumnHeader columnSal;
        private ColumnHeader columnHsTotales;
        private ColumnHeader columHsExtr;
        private ColumnHeader columnHsDoble;
        private Label labelMarcas;
        private Button btnAgregarMarca;
        private ColumnHeader columnTotales;
        private Button BtnBuscarMarcas;
        private TextBox textBoxDniEmp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxQuincena;
        private TextBox textBoxMes;
        private TextBox textBoxAnio;
    }
}
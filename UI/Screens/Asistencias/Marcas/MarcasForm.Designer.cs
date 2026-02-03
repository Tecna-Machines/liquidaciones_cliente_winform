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
            columnDia = new ColumnHeader();
            labelMarcas = new Label();
            btnAgregarMarca = new Button();
            SuspendLayout();
            // 
            // listaMarcas
            // 
            tablaMarcas.Columns.AddRange(new ColumnHeader[] { columDate, columnEnt, columnSal, columnHsTotales, columHsExtr, columnHsDoble, columnDia });
            tablaMarcas.FullRowSelect = true;
            tablaMarcas.GridLines = true;
            tablaMarcas.Location = new Point(179, 52);
            tablaMarcas.Name = "listaMarcas";
            tablaMarcas.Size = new Size(498, 475);
            tablaMarcas.TabIndex = 20;
            tablaMarcas.UseCompatibleStateImageBehavior = false;
            tablaMarcas.View = View.Details;
            // 
            // columDate
            // 
            columDate.Text = "FECHA";
            columDate.Width = 85;
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
            columnHsDoble.Text = "TOTALES";
            // 
            // columnDia
            // 
            columnDia.Text = "DIA";
            columnDia.Width = 73;
            // 
            // labelMarcas
            // 
            labelMarcas.BackColor = Color.DeepSkyBlue;
            labelMarcas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarcas.Location = new Point(179, 25);
            labelMarcas.Name = "labelMarcas";
            labelMarcas.Padding = new Padding(3);
            labelMarcas.Size = new Size(498, 24);
            labelMarcas.TabIndex = 19;
            labelMarcas.Text = "Marcas del periodo";
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregarMarca.Location = new Point(12, 52);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(161, 56);
            btnAgregarMarca.TabIndex = 21;
            btnAgregarMarca.Text = "AGREGAR MARCA";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += BtnAgregarMarca_Click;
            // 
            // MarcasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 539);
            Controls.Add(btnAgregarMarca);
            Controls.Add(tablaMarcas);
            Controls.Add(labelMarcas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MarcasForm";
            Text = "Marcas";
            ResumeLayout(false);
        }

        #endregion

        private ListView tablaMarcas;
        private ColumnHeader columDate;
        private ColumnHeader columnEnt;
        private ColumnHeader columnSal;
        private ColumnHeader columnHsTotales;
        private ColumnHeader columHsExtr;
        private ColumnHeader columnHsDoble;
        private ColumnHeader columnDia;
        private Label labelMarcas;
        private Button btnAgregarMarca;
    }
}
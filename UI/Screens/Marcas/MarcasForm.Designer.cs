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
            listaMarcas = new ListView();
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
            listaMarcas.Columns.AddRange(new ColumnHeader[] { columDate, columnEnt, columnSal, columnHsTotales, columHsExtr, columnHsDoble, columnDia });
            listaMarcas.FullRowSelect = true;
            listaMarcas.GridLines = true;
            listaMarcas.Location = new Point(179, 52);
            listaMarcas.Name = "listaMarcas";
            listaMarcas.Size = new Size(465, 475);
            listaMarcas.TabIndex = 20;
            listaMarcas.UseCompatibleStateImageBehavior = false;
            listaMarcas.View = View.Details;
            // 
            // columDate
            // 
            columDate.Text = "Fecha";
            columDate.Width = 85;
            // 
            // columnEnt
            // 
            columnEnt.Text = "entrada";
            // 
            // columnSal
            // 
            columnSal.Text = "salida";
            // 
            // columnHsTotales
            // 
            columnHsTotales.Text = "Hs total";
            // 
            // columHsExtr
            // 
            columHsExtr.Text = "Hs extra";
            // 
            // columnHsDoble
            // 
            columnHsDoble.Text = "Hs doble";
            // 
            // columnDia
            // 
            columnDia.Text = "Dia";
            columnDia.Width = 73;
            // 
            // labelMarcas
            // 
            labelMarcas.BackColor = Color.DeepSkyBlue;
            labelMarcas.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMarcas.Location = new Point(179, 25);
            labelMarcas.Name = "labelMarcas";
            labelMarcas.Padding = new Padding(3);
            labelMarcas.Size = new Size(465, 24);
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
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // MarcasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 539);
            Controls.Add(btnAgregarMarca);
            Controls.Add(listaMarcas);
            Controls.Add(labelMarcas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MarcasForm";
            Text = "Marcas";
            ResumeLayout(false);
        }

        #endregion

        private ListView listaMarcas;
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
namespace UI.Screens.HacerLiquidacion
{
    partial class CrearItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearItemForm));
            btnRemuneracion = new Button();
            btnRetencion = new Button();
            btnDesc = new Button();
            labelAgre = new Label();
            SuspendLayout();
            // 
            // btnRemuneracion
            // 
            btnRemuneracion.Location = new Point(22, 54);
            btnRemuneracion.Name = "btnRemuneracion";
            btnRemuneracion.Size = new Size(151, 44);
            btnRemuneracion.TabIndex = 0;
            btnRemuneracion.Text = "REMUNERACION";
            btnRemuneracion.UseVisualStyleBackColor = true;
            btnRemuneracion.Click += btnRemuneracion_Click;
            // 
            // btnRetencion
            // 
            btnRetencion.Location = new Point(22, 115);
            btnRetencion.Name = "btnRetencion";
            btnRetencion.Size = new Size(151, 44);
            btnRetencion.TabIndex = 1;
            btnRetencion.Text = "RETENCION";
            btnRetencion.UseVisualStyleBackColor = true;
            btnRetencion.Click += btnRetencion_Click;
            // 
            // btnDesc
            // 
            btnDesc.Location = new Point(22, 180);
            btnDesc.Name = "btnDesc";
            btnDesc.Size = new Size(151, 44);
            btnDesc.TabIndex = 2;
            btnDesc.Text = "DESCUENTO";
            btnDesc.UseVisualStyleBackColor = true;
            btnDesc.Click += btnDesc_Click;
            // 
            // labelAgre
            // 
            labelAgre.AutoSize = true;
            labelAgre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAgre.Location = new Point(39, 20);
            labelAgre.Name = "labelAgre";
            labelAgre.Size = new Size(114, 21);
            labelAgre.TabIndex = 3;
            labelAgre.Text = "Agregar Item:";
            // 
            // CrearItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 243);
            Controls.Add(labelAgre);
            Controls.Add(btnDesc);
            Controls.Add(btnRetencion);
            Controls.Add(btnRemuneracion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearItemForm";
            Text = "CrearItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRemuneracion;
        private Button btnRetencion;
        private Button btnDesc;
        private Label labelAgre;
    }
}
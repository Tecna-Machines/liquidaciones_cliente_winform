namespace UI.Screens.Creditos.VerCredito
{
    partial class VerCreditoForm
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
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            TextDescripcion = new RichTextBox();
            textMontoPrestado = new RichTextBox();
            textMontoDevoler = new RichTextBox();
            textModoPago = new RichTextBox();
            tablaCuotas = new ListView();
            columnNro = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnSeDebita = new ColumnHeader();
            columnEstado = new ColumnHeader();
            labelRemuneraciones = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 113);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(150, 33);
            label8.TabIndex = 44;
            label8.Text = "Modo de pago:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(838, 56);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(150, 33);
            label6.TabIndex = 42;
            label6.Text = "Monto a devolver:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(472, 56);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(150, 33);
            label5.TabIndex = 41;
            label5.Text = "Monto prestado:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(150, 33);
            label1.TabIndex = 39;
            label1.Text = "Descripcion:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // TextDescripcion
            // 
            TextDescripcion.BackColor = SystemColors.GrayText;
            TextDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TextDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TextDescripcion.ForeColor = Color.WhiteSmoke;
            TextDescripcion.Location = new Point(168, 56);
            TextDescripcion.Name = "TextDescripcion";
            TextDescripcion.ReadOnly = true;
            TextDescripcion.Size = new Size(298, 33);
            TextDescripcion.TabIndex = 46;
            TextDescripcion.Text = "";
            // 
            // textMontoPrestado
            // 
            textMontoPrestado.BackColor = SystemColors.GrayText;
            textMontoPrestado.BorderStyle = BorderStyle.FixedSingle;
            textMontoPrestado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textMontoPrestado.ForeColor = Color.WhiteSmoke;
            textMontoPrestado.Location = new Point(628, 56);
            textMontoPrestado.Name = "textMontoPrestado";
            textMontoPrestado.ReadOnly = true;
            textMontoPrestado.Size = new Size(204, 33);
            textMontoPrestado.TabIndex = 47;
            textMontoPrestado.Text = "";
            // 
            // textMontoDevoler
            // 
            textMontoDevoler.BackColor = SystemColors.GrayText;
            textMontoDevoler.BorderStyle = BorderStyle.FixedSingle;
            textMontoDevoler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textMontoDevoler.ForeColor = Color.WhiteSmoke;
            textMontoDevoler.Location = new Point(994, 56);
            textMontoDevoler.Name = "textMontoDevoler";
            textMontoDevoler.ReadOnly = true;
            textMontoDevoler.Size = new Size(204, 33);
            textMontoDevoler.TabIndex = 48;
            textMontoDevoler.Text = "";
            // 
            // textModoPago
            // 
            textModoPago.BackColor = SystemColors.GrayText;
            textModoPago.BorderStyle = BorderStyle.FixedSingle;
            textModoPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textModoPago.ForeColor = Color.WhiteSmoke;
            textModoPago.Location = new Point(168, 113);
            textModoPago.Name = "textModoPago";
            textModoPago.ReadOnly = true;
            textModoPago.Size = new Size(298, 33);
            textModoPago.TabIndex = 52;
            textModoPago.Text = "";
            // 
            // tablaCuotas
            // 
            tablaCuotas.Columns.AddRange(new ColumnHeader[] { columnNro, columnDesc, columnMonto, columnSeDebita, columnEstado });
            tablaCuotas.FullRowSelect = true;
            tablaCuotas.GridLines = true;
            tablaCuotas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaCuotas.Location = new Point(12, 204);
            tablaCuotas.Name = "tablaCuotas";
            tablaCuotas.Size = new Size(670, 219);
            tablaCuotas.TabIndex = 54;
            tablaCuotas.UseCompatibleStateImageBehavior = false;
            tablaCuotas.View = View.Details;
            // 
            // columnNro
            // 
            columnNro.Text = "Nro";
            columnNro.Width = 40;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descripcion";
            columnDesc.Width = 200;
            // 
            // columnMonto
            // 
            columnMonto.Text = "Monto";
            columnMonto.Width = 100;
            // 
            // columnSeDebita
            // 
            columnSeDebita.Text = "Se debita:";
            columnSeDebita.Width = 130;
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            columnEstado.Width = 120;
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(12, 177);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(670, 24);
            labelRemuneraciones.TabIndex = 53;
            labelRemuneraciones.Text = "Cuotas";
            // 
            // VerCreditoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 450);
            Controls.Add(tablaCuotas);
            Controls.Add(labelRemuneraciones);
            Controls.Add(textModoPago);
            Controls.Add(textMontoDevoler);
            Controls.Add(textMontoPrestado);
            Controls.Add(TextDescripcion);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "VerCreditoForm";
            Text = "VerCreditoForm";
            ResumeLayout(false);
        }

        #endregion
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label1;
        private RichTextBox TextDescripcion;
        private RichTextBox textMontoPrestado;
        private RichTextBox textMontoDevoler;
        private RichTextBox textModoPago;
        private ListView tablaCuotas;
        private ColumnHeader columnNro;
        private ColumnHeader columnDesc;
        private ColumnHeader columnMonto;
        private ColumnHeader columnSeDebita;
        private ColumnHeader columnEstado;
        private Label labelRemuneraciones;
    }
}
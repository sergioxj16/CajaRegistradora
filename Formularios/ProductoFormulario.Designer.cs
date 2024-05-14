namespace CajaRegistradora.Formularios
{
    partial class ProductoFormulario
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
            botonVolver = new Button();
            label1 = new Label();
            codigoProductoTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nombreTextBox = new TextBox();
            precioTextBox = new TextBox();
            Precio = new Label();
            botonAceptar = new Button();
            SuspendLayout();
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(53, 57);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(94, 29);
            botonVolver.TabIndex = 0;
            botonVolver.Text = "VOLVER";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(853, 243);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 1;
            label1.Text = "Codigo del producto";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // codigoProductoTextBox
            // 
            codigoProductoTextBox.Location = new Point(223, 147);
            codigoProductoTextBox.Name = "codigoProductoTextBox";
            codigoProductoTextBox.Size = new Size(197, 27);
            codigoProductoTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 124);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 177);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(223, 200);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(197, 27);
            nombreTextBox.TabIndex = 1;
            // 
            // precioTextBox
            // 
            precioTextBox.Location = new Point(223, 254);
            precioTextBox.Name = "precioTextBox";
            precioTextBox.Size = new Size(197, 27);
            precioTextBox.TabIndex = 2;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(223, 231);
            Precio.Name = "Precio";
            Precio.Size = new Size(50, 20);
            Precio.TabIndex = 7;
            Precio.Text = "Precio";
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(271, 308);
            botonAceptar.Name = "botonAceptar";
            botonAceptar.Size = new Size(94, 29);
            botonAceptar.TabIndex = 3;
            botonAceptar.Text = "Aceptar";
            botonAceptar.UseVisualStyleBackColor = true;
            botonAceptar.Click += botonAceptar_Click;
            // 
            // ProductoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 453);
            Controls.Add(botonAceptar);
            Controls.Add(Precio);
            Controls.Add(precioTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(codigoProductoTextBox);
            Controls.Add(label1);
            Controls.Add(botonVolver);
            Name = "ProductoFormulario";
            StartPosition = FormStartPosition.Manual;
            Text = "Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonVolver;
        private Label label1;
        private TextBox codigoProductoTextBox;
        private Label label2;
        private Label label3;
        private TextBox nombreTextBox;
        private TextBox precioTextBox;
        private Label Precio;
        private Button botonAceptar;
    }
}
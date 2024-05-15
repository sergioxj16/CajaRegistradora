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
            codigoProductoTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            nombreTextBox = new TextBox();
            precioTextBox = new TextBox();
            Precio = new Label();
            botonAceptar = new Button();
            label1 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // botonVolver
            // 
            botonVolver.Location = new Point(53, 57);
            botonVolver.Name = "botonVolver";
            botonVolver.Size = new Size(94, 29);
            botonVolver.TabIndex = 4;
            botonVolver.Text = "VOLVER";
            botonVolver.UseVisualStyleBackColor = true;
            botonVolver.Click += botonVolver_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 95);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 8;
            label1.Text = "Crear producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 95);
            label4.Name = "label4";
            label4.Size = new Size(128, 20);
            label4.TabIndex = 9;
            label4.Text = "Eliminar producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(473, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 27);
            textBox1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(517, 180);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 124);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 12;
            label5.Text = "Codigo";
            // 
            // ProductoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 453);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(botonAceptar);
            Controls.Add(Precio);
            Controls.Add(precioTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(codigoProductoTextBox);
            Controls.Add(botonVolver);
            Name = "ProductoFormulario";
            StartPosition = FormStartPosition.Manual;
            Text = "Producto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonVolver;
        private TextBox codigoProductoTextBox;
        private Label label2;
        private Label label3;
        private TextBox nombreTextBox;
        private TextBox precioTextBox;
        private Label Precio;
        private Button botonAceptar;
        private Label label1;
        private Label label4;
        private TextBox textBox1;
        private Button button1;
        private Label label5;
    }
}
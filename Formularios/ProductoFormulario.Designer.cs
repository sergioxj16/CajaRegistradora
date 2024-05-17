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
            precioVentaTextBox = new TextBox();
            Precio = new Label();
            botonAceptar = new Button();
            label1 = new Label();
            label4 = new Label();
            codigoProductoEliminarTextBox = new TextBox();
            botonBorrarProducto = new Button();
            label5 = new Label();
            precioCompraTextBox = new TextBox();
            stockTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
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
            codigoProductoTextBox.Location = new Point(223, 150);
            codigoProductoTextBox.Name = "codigoProductoTextBox";
            codigoProductoTextBox.Size = new Size(197, 27);
            codigoProductoTextBox.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 127);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Codigo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 189);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 4;
            label3.Text = "Nombre";
            // 
            // nombreTextBox
            // 
            nombreTextBox.Location = new Point(223, 210);
            nombreTextBox.Name = "nombreTextBox";
            nombreTextBox.Size = new Size(197, 27);
            nombreTextBox.TabIndex = 1;
            // 
            // precioVentaTextBox
            // 
            precioVentaTextBox.Location = new Point(223, 260);
            precioVentaTextBox.Name = "precioVentaTextBox";
            precioVentaTextBox.Size = new Size(197, 27);
            precioVentaTextBox.TabIndex = 2;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Location = new Point(223, 240);
            Precio.Name = "Precio";
            Precio.Size = new Size(90, 20);
            Precio.TabIndex = 7;
            Precio.Text = "Precio venta";
            // 
            // botonAceptar
            // 
            botonAceptar.Location = new Point(274, 412);
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
            // codigoProductoEliminarTextBox
            // 
            codigoProductoEliminarTextBox.Location = new Point(473, 147);
            codigoProductoEliminarTextBox.Name = "codigoProductoEliminarTextBox";
            codigoProductoEliminarTextBox.Size = new Size(197, 27);
            codigoProductoEliminarTextBox.TabIndex = 10;
            // 
            // botonBorrarProducto
            // 
            botonBorrarProducto.Location = new Point(517, 180);
            botonBorrarProducto.Name = "botonBorrarProducto";
            botonBorrarProducto.Size = new Size(94, 29);
            botonBorrarProducto.TabIndex = 11;
            botonBorrarProducto.Text = "Confirmar";
            botonBorrarProducto.UseVisualStyleBackColor = true;
            botonBorrarProducto.Click += botonBorrarProducto_Click;
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
            // precioCompraTextBox
            // 
            precioCompraTextBox.Location = new Point(223, 320);
            precioCompraTextBox.Name = "precioCompraTextBox";
            precioCompraTextBox.Size = new Size(197, 27);
            precioCompraTextBox.TabIndex = 13;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(223, 380);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(197, 27);
            stockTextBox.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(223, 297);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 15;
            label6.Text = "Precio compra";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(223, 357);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 16;
            label7.Text = "Stock";
            // 
            // ProductoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 531);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(stockTextBox);
            Controls.Add(precioCompraTextBox);
            Controls.Add(label5);
            Controls.Add(botonBorrarProducto);
            Controls.Add(codigoProductoEliminarTextBox);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(botonAceptar);
            Controls.Add(Precio);
            Controls.Add(precioVentaTextBox);
            Controls.Add(nombreTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(codigoProductoTextBox);
            Controls.Add(botonVolver);
            Name = "ProductoFormulario";
            StartPosition = FormStartPosition.Manual;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonVolver;
        private TextBox codigoProductoTextBox;
        private Label label2;
        private Label label3;
        private TextBox nombreTextBox;
        private TextBox precioVentaTextBox;
        private Label Precio;
        private Button botonAceptar;
        private Label label1;
        private Label label4;
        private TextBox codigoProductoEliminarTextBox;
        private Button botonBorrarProducto;
        private Label label5;
        private TextBox precioCompraTextBox;
        private TextBox stockTextBox;
        private Label label6;
        private Label label7;
    }
}
namespace CajaRegistradora.Formularios
{
    partial class GestorDeUsuariosFormulario
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
            textoCrearUsuario = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            botonVolverAtras = new Button();
            repitaContrasena = new TextBox();
            SuspendLayout();
            // 
            // textoCrearUsuario
            // 
            textoCrearUsuario.AutoSize = true;
            textoCrearUsuario.Location = new Point(252, 300);
            textoCrearUsuario.Name = "textoCrearUsuario";
            textoCrearUsuario.Size = new Size(120, 20);
            textoCrearUsuario.TabIndex = 0;
            textoCrearUsuario.Text = "CREAR USUARIO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 337);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(133, 27);
            textBox2.TabIndex = 2;
            textBox2.Tag = "";
            textBox2.Text = "Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(252, 467);
            button1.Name = "button1";
            button1.Size = new Size(133, 29);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // botonVolverAtras
            // 
            botonVolverAtras.Font = new Font("Segoe UI", 12F);
            botonVolverAtras.Location = new Point(123, 111);
            botonVolverAtras.Name = "botonVolverAtras";
            botonVolverAtras.Size = new Size(82, 37);
            botonVolverAtras.TabIndex = 4;
            botonVolverAtras.Text = "Volver";
            botonVolverAtras.UseVisualStyleBackColor = true;
            botonVolverAtras.Click += button2_Click;
            // 
            // repitaContrasena
            // 
            repitaContrasena.Location = new Point(252, 434);
            repitaContrasena.Name = "repitaContrasena";
            repitaContrasena.Size = new Size(133, 27);
            repitaContrasena.TabIndex = 5;
            // 
            // GestorDeUsuariosFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(repitaContrasena);
            Controls.Add(botonVolverAtras);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textoCrearUsuario);
            Name = "GestorDeUsuariosFormulario";
            Text = "GestorDeUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoCrearUsuario;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button botonVolverAtras;
        private TextBox repitaContrasena;
    }
}
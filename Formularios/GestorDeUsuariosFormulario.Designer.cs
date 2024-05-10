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
            textBoxUsuarioCrear = new TextBox();
            textBoxContrasenaCrearUsuario = new TextBox();
            botonConfirmarCrearUsuario = new Button();
            botonVolverAtras = new Button();
            repitaContrasena = new TextBox();
            textoBorrarUsuario = new Label();
            botonConfirmarBorrarUsuario = new Button();
            textBoxUsuarioBorrar = new TextBox();
            textBoxConfirmar = new TextBox();
            textoConfirmar = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            botonMostrarContrasena = new CheckBox();
            listBoxUsuarios = new ListBox();
            botonRefrescarUsuarios = new Button();
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
            // textBoxUsuarioCrear
            // 
            textBoxUsuarioCrear.Location = new Point(252, 354);
            textBoxUsuarioCrear.Name = "textBoxUsuarioCrear";
            textBoxUsuarioCrear.Size = new Size(133, 27);
            textBoxUsuarioCrear.TabIndex = 1;
            textBoxUsuarioCrear.TextChanged += textBoxUsuarioCrear_TextChanged;
            // 
            // textBoxContrasenaCrearUsuario
            // 
            textBoxContrasenaCrearUsuario.Location = new Point(252, 407);
            textBoxContrasenaCrearUsuario.Name = "textBoxContrasenaCrearUsuario";
            textBoxContrasenaCrearUsuario.Size = new Size(133, 27);
            textBoxContrasenaCrearUsuario.TabIndex = 2;
            textBoxContrasenaCrearUsuario.Tag = "";
            textBoxContrasenaCrearUsuario.TextChanged += textBoxContrasenaCrearUsuario_TextChanged;
            // 
            // botonConfirmarCrearUsuario
            // 
            botonConfirmarCrearUsuario.Location = new Point(252, 526);
            botonConfirmarCrearUsuario.Name = "botonConfirmarCrearUsuario";
            botonConfirmarCrearUsuario.Size = new Size(133, 29);
            botonConfirmarCrearUsuario.TabIndex = 4;
            botonConfirmarCrearUsuario.Text = "CONFIRMAR";
            botonConfirmarCrearUsuario.UseVisualStyleBackColor = true;
            botonConfirmarCrearUsuario.Click += botonConfirmarCrearUsuario_Click;
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
            repitaContrasena.Location = new Point(252, 470);
            repitaContrasena.Name = "repitaContrasena";
            repitaContrasena.Size = new Size(133, 27);
            repitaContrasena.TabIndex = 3;
            repitaContrasena.TextChanged += repitaContrasena_TextChanged;
            // 
            // textoBorrarUsuario
            // 
            textoBorrarUsuario.AutoSize = true;
            textoBorrarUsuario.Location = new Point(551, 300);
            textoBorrarUsuario.Name = "textoBorrarUsuario";
            textoBorrarUsuario.Size = new Size(132, 20);
            textoBorrarUsuario.TabIndex = 6;
            textoBorrarUsuario.Text = "BORRAR USUARIO";
            // 
            // botonConfirmarBorrarUsuario
            // 
            botonConfirmarBorrarUsuario.Location = new Point(551, 467);
            botonConfirmarBorrarUsuario.Name = "botonConfirmarBorrarUsuario";
            botonConfirmarBorrarUsuario.Size = new Size(133, 29);
            botonConfirmarBorrarUsuario.TabIndex = 7;
            botonConfirmarBorrarUsuario.Text = "CONFIRMAR";
            botonConfirmarBorrarUsuario.UseVisualStyleBackColor = true;
            botonConfirmarBorrarUsuario.Click += botonConfirmarBorrarUsuario_Click;
            // 
            // textBoxUsuarioBorrar
            // 
            textBoxUsuarioBorrar.Location = new Point(550, 354);
            textBoxUsuarioBorrar.Name = "textBoxUsuarioBorrar";
            textBoxUsuarioBorrar.Size = new Size(133, 27);
            textBoxUsuarioBorrar.TabIndex = 8;
            // 
            // textBoxConfirmar
            // 
            textBoxConfirmar.Location = new Point(550, 417);
            textBoxConfirmar.Name = "textBoxConfirmar";
            textBoxConfirmar.Size = new Size(133, 27);
            textBoxConfirmar.TabIndex = 9;
            // 
            // textoConfirmar
            // 
            textoConfirmar.AutoSize = true;
            textoConfirmar.Location = new Point(550, 394);
            textoConfirmar.Name = "textoConfirmar";
            textoConfirmar.Size = new Size(155, 20);
            textoConfirmar.TabIndex = 10;
            textoConfirmar.Text = "Escriba \"CONFIRMAR\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 331);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 11;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(252, 384);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 12;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 447);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 13;
            label3.Text = "Repita contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(551, 331);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 14;
            label4.Text = "Usuario";
            // 
            // botonMostrarContrasena
            // 
            botonMostrarContrasena.AutoSize = true;
            botonMostrarContrasena.Location = new Point(252, 496);
            botonMostrarContrasena.Name = "botonMostrarContrasena";
            botonMostrarContrasena.Size = new Size(158, 24);
            botonMostrarContrasena.TabIndex = 15;
            botonMostrarContrasena.Text = "Mostrar contraseña";
            botonMostrarContrasena.UseVisualStyleBackColor = true;
            botonMostrarContrasena.CheckedChanged += botonMostrarContrasena_CheckedChanged;
            // 
            // listBoxUsuarios
            // 
            listBoxUsuarios.FormattingEnabled = true;
            listBoxUsuarios.Location = new Point(782, 297);
            listBoxUsuarios.Name = "listBoxUsuarios";
            listBoxUsuarios.Size = new Size(287, 304);
            listBoxUsuarios.TabIndex = 16;
            // 
            // botonRefrescarUsuarios
            // 
            botonRefrescarUsuarios.Location = new Point(979, 265);
            botonRefrescarUsuarios.Name = "botonRefrescarUsuarios";
            botonRefrescarUsuarios.Size = new Size(90, 26);
            botonRefrescarUsuarios.TabIndex = 17;
            botonRefrescarUsuarios.Text = "Refrescar";
            botonRefrescarUsuarios.UseVisualStyleBackColor = true;
            botonRefrescarUsuarios.Click += botonRefrescarUsuarios_Click;
            // 
            // GestorDeUsuariosFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(botonRefrescarUsuarios);
            Controls.Add(listBoxUsuarios);
            Controls.Add(botonMostrarContrasena);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textoConfirmar);
            Controls.Add(textBoxConfirmar);
            Controls.Add(textBoxUsuarioBorrar);
            Controls.Add(botonConfirmarBorrarUsuario);
            Controls.Add(textoBorrarUsuario);
            Controls.Add(repitaContrasena);
            Controls.Add(botonVolverAtras);
            Controls.Add(botonConfirmarCrearUsuario);
            Controls.Add(textBoxContrasenaCrearUsuario);
            Controls.Add(textBoxUsuarioCrear);
            Controls.Add(textoCrearUsuario);
            Name = "GestorDeUsuariosFormulario";
            Text = "GestorDeUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoCrearUsuario;
        private TextBox textBoxUsuarioCrear;
        private TextBox textBoxContrasenaCrearUsuario;
        private Button botonConfirmarCrearUsuario;
        private Button botonVolverAtras;
        private TextBox repitaContrasena;
        private Label textoBorrarUsuario;
        private Button botonConfirmarBorrarUsuario;
        private TextBox textBoxUsuarioBorrar;
        private TextBox textBoxConfirmar;
        private Label textoConfirmar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox botonMostrarContrasena;
        private ListBox listBoxUsuarios;
        private Button botonRefrescarUsuarios;
    }
}
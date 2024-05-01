using CajaRegistradora.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaRegistradora
{
    public partial class InicioFormulario : Form
    {
        public InicioFormulario()
        {
            InitializeComponent();
            //Oculta el text introducido y los cambia por *
            textBoxContrasena.PasswordChar = '*';
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //Validar al pulsar intro
            this.KeyDown += InicioFormulario_KeyDown;
        }

        private readonly string usuarioAdmin = "admin";
        private readonly string contrasenaAdmin = "admin123";

        private void InitializeComponent()
        {
            mensajeBienvenida = new Label();
            mensajeUsuario = new Label();
            mensajeContrasena = new Label();
            botonInicioSesion = new Button();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            mensajeContrasenaOlvidada = new Label();
            SuspendLayout();
            // 
            // mensajeBienvenida
            // 
            mensajeBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mensajeBienvenida.AutoSize = true;
            mensajeBienvenida.Font = new Font("Segoe UI", 12F);
            mensajeBienvenida.Location = new Point(251, 58);
            mensajeBienvenida.Name = "mensajeBienvenida";
            mensajeBienvenida.Size = new Size(124, 28);
            mensajeBienvenida.TabIndex = 0;
            mensajeBienvenida.Text = "BIENVENIDO";
            mensajeBienvenida.Click += label1_Click;
            // 
            // mensajeUsuario
            // 
            mensajeUsuario.AutoSize = true;
            mensajeUsuario.Location = new Point(229, 139);
            mensajeUsuario.Name = "mensajeUsuario";
            mensajeUsuario.Size = new Size(59, 20);
            mensajeUsuario.TabIndex = 1;
            mensajeUsuario.Text = "Usuario";
            // 
            // mensajeContrasena
            // 
            mensajeContrasena.AutoSize = true;
            mensajeContrasena.Location = new Point(229, 204);
            mensajeContrasena.Name = "mensajeContrasena";
            mensajeContrasena.Size = new Size(83, 20);
            mensajeContrasena.TabIndex = 2;
            mensajeContrasena.Text = "Contraseña";
            // 
            // botonInicioSesion
            // 
            botonInicioSesion.Location = new Point(229, 286);
            botonInicioSesion.Name = "botonInicioSesion";
            botonInicioSesion.Size = new Size(166, 29);
            botonInicioSesion.TabIndex = 3;
            botonInicioSesion.Text = "Iniciar sesion";
            botonInicioSesion.UseVisualStyleBackColor = true;
            botonInicioSesion.Click += botonInicioSesion_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsuario.Location = new Point(229, 162);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(166, 27);
            textBoxUsuario.TabIndex = 4;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Location = new Point(229, 227);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.Size = new Size(166, 27);
            textBoxContrasena.TabIndex = 5;
            // 
            // mensajeContrasenaOlvidada
            // 
            mensajeContrasenaOlvidada.AutoSize = true;
            mensajeContrasenaOlvidada.Font = new Font("Segoe UI", 7F);
            mensajeContrasenaOlvidada.Location = new Point(229, 257);
            mensajeContrasenaOlvidada.Name = "mensajeContrasenaOlvidada";
            mensajeContrasenaOlvidada.Size = new Size(118, 15);
            mensajeContrasenaOlvidada.TabIndex = 6;
            mensajeContrasenaOlvidada.Text = "Contraseña olividada";
            // 
            // InicioFormulario
            // 
            ClientSize = new Size(629, 453);
            Controls.Add(mensajeContrasenaOlvidada);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxUsuario);
            Controls.Add(botonInicioSesion);
            Controls.Add(mensajeContrasena);
            Controls.Add(mensajeUsuario);
            Controls.Add(mensajeBienvenida);
            Name = "InicioFormulario";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InicioFormulario_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Realizar la validación de las credenciales
                ValidarCredenciales();
            }
        }

        private void botonInicioSesion_Click(object sender, EventArgs e)
        {
            // Validar las credenciales al hacer clic en el botón de inicio de sesión
            ValidarCredenciales();
        }

        private void ValidarCredenciales()
        {
            // Obtener las credenciales ingresadas
            string usuarioIngresado = textBoxUsuario.Text;
            string contrasenaIngresada = textBoxContrasena.Text;

            // Validar las credenciales
            if (usuarioIngresado == usuarioAdmin && contrasenaIngresada == contrasenaAdmin)
            {
                // Credenciales válidas: mostrar el formulario principal
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

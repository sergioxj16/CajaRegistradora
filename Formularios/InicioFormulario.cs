using CajaRegistradora.Clases;
using CajaRegistradora.Formularios;

namespace CajaRegistradora
{
    public partial class InicioFormulario : Form
    {
        public InicioFormulario()
        {
            InitializeComponent();
            textBoxContrasena.PasswordChar = '*';
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AcceptButton = null;
            this.KeyPreview = true;
            this.KeyDown += InicioFormulario_KeyDown;

        }

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
            mensajeContrasena.Text = "Contrasena";
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
            textBoxUsuario.Size = new Size(164, 27);
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
            mensajeContrasenaOlvidada.Text = "Contrasena olividada";
            // 
            // InicioFormulario
            // 
            ClientSize = new Size(627, 453);
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

        private void InicioFormulario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarCredenciales();
            }
        }

        private void botonInicioSesion_Click(object sender, EventArgs e)
        {
            ValidarCredenciales();
        }

        private void ValidarCredenciales()
        {
            string usuarioIngresado = textBoxUsuario.Text;
            string contrasenaIngresada = textBoxContrasena.Text;

            if (GestorUsuarios.VerificarCredenciales(usuarioIngresado, contrasenaIngresada))
            {

                if(usuarioIngresado == "admin")
                {
                    botonDevolucion menuAdmin = new botonDevolucion();
                    menuAdmin.Show();
                    this.Hide();
                }
                else
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contrasena incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using CajaRegistradora.Formularios;

namespace CajaRegistradora
{
    partial class InicioFormulario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private Label mensajeBienvenida;
        private Label mensajeUsuario;
        private Label mensajeContrasena;
        private Button botonInicioSesion;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private Label mensajeContrasenaOlvidada;
    }
}
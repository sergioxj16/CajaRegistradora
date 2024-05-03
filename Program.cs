using CajaRegistradora.Clases;

namespace CajaRegistradora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            GestorUsuarios.CargarUsuariosDesdeArchivo("Datos/usuarios.txt");
            ApplicationConfiguration.Initialize();
            Application.Run(new InicioFormulario());
        }
    }
}

using CajaRegistradora.Clases;
using CajaRegistradora.Formularios;

namespace CajaRegistradora
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            GestorUsuarios.CargarUsuariosDesdeArchivo();
            ApplicationConfiguration.Initialize();

            Inventario inventario = new Inventario();
            inventario.CargarInventarioDesdeArchivo();
            inventario.GuardarInventarioEnArchivo();

            Application.Run(new InicioFormulario());
        }
    }
}

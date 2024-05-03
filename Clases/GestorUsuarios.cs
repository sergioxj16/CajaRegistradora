using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaRegistradora.Clases
{
    public static class GestorUsuarios
    {
        private static Dictionary<string, string> usuarios = new Dictionary<string, string>();
        public static Dictionary<string, string> Usuarios { get => usuarios; }

        public static void CargarUsuariosDesdeArchivo(string rutaArchivo)
        {
            try
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    string[] datosUsuario = linea.Split(':');
                    string nombreUsuario = datosUsuario[0];
                    string contrasenaUsuario = datosUsuario[1];
                    usuarios.Add(nombreUsuario, contrasenaUsuario);
                }
                MessageBox.Show("Carga usuarios");
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("No encontrador fichero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error usuarios " + ex.Message);
                Console.WriteLine("Error al cargar usuarios desde el archivo: " + ex.Message);
            }
        }

        public static bool VerificarCredenciales(string nombreUsuario, string contrasena)
        {
            if (usuarios.ContainsKey(nombreUsuario) && usuarios[nombreUsuario] == contrasena)
            {
                return true;
            }
            return false;
        }
    }
}

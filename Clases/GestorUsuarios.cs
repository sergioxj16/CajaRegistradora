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
        const string rutaArchivo = @"Datos\usuarios.txt";

        public static void CargarUsuariosDesdeArchivo()
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
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("No encontrador fichero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error usuarios " + ex.Message);
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

        public static void GuardarUsuarioEnArchivo( string nombreUsuario, string contrasena)
        {
            try
            {
                usuarios.Add(nombreUsuario, contrasena);
                using (StreamWriter escribirFichero = new StreamWriter(rutaArchivo, true))
                {
                    escribirFichero.WriteLine($"{ nombreUsuario}:{contrasena}");
                }
                MessageBox.Show("Usuario guardado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
        }
        public static void BorrarUsuario(string nombreUsuario)
        {
            try
            {
                if (usuarios.ContainsKey(nombreUsuario))
                {
                    usuarios.Remove(nombreUsuario);

                    ActualizarArchivoUsuarios();

                    MessageBox.Show("Usuario eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }

        private static void ActualizarArchivoUsuarios()
        {
            try
            {
                using (StreamWriter escribirFichero = new StreamWriter(rutaArchivo, false))
                {
                    foreach (var usuario in usuarios)
                    {
                        escribirFichero.WriteLine($"{usuario.Key}:{usuario.Value}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el archivo de usuarios: " + ex.Message);
            }
        }
    }
}

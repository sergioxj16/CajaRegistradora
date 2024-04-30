using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CajaRegistradora
{
    internal abstract class Usuario
    {
        private static Dictionary<string, string> usuarios = new Dictionary<string, string>();

        string nombre;
        string password;
        bool esAdmin;

        public Usuario(string nombre, string password, bool esAdmin)
        {
            this.nombre = nombre;
            this.password = password;
            this.esAdmin = esAdmin;

            usuarios.Add(nombre, password);
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }

        public static bool VerificarCredenciales(string nombre, string password)
        {
            bool autorizado = false;
            if (usuarios.ContainsKey(nombre) && usuarios[nombre] == password)
            {
                autorizado = true;
            }
            else
            {
                autorizado = false;
            }
            return autorizado;
        }
    }
}

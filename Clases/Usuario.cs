using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaRegistradora
{
    internal abstract class Usuario
    {
        string nombre;
        string password;
        bool esAdmin;

        public Usuario(string nombre, string password, bool esAdmin)
        {
            this.nombre = nombre;
            this.password = password;
            this.esAdmin = esAdmin;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Password { get => password; set => password = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
    }
}

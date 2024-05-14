using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaRegistradora.Clases
{ 
    public static class Autenticador
    {
        public static bool Autenticar(string nombreUsuario, string contrasena)
        {
            return Usuario.VerificarCredenciales(nombreUsuario, contrasena);
        }
    }

}

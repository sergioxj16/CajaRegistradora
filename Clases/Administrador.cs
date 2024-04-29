using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaRegistradora.Clases
{
    internal class Administrador : Usuario
    {
        public Administrador(string username, string password) : base(username, password, false)
        {
        }
    }
}

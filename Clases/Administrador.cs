using System;
using System.Collections.Generic;
using System.IO;

namespace CajaRegistradora.Clases
{
    internal class Administrador : Usuario
    {
        public Administrador(string nombre, string password) : base(nombre, password)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajaRegistradora.Clases
{
    internal class UsuarioNormal : Usuario
    {
        public UsuarioNormal(string username, string password) : base(username, password, false)
        {
        }
    }
}

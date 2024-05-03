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

        public static void CrearUsuario(string nombre, string contrasena)
        {
            if (!GestorUsuarios.Usuarios.ContainsKey(nombre))
            {
                GestorUsuarios.Usuarios.Add(nombre, contrasena);
                Console.WriteLine("Usuario creado exitosamente.");
            }
            else
            {
                Console.WriteLine("El nombre de usuario ya existe. Por favor, elija otro nombre.");
            }
        }
    }
}

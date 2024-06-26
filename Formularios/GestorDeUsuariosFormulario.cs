﻿using CajaRegistradora.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajaRegistradora.Formularios
{
    public partial class GestorDeUsuariosFormulario : Form
    {
        public GestorDeUsuariosFormulario()
        {
            InitializeComponent();
            CargarUsuariosEnListBox();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdminFormulario menuAdminFormulario = new MenuAdminFormulario();
            menuAdminFormulario.Show();
            this.Hide();
        }
        private void textBoxUsuarioCrear_TextChanged(object sender, EventArgs e)
        {

        }

        private void repitaContrasena_TextChanged(object sender, EventArgs e)
        {
            if (botonMostrarContrasena.Checked)
            {
                repitaContrasena.PasswordChar = '\0';
            }
            else
            {
                repitaContrasena.PasswordChar = '*';
            }
        }

        private void textBoxContrasenaCrearUsuario_TextChanged(object sender, EventArgs e)
        {

            if (botonMostrarContrasena.Checked)
            {

                textBoxContrasenaCrearUsuario.PasswordChar = '\0';
            }
            else
            {
                textBoxContrasenaCrearUsuario.PasswordChar = '*';
            }
        }

        private void botonMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if (botonMostrarContrasena.Checked)
            {
                textBoxContrasenaCrearUsuario.PasswordChar = '\0';
                repitaContrasena.PasswordChar = '\0';
            }
            else
            {
                textBoxContrasenaCrearUsuario.PasswordChar = '*';
                repitaContrasena.PasswordChar = '*';
            }
        }

        private void botonConfirmarCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuarioCrear.Text.Trim();
            string contrasena = textBoxContrasenaCrearUsuario.Text;
            string repetirContrasena = repitaContrasena.Text;

            if (GestorUsuarios.Usuarios.ContainsKey(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro nombre.");
            }
            else if (contrasena != repetirContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtalo de nuevo.");
            }
            else if (nombreUsuario == null || nombreUsuario == "")
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío. Por favor, ingrésalo.");
            }
            else if (contrasena == null || contrasena == "")
            {
                MessageBox.Show("El campo contraseña no puede estar vacío. Por favor, ingrésalo.");
            }
            else if (contrasena == repetirContrasena && !GestorUsuarios.Usuarios.ContainsKey(nombreUsuario))
            {
                GestorUsuarios.GuardarUsuarioEnArchivo(nombreUsuario, contrasena);
                CargarUsuariosEnListBox();
            }
            else
            {
                MessageBox.Show("Error desconocido");
            }
        }

        private void botonRefrescarUsuarios_Click(object sender, EventArgs e)
        {
            CargarUsuariosEnListBox();
        }

        private void CargarUsuariosEnListBox()
        {
            listBoxUsuarios.Items.Clear();

            foreach (var usuario in GestorUsuarios.Usuarios)
            {
                listBoxUsuarios.Items.Add(usuario.Key);
            }
        }

        private void botonConfirmarBorrarUsuario_Click(object sender, EventArgs e)
        {
            string nombreUsuario = textBoxUsuarioBorrar.Text.Trim();
            string confirmacion = textBoxConfirmar.Text;

            if (!GestorUsuarios.Usuarios.ContainsKey(nombreUsuario))
            {
                MessageBox.Show("El nombre de usuario no existe");
            }
            else if (nombreUsuario == null || nombreUsuario == "")
            {
                MessageBox.Show("El nombre de usuario no puede estar vacío. Por favor, ingrésalo.");
            }
            else if (confirmacion == null || confirmacion == "")
            {
                MessageBox.Show("Debe escribir 'CONFIRMAR'");
            }
            else if (GestorUsuarios.Usuarios.ContainsKey(nombreUsuario) && confirmacion == "CONFIRMAR")
            {
                GestorUsuarios.BorrarUsuario(nombreUsuario);
                CargarUsuariosEnListBox();
            }
            else
            {
                MessageBox.Show("Escriba 'CONFIRMAR' ");
            }
        }
    }

}

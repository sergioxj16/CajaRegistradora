using CajaRegistradora.Clases;
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
    public partial class MenuAdminFormulario : Form
    {
        public MenuAdminFormulario()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MenuAdminFormulario));
            mensajeMenu = new Label();
            botonVenta = new Button();
            botonDevolucion = new Button();
            botonHistorial = new Button();
            botonCerrarSesion = new Button();
            botonCupones = new Button();
            botonGestionarUsuarios = new Button();
            botonProducto = new Button();
            botonInventario = new Button();
            SuspendLayout();
            // 
            // mensajeMenu
            // 
            resources.ApplyResources(mensajeMenu, "mensajeMenu");
            mensajeMenu.Name = "mensajeMenu";
            // 
            // botonVenta
            // 
            resources.ApplyResources(botonVenta, "botonVenta");
            botonVenta.Name = "botonVenta";
            botonVenta.UseVisualStyleBackColor = true;
            botonVenta.Click += botonVenta_Click;
            // 
            // botonDevolucion
            // 
            resources.ApplyResources(botonDevolucion, "botonDevolucion");
            botonDevolucion.Name = "botonDevolucion";
            botonDevolucion.UseVisualStyleBackColor = true;
            // 
            // botonHistorial
            // 
            resources.ApplyResources(botonHistorial, "botonHistorial");
            botonHistorial.Name = "botonHistorial";
            botonHistorial.UseVisualStyleBackColor = true;
            // 
            // botonCerrarSesion
            // 
            resources.ApplyResources(botonCerrarSesion, "botonCerrarSesion");
            botonCerrarSesion.Name = "botonCerrarSesion";
            botonCerrarSesion.UseVisualStyleBackColor = true;
            botonCerrarSesion.Click += botonCerrarSesion_Click;
            // 
            // botonCupones
            // 
            resources.ApplyResources(botonCupones, "botonCupones");
            botonCupones.Name = "botonCupones";
            botonCupones.UseVisualStyleBackColor = true;
            // 
            // botonGestionarUsuarios
            // 
            resources.ApplyResources(botonGestionarUsuarios, "botonGestionarUsuarios");
            botonGestionarUsuarios.Name = "botonGestionarUsuarios";
            botonGestionarUsuarios.UseVisualStyleBackColor = true;
            botonGestionarUsuarios.Click += botonGestionarUsuarios_Click;
            // 
            // botonProducto
            // 
            resources.ApplyResources(botonProducto, "botonProducto");
            botonProducto.Name = "botonProducto";
            botonProducto.UseVisualStyleBackColor = true;
            botonProducto.Click += botonProducto_Click;
            // 
            // botonInventario
            // 
            resources.ApplyResources(botonInventario, "botonInventario");
            botonInventario.Name = "botonInventario";
            botonInventario.UseVisualStyleBackColor = true;
            // 
            // MenuAdminFormulario
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            Controls.Add(botonInventario);
            Controls.Add(botonProducto);
            Controls.Add(mensajeMenu);
            Controls.Add(botonGestionarUsuarios);
            Controls.Add(botonCupones);
            Controls.Add(botonCerrarSesion);
            Controls.Add(botonHistorial);
            Controls.Add(botonDevolucion);
            Controls.Add(botonVenta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MenuAdminFormulario";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private void botonVenta_Click(object sender, EventArgs e)
        {

        }

        private void botonCerrarSesion_Click(object sender, EventArgs e)
        {
            InicioFormulario inicioFormulario = new InicioFormulario();
            inicioFormulario.Show();
            this.Hide();
        }

        private void botonGestionarUsuarios_Click(object sender, EventArgs e)
        {
            GestorDeUsuariosFormulario gestorDeusuarioFormulario = new GestorDeUsuariosFormulario();
            gestorDeusuarioFormulario.Show();
            this.Hide();
        }

        private void botonProducto_Click(object sender, EventArgs e)
        {
            Inventario inventario = new Inventario();
            ProductoFormulario producto = new ProductoFormulario(inventario);
            producto.Show();
        }

    }
}

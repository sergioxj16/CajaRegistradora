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
    public partial class botonDevolucion : Form
    {
        public botonDevolucion()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(botonDevolucion));
            mensajeMenu = new Label();
            botonVenta = new Button();
            DEVOLUCION = new Button();
            botonHistorial = new Button();
            botonCerrarSesion = new Button();
            botonCupones = new Button();
            botonGestionarUsuarios = new Button();
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
            // DEVOLUCION
            // 
            resources.ApplyResources(DEVOLUCION, "DEVOLUCION");
            DEVOLUCION.Name = "DEVOLUCION";
            DEVOLUCION.UseVisualStyleBackColor = true;
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
            // 
            // botonDevolucion
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            Controls.Add(mensajeMenu);
            Controls.Add(botonGestionarUsuarios);
            Controls.Add(botonCupones);
            Controls.Add(botonCerrarSesion);
            Controls.Add(botonHistorial);
            Controls.Add(DEVOLUCION);
            Controls.Add(botonVenta);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "botonDevolucion";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        private void botonVenta_Click(object sender, EventArgs e)
        {
            GestorDeUsuarios gestorDeusuarioFormulario = new GestorDeUsuarios();
            gestorDeusuarioFormulario.Show();
            this.Hide();
        }
    }
}

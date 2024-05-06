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
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            // 
            // MenuAdminFormulario
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            Controls.Add(botonVenta);
            Controls.Add(mensajeMenu);
            Name = "MenuAdminFormulario";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}

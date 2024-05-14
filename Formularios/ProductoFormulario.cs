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
    public partial class ProductoFormulario : Form
    {
        public ProductoFormulario()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            string codigoProducto = codigoProductoTextBox.Text;
            string nombreProducto = nombreTextBox.Text;
            double precioProducto = Convert.ToDouble(precioTextBox.Text);


        }
    }
}

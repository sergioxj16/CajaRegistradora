using CajaRegistradora.Clases;
using System;
using System.Windows.Forms;

namespace CajaRegistradora.Formularios
{
    internal partial class ProductoFormulario : Form
    {
        private readonly Inventario inventario;

        public ProductoFormulario(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            string codigoProducto = codigoProductoTextBox.Text;
            string nombreProducto = nombreTextBox.Text;
            double precioProducto;

            if (string.IsNullOrWhiteSpace(codigoProducto) || string.IsNullOrWhiteSpace(nombreProducto) || !double.TryParse(precioTextBox.Text, out precioProducto))
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
                return;
            }

            if (!inventario.Productos.ContainsKey(codigoProducto))
            {
                Producto nuevoProducto = new Producto(codigoProducto, nombreProducto, precioProducto);
                inventario.AgregarProducto(nuevoProducto);
                MessageBox.Show("Producto creado exitosamente.");
                inventario.GuardarInventarioEnArchivo();
            }
            else
            {
                MessageBox.Show("El producto ya existe en el inventario.");
            }
        }
    }
}

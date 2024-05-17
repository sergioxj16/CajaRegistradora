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
            double precioVenta = 0;
            double precioCompra = 0;
            int stock = 0;

            bool precioVentaValido = double.TryParse(precioVentaTextBox.Text, out precioVenta);
            bool precioCompraValido = double.TryParse(precioCompraTextBox.Text, out precioCompra);
            bool stockValido = int.TryParse(stockTextBox.Text, out stock);

            if (!precioVentaValido || !precioCompraValido || !stockValido)
            {
                MessageBox.Show("Por favor, ingrese valores válidos.");
            }
            else if (!inventario.Productos.ContainsKey(codigoProducto))
            {
                Producto nuevoProducto = new Producto(codigoProducto, nombreProducto, precioVenta, precioCompra, stock);

                inventario.AgregarProducto(nuevoProducto);

                MessageBox.Show("Producto creado exitosamente.");

                inventario.GuardarInventarioEnArchivo();
            }
            else
            {
                MessageBox.Show("El producto ya existe en el inventario.");
            }
        }

        private void botonBorrarProducto_Click(object sender, EventArgs e)
        {
            string codigo = codigoProductoEliminarTextBox.Text;

            if (codigo == null || codigo == "")
            {
                MessageBox.Show("Por favor, ingrese un código de producto válido.");
            }
            else if (inventario.Productos.ContainsKey(codigo))
            {
                inventario.EliminarProducto(codigo);
                inventario.GuardarInventarioEnArchivo();
                MessageBox.Show("Producto eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("El producto no existe en el inventario.");
            }
        }

    }
}

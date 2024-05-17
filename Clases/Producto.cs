using System;

namespace CajaRegistradora.Clases
{
    internal class Producto
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }

        public Producto()
        {
            Codigo = "";
            Nombre = "";
            PrecioCompra = 0;
            PrecioVenta = 0;
            Stock = 0;
        }

        public Producto(string codigo, string nombre, double precioCompra, double precioVenta, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            PrecioCompra = precioCompra;
            PrecioVenta = precioVenta;
            Stock = stock;
        }
    }
}

namespace CajaRegistradora.Clases
{
    internal class Producto
    {
        string Codigo;
        string Nombre;
        double PrecioCompra;
        double PrecioVenta;

        public Producto(string codigo, string nombre, double precioCompra, double precioVenta)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
        }

        public string Codigo1 { get => Codigo; set => Codigo = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public double PrecioCompra1 { get => PrecioCompra; set => PrecioCompra = value; }
        public double PrecioVenta1 { get => PrecioVenta; set => PrecioVenta = value; }
    }
}

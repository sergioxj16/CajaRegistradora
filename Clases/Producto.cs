namespace CajaRegistradora.Clases
{
    internal class Producto
    {
        private string codigo;
        private string nombre;
        private double precioCompra;
        private double precioVenta;
        private int stock;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public double PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public double PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }

        public Producto(string codigo, string nombre, double precioVenta)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.PrecioVenta = precioVenta;
            this.PrecioCompra = 0; 
            this.Stock = 0; 
        }

        public Producto(string codigo, string nombre, double precioCompra, double precioVenta, int stock)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.PrecioCompra = precioCompra;
            this.PrecioVenta = precioVenta;
            this.Stock = stock;
        }
    }
}

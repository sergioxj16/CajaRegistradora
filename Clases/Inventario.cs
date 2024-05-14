using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CajaRegistradora.Clases
{
    internal class Inventario
    {
        private Dictionary<string, Producto> productos;

        public Inventario()
        {
            productos = new Dictionary<string, Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (!productos.ContainsKey(producto.Codigo))
            {
                productos.Add(producto.Codigo, producto);
            }
            else
            {
                Console.WriteLine("El producto ya existe en el inventario.");
            }
        }

        public void GuardarInventarioEnArchivo()
        {
            const string rutaArchivo = @"Datos\productos.json";
            try
            {
                string jsonProductos = JsonSerializer.Serialize(productos);
                File.WriteAllText(rutaArchivo, jsonProductos);
                Console.WriteLine("Inventario guardado correctamente en el archivo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el inventario en el archivo: " + ex.Message);
            }
        }

        public void CargarInventarioDesdeArchivo()
        {
            const string rutaArchivo = @"Datos\productos.json";
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    string jsonProductos = File.ReadAllText(rutaArchivo);
                    productos = JsonSerializer.Deserialize<Dictionary<string, Producto>>(jsonProductos);
                    Console.WriteLine("Inventario cargado correctamente desde el archivo.");
                }
                else
                {
                    Console.WriteLine("El archivo de inventario no existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el inventario desde el archivo: " + ex.Message);
            }
        }

        public void EliminarProducto(string codigo)
        {
            if (productos.ContainsKey(codigo))
            {
                productos.Remove(codigo);
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void ActualizarStock(string codigo, int cantidad)
        {
            if (productos.ContainsKey(codigo))
            {
                productos[codigo].Stock += cantidad;
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void ActualizarPrecioVenta(string codigo, double precio)
        {
            if (productos.ContainsKey(codigo))
            {
                productos[codigo].PrecioVenta = precio;
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void MostrarProductos()
        {
            foreach (var producto in productos.Values)
            {
                Console.WriteLine($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Precio Venta: {producto.PrecioVenta}, Stock: {producto.Stock}");
            }
        }
    }
}

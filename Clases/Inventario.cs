using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CajaRegistradora.Clases
{
    internal class Inventario
    {
        public Dictionary<string, Producto> Productos { get; set; }

        public Inventario()
        {
            Productos = new Dictionary<string, Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            if (!Productos.ContainsKey(producto.Codigo))
            {
                Productos.Add(producto.Codigo, producto);
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
                string jsonProductos;

                if (File.Exists(rutaArchivo))
                {
                    jsonProductos = File.ReadAllText(rutaArchivo);

                    var productosGuardados = JsonSerializer.Deserialize<Dictionary<string, Producto>>(jsonProductos);

                    foreach (var kvp in productosGuardados)
                    {
                        Productos[kvp.Key] = kvp.Value;
                    }
                }

                jsonProductos = JsonSerializer.Serialize(Productos, new JsonSerializerOptions { WriteIndented = true });

                File.WriteAllText(rutaArchivo, jsonProductos);
                Console.WriteLine("Inventario guardado correctamente en el archivo.");
                MessageBox.Show("Guardar correcto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarInventarioDesdeArchivo()
        {
            const string rutaArchivo = @"Datos\productos.json";
            try
            {
                if (!File.Exists(rutaArchivo))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(rutaArchivo));
                    using (File.Create(rutaArchivo)) { }
                    MessageBox.Show("El archivo de inventario no existía, se ha creado uno nuevo.");
                }
                else
                {
                    string jsonProductos = File.ReadAllText(rutaArchivo);
                    Productos = JsonSerializer.Deserialize<Dictionary<string, Producto>>(jsonProductos);
                    Console.WriteLine("Inventario cargado correctamente desde el archivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el inventario desde el archivo: {ex.Message}");
            }
        }

        public void EliminarProducto(string codigo)
        {
            if (Productos.ContainsKey(codigo))
            {
                Productos.Remove(codigo);
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void ActualizarStock(string codigo, int cantidad)
        {
            if (Productos.ContainsKey(codigo))
            {
                Productos[codigo].Stock += cantidad;
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void ActualizarPrecioVenta(string codigo, double precio)
        {
            if (Productos.ContainsKey(codigo))
            {
                Productos[codigo].PrecioVenta = precio;
            }
            else
            {
                Console.WriteLine("El producto no existe en el inventario.");
            }
        }

        public void MostrarProductos()
        {
            foreach (var producto in Productos.Values)
            {
                Console.WriteLine($"Código: {producto.Codigo}, Nombre: {producto.Nombre}, Precio Compra: {producto.PrecioCompra}, Precio Venta: {producto.PrecioVenta}, Stock: {producto.Stock}");
            }
        }
    }
}

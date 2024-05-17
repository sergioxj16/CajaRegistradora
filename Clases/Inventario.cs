﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CajaRegistradora.Clases
{
    internal class Inventario
    {
        public Dictionary<string, Producto> Productos { get; set; }
        const string rutaArchivo = @"Datos\productos.json";

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
        }

        public void GuardarInventarioEnArchivo()
        {
            
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarInventarioDesdeArchivo()
        {
            try
            {
                string jsonProductos = File.ReadAllText(rutaArchivo);
                Productos = JsonSerializer.Deserialize<Dictionary<string, Producto>>(jsonProductos);
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
        }

        public void ActualizarStock(string codigo, int cantidad)
        {
            if (Productos.ContainsKey(codigo))
            {
                Productos[codigo].Stock += cantidad;
            }
        }

        public void ActualizarPrecioVenta(string codigo, double precio)
        {
            if (Productos.ContainsKey(codigo))
            {
                Productos[codigo].PrecioVenta = precio;
            }
        }

        public void MostrarProductos()
        { 
        }
    }
}
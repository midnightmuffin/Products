using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataPersistence
{
    //Metodo que retorna una lista de productos tomada del archivo de texto
    public class FileManager
    {
        // ---- Desarrollado por el Estudiante ----
        // Implementación para leer el archivo de txt y devolver una lista de productos

        public string file = "products.txt";

        public List<Product> ReadProducts()
        {
            var products = new List<Product>();

            // Verificar si el archivo existe
            if (!File.Exists(file))
            {
                Console.WriteLine("El archivo no existe. Se creará uno nuevo.");
                return products;
            }

            var lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue; // Saltar líneas vacías
                }

                // Dividir la línea en partes usando la coma como separador
                var parts = line.Split(',');

                // Verificar que la línea tenga la cantidad correcta de partes
                if (parts.Length == 4)
                {
                    Product product = new Product();
                    {
                        // Asignar valores a las propiedades del producto
                        product.Id = int.Parse(parts[0]);
                        product.Name = parts[1];
                        product.Price = double.Parse(parts[3]);
                        product.Stock = int.Parse(parts[2]);
                        // Agregar el producto a la lista
                        products.Add(product);
                    }
                    
                }

            }

            return products;
        }

        public void SaveProduct(Product product)
        {
            // ---- Desarrollado por el Estudiante ----
            // Implementación para guardar el producto en un archivo de txt

            string line = $"{product.Id},{product.Name},{product.Stock},{product.Price}";
            File.AppendAllText(file, line + Environment.NewLine);
        }
    }
}

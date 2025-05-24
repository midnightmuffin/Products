using Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataPersistence
{
    public class FileManager
    {
        public string file = "products.txt";

        public bool FileCreated { get; private set; } = false;

        public List<Product> ReadProducts()
        {
            var products = new List<Product>();

            if (!File.Exists(file))
            {
                FileCreated = true;
                return products;
            }

            var lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                if (parts.Length == 4)
                {
                    Product product = new Product();
                    product.Id = int.Parse(parts[0]);
                    product.Name = parts[1];
                    product.Stock = int.Parse(parts[2]);
                    product.Price = double.Parse(parts[3]);

                    products.Add(product);
                }
            }

            return products;
        }

        public void SaveProduct(Product product)
        {
            string line = $"{product.Id},{product.Name},{product.Stock},{product.Price}";
            File.AppendAllText(file, line + Environment.NewLine);
        }
    }
}

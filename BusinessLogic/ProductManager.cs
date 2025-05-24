using Entities;
using DataPersistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManager
    {
        public FileManager fileManager = new FileManager();

        public void AddProduct(Product product)
        {
            if (product.ValidateProduct())
            {
                fileManager.SaveProduct(product);
                Console.WriteLine("Producto agregado correctamente.");
            }
            else
            {
                Console.WriteLine("No se pudo agregar el producto. Verifique los datos.");
            }
        }

        public List<Product> GetProducts()
        {
            return fileManager.ReadProducts();
        }
    }
}

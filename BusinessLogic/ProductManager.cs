using DataPersistence;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ProductManager
    {
        private FileManager fileManager = new FileManager();

        public bool AddProduct(Product product, out List<string> errors)
        {
            if (product.ValidateProduct(out errors))
            {
                fileManager.SaveProduct(product);
                return true;
            }

            return false;
        }

        public List<Product> GetProducts()
        {
            return fileManager.ReadProducts();
        }
    }
}

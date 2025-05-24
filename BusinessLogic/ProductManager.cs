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

        public bool FileWasCreated => fileManager.FileCreated;

        public bool AddProduct(Product product, out List<string> errores)
        {
            if (product.ValidateProduct(out errores))
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

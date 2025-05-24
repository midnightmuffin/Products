using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    // Objetos de tipo DTO (Data Transfer Object)
    // POJOS (Plain Old Java Object) Objetos que no tienen acciones, solo atributos
    public class Product : ProductBase
    {
        public double Price { get; set; }
        public int Stock { get; set; }

        public bool ValidateProduct()
        {
            bool isValid = true;

            if (!ValidateName())
            {
                isValid = false;
            }

            if (Price <= 0)
            {
                Console.WriteLine("Error: El precio debe ser mayor que cero.");
                isValid = false;
            }

            if (Stock < 0)
            {
                Console.WriteLine("Error: El stock no puede ser negativo.");
                isValid = false;
            }

            return isValid;
        }
    }
}

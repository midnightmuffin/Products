using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entities
{
    public class Product : ProductBase
    {
        public double Price;
        public int Stock;

        public bool ValidateProduct(out List<string> errors)
        {
            errors = new List<string>();

            if (string.IsNullOrWhiteSpace(Name))
           
                errors.Add("El nombre no debe estar vacío.");
           
            if (Price <= 0)
                errors.Add("El precio debe ser mayor a 0.");

            if (Stock < 1)
                errors.Add("El stock no puede ser negativo.");

            return errors.Count == 0;
        }
    }
}
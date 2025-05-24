using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductBase
    {
        public int Id { get; set; }
        public string Name { get; set; }

    public bool ValidateName()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("Error: El nombre no puede estar vacío.");
                return false;
            }
            return true;
        }

    }
}

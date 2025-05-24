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
    }
}

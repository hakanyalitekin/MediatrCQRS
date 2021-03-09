using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatrCQRS
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Qunatity { get; set; }
        public decimal Amount { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Models
{
    public class Product : BaseEntitiy
    {
        public string Name { get; set; }
        public int Stoct { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }
}

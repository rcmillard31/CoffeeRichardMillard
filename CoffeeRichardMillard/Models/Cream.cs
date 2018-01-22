using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public class Cream : SaleItem
    {
        public const decimal PriceForCream = 0.50m;
        public Cream()
        {            
        }
        public override string Description()
        {
            return "Cream";
        }
        public override decimal Price()
        {
            return PriceForCream;
        }

    }
}

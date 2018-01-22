using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public class Sugar : SaleItem
    {
        public const decimal PriceForSugar = 0.25m;
        public Sugar()
        {
        }

        public override string Description()
        {
            return "Sugar";
        }
        public override decimal Price()
        {
            return PriceForSugar;
        }
    }
}

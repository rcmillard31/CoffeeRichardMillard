using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public abstract class SaleItem : BaseItem
    {
        public abstract string Description();
        public abstract decimal Price();
    }
}

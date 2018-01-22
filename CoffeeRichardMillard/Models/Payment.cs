using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public class Payment : BaseItem
    {
        public Payment()
        {

        }
        public decimal Amount { get; set; }
    }
}

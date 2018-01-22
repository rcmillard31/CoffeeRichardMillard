using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeRichardMillard.Models
{
    public abstract class BaseItem
    {
        public object Parent { get; set; }
        public int Id { get; set; }
    }
}

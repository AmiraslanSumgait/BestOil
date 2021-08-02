using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    class Fuel
    {
        public double Price { get; set; }
        public string Type { get; set; }
        public Fuel(string type,double price)
        {
            Price = price;
            Type = type;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil
{
    class Food
    {
        public string Type { get; set; }
        public double Price { get; set; }
        public Food(string type, double price)
        {
            Price = price;
            Type = type;

        }
    }
}

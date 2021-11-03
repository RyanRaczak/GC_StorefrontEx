using System;
using System.Collections.Generic;
using System.Text;

namespace GC_StorefrontEX
{
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; } = 0;
        public bool InBasket { get; set; } = false;
        public double Total => Amount * Price;

        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
       //Console.WriteLine("\n{0,-15}{1,10}{2,20}", "Item","Price", "Quantity");
        public override string ToString()
        {
            //string output = $"{Name,-15}{Price,10:c}{Amount, 6}";
            string output = $"{Name,-15}{Price,10:c}";
            return output;
        }
    }
}

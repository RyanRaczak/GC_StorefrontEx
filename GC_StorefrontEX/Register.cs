using System;
using System.Collections.Generic;
using System.Text;

namespace GC_StorefrontEX
{
    class Register
    {
        public List<Item> basket = new List<Item>();
        public Register()
        {
            basket.Add(new Item("Chicken", 5.50));
            basket.Add(new Item("Bread", 2.50));
            basket.Add(new Item("Milk", 3.50));
        }
        public void DisplayItems()
        {
            //Console.WriteLine("\n{0,-15}{1,10}{2,13}", "Item", "Price", "Quantity");
            Console.WriteLine("\n{0,-15}{1,10}", "Item","Price");
            Console.WriteLine("======================================");
            foreach (var item in basket)
            {
                Console.WriteLine(item);
            }
        }
        public bool HasItem(string item)
        {
            for (int i = 0; i < basket.Count; i++)
            {
                if (basket[i].Name.Contains(item, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }
        public string BuyRandom()
        {
            Random rnd = new Random();
            int item = rnd.Next(0, 3);
            return basket[item].Name;
        }
        public string BuyInBulk(string item, int amount)
        {
            for (int i = 0; i < basket.Count; i++)
            {
                if (HasItem(item))
                {
                    return $"Total for {amount} {basket[i].Name} is: {amount * basket[i].Price:c}";
                }
            }
            return "\nPRODUCT NOT FOUND";
        }
        public string BuyAll()
        {
            string output = "";
            double total = 0;
            for (int i = 0; i < basket.Count; i++)
            {
                total += basket[i].Price;
                output += $"{basket[i].Name} ";
            }
            output += $"Total: {total:c}";
            return output;
        }
        public string SelectItem(string item)
        {
            for (int i = 0; i < basket.Count; i++)
            {
                if (HasItem(item))
                {
                    Console.WriteLine($"This product costs {basket[i].Price:c}");
                    return basket[i].Name;
                }
            }
            return "\nPRODUCT NOT FOUND";
        }
    }
}

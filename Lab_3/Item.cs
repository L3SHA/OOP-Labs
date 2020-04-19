using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public abstract class Item
    {
        public Item()
        {

        }
        public Item(string name, int price, string companyName, int amount) 
        {
            Name = name;
            Price = price;
            CompanyName = companyName;
            Amount = amount;
        }
        public string Name { set; get; }
        public int Price { set; get; }
        public string CompanyName { set; get; }
        public int Amount { set; get; }
    }
}

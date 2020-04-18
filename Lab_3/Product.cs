using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public class Product
    {
        public Product()
        {

        }
        public Product(string name, int price, string companyName) 
        {
            Name = name;
            Price = price;
            CompanyName = companyName;
        }
        public string Name { private set; get; }
        public int Price { private set; get; }
        public string CompanyName { private set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public class RAM : Item
    {
        public RAM(string name, int price, string companyName, int amount, int frequency, int capacity, string type) : base(name, price, companyName, amount)
        {
            Frequency = frequency;
            Capacity = capacity;
            Type = type;
        }
        public int Frequency { private set; get; }

        public int Capacity { private set; get; }

        public string Type { private set; get; }
    }
}

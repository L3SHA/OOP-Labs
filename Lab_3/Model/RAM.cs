using System;
using Storehouse.API; 

namespace Storehouse.Model
{
    [Serializable]
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

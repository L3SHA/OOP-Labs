using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public class Motherboard : Item
    {
        public Motherboard(string name, int price, string companyName, int amount, string cpuSupport, string socket, string formFactor) : base(name, price, companyName, amount)
        {
            CPUSupport = cpuSupport;
            Socket = socket;
            FormFactor = formFactor;
        }
        public string CPUSupport { private set; get; }

        public string Socket { private set; get; }

        public string FormFactor { private set; get; }
    }
}

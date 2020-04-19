using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public class SystemCase : Item
    {
       public SystemCase(string name, int price, string companyName, int amount, int fansAmount, bool powerSupplyContain, int usbPortAmount) : base(name, price, companyName, amount)
        {
            FansAmount = fansAmount;
            PowerSupplyContain = powerSupplyContain;
            USBPortAmount = usbPortAmount;
        }
        public int FansAmount { private set; get; }

        public bool PowerSupplyContain { private set; get; }

        public int USBPortAmount { private set; get; }
    }
}

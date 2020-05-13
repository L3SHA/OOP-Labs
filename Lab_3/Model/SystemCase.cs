using Storehouse.API;

namespace Storehouse.Model
{
    public class SystemCase : Item
    {
       public SystemCase(string name, int price, string companyName, int amount, int fansAmount, int usbPortAmount) : base(name, price, companyName, amount)
        {
            FansAmount = fansAmount;
            USBPortAmount = usbPortAmount;
        }
        public int FansAmount { private set; get; }

        public int USBPortAmount { private set; get; }
    }
}

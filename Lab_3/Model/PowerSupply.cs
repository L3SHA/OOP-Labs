using Storehouse.API;

namespace Storehouse.Model
{
    public class PowerSupply : Item
    {
        public PowerSupply(string name, int price, string companyName, int amount, int efficiency, int power) : base(name, price, companyName, amount)
        {
            Efficiency = efficiency;
            Power = power;
        }
        public int Efficiency { private set; get; }

        public int Power { private set; get; }
    }
}

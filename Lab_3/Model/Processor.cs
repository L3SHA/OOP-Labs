using Storehouse.API;

namespace Storehouse.Model
{
    public class Processor : Item
    {
        public Processor(string name, int price, string companyName, int amount, int coresNum, double frequency, int processTechnology, int cacheSize, int thermalDesignPower) : base(name, price, companyName, amount) 
        {
            CoresNum = coresNum;  
            Frequency = frequency;
            CacheSize = cacheSize;
            ProcessTechnology = processTechnology;
            ThermalDesignPower = thermalDesignPower;
        }

        public int CoresNum { private set; get; }

        public double Frequency { private set; get; }

        public int ProcessTechnology { private set; get; }

        public int CacheSize { private set; get; }

        public int ThermalDesignPower { private set; get; }
    }
}

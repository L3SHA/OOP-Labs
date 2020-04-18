using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    class Processor : Product
    {
        public Processor ()
        {

        }
        public Processor(string name, int price, string companyName, int coresNum, double frequency, int processTechnology, int cacheSize, int thermalDesignPower) : base(name, price, companyName) 
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

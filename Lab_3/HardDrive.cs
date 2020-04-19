using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public class HardDrive : Item
    {
        public HardDrive(string name, int price, string companyName, int amount, int capacity, int rotateSpeed, string connectionInterface) : base(name, price, companyName, amount)
        {
            Capacity = capacity;
            RotateSpeed = rotateSpeed;
            ConnectionInterface = connectionInterface;
        }

        public int Capacity { private set; get; }

        public int RotateSpeed { private set; get; }

        public string ConnectionInterface { private set; get; }
    }
}

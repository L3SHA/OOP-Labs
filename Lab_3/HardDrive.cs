using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    class HardDrive : Product
    {
        public HardDrive(string name, int price, string companyName, int capacity, int rotateSpeed, string connectionInterface) : base(name, price, companyName)
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

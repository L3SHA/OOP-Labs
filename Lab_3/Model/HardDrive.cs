using System;
using Storehouse.API;

namespace Storehouse.Model
{
    [Serializable]
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    interface ISerializer<T>
    {
        string Serialize(T obj);

        T Deserialize(string jsonString);
    }
}

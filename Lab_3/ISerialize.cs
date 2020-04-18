using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    interface ISerialize
    {
        void Serialize(object simpleObject, string path);

        List<Product> Deserialize(string path);
    }
}

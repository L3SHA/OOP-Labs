using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_3
{
    public interface IFileService
    {
        void SaveToFile(string path, string str);

        string ReadFromFile(string path);
    }
}

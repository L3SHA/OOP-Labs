using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace OOP_Lab_3
{
    class SerializeJSonService : ISerialize
    {
        public void Serialize(object simpleObject, string path)
        {
            var jsonString = JsonSerializer.Serialize(simpleObject);
            using (var fileStream = File.AppendText(path))
            {
                fileStream.WriteLine(jsonString);
            }
        }

        public List<Product> Deserialize(string path)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                string jsonString = "";
                var objList = new List<Product>();
                jsonString = File.ReadLines
                    var obj = JsonSerializer.Deserialize<Processor>(jsonString);
                    Console.WriteLine(obj.Price);
                return objList;       
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOP_Lab_3
{
    public class JsonObjectSerializer<T> : ISerializer<T>
    {
        private static JsonObjectSerializer<T> jsonSerializer;
        private static JsonSerializerSettings jsonSettings;

        private JsonObjectSerializer()
        {
            jsonSettings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
        }

        public static JsonObjectSerializer<T> getInstance()
        {
            if(null == jsonSerializer)
            {
                jsonSerializer = new JsonObjectSerializer<T>();
            }
            return jsonSerializer;
        }
        
        public T Deserialize(string jsonString)
        {
            return JsonConvert.DeserializeObject<T>(jsonString, jsonSettings);
        }

        public string Serialize(T obj)
        {
            return JsonConvert.SerializeObject(obj, jsonSettings);
        }
    }
}

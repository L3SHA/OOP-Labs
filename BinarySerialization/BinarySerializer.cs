using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using SerializerInterface;

namespace BinarySerialization
{
    public class BinarySerialzer : ISerializerPlugin
    {
        public object Deserialize(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        public void Serialize(Stream stream, object obj)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
        }
    }
}

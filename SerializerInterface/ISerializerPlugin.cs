using System.IO;

namespace SerializerInterface
{
    public interface ISerializerPlugin
    {
        void Serialize(Stream stream, object obj);

        object Deserialize(Stream stream);
    }
}

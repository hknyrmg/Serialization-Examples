using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_Examples.Functions
{
    public class BinarySerializeDeserialize
    {
        public static byte[] SerializeBinary(object variable1)
        {
            using(var stream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(stream, variable1);
                return stream.ToArray();
            }
        }

        public static object DeserializeBinary(byte[] variable1)
        {
            using (var stream = new MemoryStream(variable1))
            {
                var binaryFormatter = new BinaryFormatter();
                return binaryFormatter.Deserialize(stream);
            }
        }

    }
}

using Newtonsoft.Json;

namespace Serialization_Examples.Functions
{
    public class JsonSerializeDeserialize
    {
        public static string SerializeJson(object variable1)
        {
            return JsonConvert.SerializeObject(variable1);
        }

        public static string SerializeJsonWithSettings(object variable1)
        {
            return JsonConvert.SerializeObject(variable1, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects,
                DateFormatString = "MMMM dd, yyyy"
            });
        }
        public static object DeserializeJson(string variable1)
        {
            return JsonConvert.DeserializeObject(variable1);
        }
    }
}

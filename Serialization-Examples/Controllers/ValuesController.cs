using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serialization_Examples.Functions;
using Serialization_Examples.Models;

namespace Serialization_Examples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            string deneme = "a";
            var serialized = BinarySerializeDeserialize.SerializeBinary(deneme);
            var deserialized = BinarySerializeDeserialize.DeserializeBinary(serialized);

            string denemeJson = "Jack";
            var serializedJson = JsonSerializeDeserialize.SerializeJson(denemeJson);
            var deserializedJson = JsonSerializeDeserialize.DeserializeJson(serializedJson);

            Person person = new Person()
            {
                Age = 12,
                Name = "Micheal",
                JoinDate = DateTime.Now
            };
            var serializedJsonWithSettings = JsonSerializeDeserialize.SerializeJsonWithSettings(person);

            return new string[] { "value1", "value2" };
        }

       
    }
}

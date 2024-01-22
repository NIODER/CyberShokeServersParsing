using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CyberShoke.Infrastructure.Converters
{
    public class ObjectToListConverter : JsonConverter<IEnumerable<string>>
    {
        public override IEnumerable<string> ReadJson(JsonReader reader, Type objectType, IEnumerable<string> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JToken.ReadFrom(reader);
            return token.ToObject<Dictionary<string, string>>().Values.ToList();
        }

        public override void WriteJson(JsonWriter writer, IEnumerable<string> value, Newtonsoft.Json.JsonSerializer serializer)
        {
            IDictionary<string, string> keyValuePairs = value
                .Select((s, index) => new { s, index })
                .ToDictionary(x => x.index.ToString(), x => x.s);
            writer.WriteValue(keyValuePairs);
        }
    }
}

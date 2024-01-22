using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CyberShoke.Infrastructure.Converters
{
    public class ObjectToDictionaryConverter : JsonConverter<IDictionary<string, string>>
    {
        public override IDictionary<string, string> ReadJson(JsonReader reader, Type objectType, IDictionary<string, string> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JToken.ReadFrom(reader);
            return token.ToObject<Dictionary<string, string>>();
        }

        public override void WriteJson(JsonWriter writer, IDictionary<string, string> value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }
}

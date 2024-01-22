using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CyberShoke.Infrastructure.Converters
{
    public class ObjectToValueDictionaryConverter<T> : JsonConverter<IDictionary<string, T>>
    {
        public override IDictionary<string, T> ReadJson(JsonReader reader, Type objectType, IDictionary<string, T> existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var token = JToken.ReadFrom(reader);
            return token.ToObject<Dictionary<string, T>>();
        }

        public override void WriteJson(JsonWriter writer, IDictionary<string, T> value, JsonSerializer serializer)
        {
            writer.WriteValue(value);
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Net;

namespace CyberShoke.Infrastructure.Converters
{
    public class IpAddressConverter : JsonConverter<IPAddress>
    {
        public override IPAddress ReadJson(JsonReader reader, Type objectType, IPAddress existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return IPAddress.Parse(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, IPAddress value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }
    }
}

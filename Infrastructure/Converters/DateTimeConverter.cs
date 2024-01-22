using Newtonsoft.Json;
using System;

namespace CyberShoke.Infrastructure.Converters
{
    public class DateTimeConverter : JsonConverter<DateTime>
    {
        public override DateTime ReadJson(JsonReader reader, Type objectType, DateTime existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            return DateTimeOffset.FromUnixTimeSeconds(long.Parse(reader.Value.ToString())).UtcDateTime;
        }

        public override void WriteJson(JsonWriter writer, DateTime value, JsonSerializer serializer)
        {
            writer.WriteValue(new DateTimeOffset(value).ToUnixTimeSeconds());
        }
    }
}

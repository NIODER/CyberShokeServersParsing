using CyberShoke.Infrastructure.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Entities
{
    public class Game
    {
        [JsonProperty("name_full")]
        public string NameFull { get; set; }
        [JsonProperty("name_short")]
        public string NameShort { get; set; }
        [JsonProperty("url_name")]
        public string UrlName { get; set; }
        [JsonProperty("data_web"), JsonConverter(typeof(ObjectToValueDictionaryConverter<DataWeb>))]
        public IDictionary<string, DataWeb> DataWeb { get; set; }
    }
}

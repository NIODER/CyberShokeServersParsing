using CyberShoke.Infrastructure.Converters;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Entities
{
    public class Mode
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("mode")]
        public string ModeName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("maplist"), JsonConverter(typeof(ObjectToListConverter))]
        public IEnumerable<string> MapList { get; set; }
        [JsonProperty("ranks")]
        public IEnumerable<Rank> Ranks { get; set; }
        [JsonProperty("servers")]
        public int Servers { get; set; }
        [JsonProperty("players")]
        public int Players { get; set; }
        [JsonProperty("maxplayers")]
        public int MaxPlayers { get; set; }
        [JsonProperty("locations")]
        public IEnumerable<string> Locations { get; set; }
        [JsonProperty("prime"), JsonConverter(typeof(BooleanConverter))]
        public bool Prime { get; set; }
        [JsonProperty("noprime"), JsonConverter(typeof(BooleanConverter))]
        public bool NoPrime { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("title"), JsonConverter(typeof(ObjectToDictionaryConverter))]
        public IDictionary<string, string> Title { get; set; }
        [JsonProperty("description"), JsonConverter(typeof(ObjectToDictionaryConverter))]
        public IDictionary<string, string> Description { get; set; }
    }
}

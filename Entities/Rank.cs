using Newtonsoft.Json;

namespace CyberShoke.Entities
{
    public class Rank
    {
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

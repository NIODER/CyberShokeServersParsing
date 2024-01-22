using Newtonsoft.Json;

namespace CyberShoke.Entities
{
    public class ServerPing
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("ping")]
        public string Ping { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("url_short")]
        public string UrlShort { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("connectionKey")]
        public string ConnectionKey { get; set; }
        [JsonProperty("wss")]
        public string Wss { get; set; }
        [JsonProperty("img")]
        public string ImageUrl { get; set; }
    }
}

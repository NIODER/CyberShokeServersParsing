using Newtonsoft.Json;

namespace CyberShoke.Entities
{
    public class SocialNetwork
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("alt")]
        public string Alternative { get; set; }
        [JsonProperty("width")]
        public string Width { get; set; }
    }
}

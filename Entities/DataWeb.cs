using Newtonsoft.Json;

namespace CyberShoke.Entities
{
    public class DataWeb
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
    }
}

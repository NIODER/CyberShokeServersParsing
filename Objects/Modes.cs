using CyberShoke.Objects._Modes;
using Newtonsoft.Json;

namespace CyberShoke.Objects
{
    public class Modes
    {
        [JsonProperty]
        public string name { get; set; }

        [JsonProperty]
        public int servers { get; set; }

        [JsonProperty]
        public int players { get; set; }

        [JsonProperty]
        public int maxplayers { get; set; }

        [JsonProperty]
        public bool prime { get; set; }

        [JsonProperty]
        public bool noprime { get; set; }

        [JsonProperty]
        public string type { get; set; }

        [JsonProperty]
        public string releaseDate { get; set; }

        [JsonProperty]
        public Title title { get; set; }

        [JsonProperty]
        public Description description { get; set; }
    }
}

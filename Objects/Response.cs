using Newtonsoft.Json;

namespace CyberShoke.Objects
{
    class Response
    {
        [JsonProperty]
        public string result { get; set; }

        [JsonProperty]
        public Stats stats { get; set; }

        [JsonProperty]
        public Servers servers { get; set; }

        [JsonProperty]
        public Modes modes { get; set; }

        [JsonProperty]
        public Listmodes listmodes { get; set; }
    }
}

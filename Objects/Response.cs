using Newtonsoft.Json;
using System.Collections.Generic;

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
        public Mode modes { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class HNS
    {
        /// <summary>
        /// HNS SERVERS
        /// </summary>
        [JsonProperty("HNS SERVERS")]
        public List<Server> HNSServers { get; set; }
        /// <summary>
        /// HNS NO RULES
        /// </summary>
        [JsonProperty("HNS NO RULES")]
        public List<Server> NoRules { get; set; }
        /// <summary>
        /// HNS TRAINING
        /// </summary>
        [JsonProperty("HNS TRAINING")]
        public List<Server> Training { get; set; }
    }
}

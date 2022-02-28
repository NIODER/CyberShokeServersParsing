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
        public IEnumerable<Server> HNSServers { get; set; }
        /// <summary>
        /// HNS NO RULES
        /// </summary>
        [JsonProperty("HNS NO RULES")]
        public IEnumerable<Server> NoRules { get; set; }
        /// <summary>
        /// HNS TRAINING
        /// </summary>
        [JsonProperty("HNS TRAINING")]
        public IEnumerable<Server> Training { get; set; }
    }
}

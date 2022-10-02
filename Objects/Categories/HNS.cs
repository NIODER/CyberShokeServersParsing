using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class HNS
    {
        /// <summary>
        /// HNS SERVERS
        /// </summary>
        [JsonProperty("RULES")]
        public IList<Server> HNSServers { get; set; }
        /// <summary>
        /// HNS NO RULES
        /// </summary>
        [JsonProperty("NO RULES")]
        public IList<Server> NoRules { get; set; }
        /// <summary>
        /// HNS TRAINING
        /// </summary>
        [JsonProperty("TRAINING")]
        public IList<Server> Training { get; set; }
    }
}

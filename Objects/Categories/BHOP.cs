using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class BHOP
    {
        /// <summary>
        /// TIER 1-2 - EASY
        /// </summary>
        [JsonProperty("TIER 1-2 - EASY")]
        public List<Server> Easy { get; set; }
        /// <summary>
        /// 64 TICK
        /// </summary>
        [JsonProperty("64 TICK")]
        public List<Server> Tick { get; set; }
        /// <summary>
        /// TIER 3-4 - MEDIUM
        /// </summary>
        [JsonProperty("TIER 3-4 - MEDIUM")]
        public List<Server> Medium { get; set; }
        /// <summary>
        /// TIER 5-6 - HARD
        /// </summary>
        [JsonProperty("TIER 5-6 - HARD")]
        public List<Server> Hard { get; set; }
        /// <summary>
        /// LEGENDARY MAPS
        /// </summary>
        [JsonProperty("LEGENDARY MAPS")]
        public List<Server> Legendary { get; set; }
    }
}

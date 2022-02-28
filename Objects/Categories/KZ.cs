using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class KZ
    {
        /// <summary>
        /// KZTimer - TIER 1-2
        /// </summary>
        [JsonProperty("KZTimer - TIER 1-2")]
        public IEnumerable<Server> TimerLowSkill { get; set; }
        /// <summary>
        /// GOKZ - TIER 1-2
        /// </summary>
        [JsonProperty("GOKZ - TIER 1-2")]
        public IEnumerable<Server> GoLowSkill { get; set; }
        /// <summary>
        /// KZTimer - TIER 3-4
        /// </summary>
        [JsonProperty("KZTimer - TIER 3-4")]
        public IEnumerable<Server> TimerMiddle { get; set; }
        /// <summary>
        /// GOKZ - TIER 3-4
        /// </summary>
        [JsonProperty("GOKZ - TIER 3-4")]
        public IEnumerable<Server> GoMiddle { get; set; }
        /// <summary>
        /// KZTimer - TIER 5-6
        /// </summary>
        [JsonProperty("KZTimer - TIER 5-6")]
        public IEnumerable<Server> TimerAdvanced { get; set; }
        /// <summary>
        /// GOKZ - TIER 5-6
        /// </summary>
        [JsonProperty("GOKZ - TIER 5-6")]
        public IEnumerable<Server> GoAdvanced { get; set; }
    }
}

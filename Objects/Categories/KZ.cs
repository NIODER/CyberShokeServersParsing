using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class KZ
    {
        /// <summary>
        /// GOKZ - TIER 1-2
        /// </summary>
        [JsonProperty("GOKZ - TIER 1-2")]
        public IList<Server> GoLowSkill { get; set; }
        /// <summary>
        /// GOKZ - TIER 3-4
        /// </summary>
        [JsonProperty("GOKZ - TIER 3-4")]
        public IList<Server> GoMiddle { get; set; }
        /// <summary>
        /// GOKZ - TIER 5-6
        /// </summary>
        [JsonProperty("GOKZ - TIER 5-6")]
        public IList<Server> GoAdvanced { get; set; }
    }
}

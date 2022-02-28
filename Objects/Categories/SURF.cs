using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class SURF
    {
        /// <summary>
        /// TIER 1 - BEGINNER
        /// </summary>
        [JsonProperty("TIER 1 - BEGINNER")]
        public IEnumerable<Server> Beginner { get; set; }
        /// <summary>
        /// TIER 1-2 - EASY
        /// </summary>
        [JsonProperty("TIER 1-2 - EASY")]
        public IEnumerable<Server> Easy { get; set; }
        /// <summary>
        /// TIER 1-3 - NORMAL
        /// </summary>
        [JsonProperty("TIER 1-3 - NORMAL")]
        public IEnumerable<Server> Normal { get; set; }
        /// <summary>
        /// TIER 3-4 - MEDIUM
        /// </summary>
        [JsonProperty("TIER 3-4 - MEDIUM")]
        public IEnumerable<Server> Medium { get; set; }
        /// <summary>
        /// TIER 3-5 - HARD
        /// </summary>
        [JsonProperty("TIER 3-5 - HARD")]
        public IEnumerable<Server> Hard { get; set; }
        /// <summary>
        /// TIER 4-8 - TOP 350
        /// </summary>
        [JsonProperty("TIER 4-8 - TOP 350")]
        public IEnumerable<Server> Top { get; set; }
    }
}

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
        public IList<Server> Beginner { get; set; }
        /// <summary>
        /// TIER 1-2 - EASY
        /// </summary>
        [JsonProperty("TIER 1-2 - EASY")]
        public IList<Server> Easy { get; set; }
        /// <summary>
        /// TIER 1-3 - NORMAL
        /// </summary>
        [JsonProperty("TIER 1-3 - NORMAL")]
        public IList<Server> Normal { get; set; }
        /// <summary>
        /// TIER 3-4 - MEDIUM
        /// </summary>
        [JsonProperty("TIER 3-4 - MEDIUM")]
        public IList<Server> Medium { get; set; }
        /// <summary>
        /// TIER 3-5 - HARD
        /// </summary>
        [JsonProperty("TIER 3-5 - HARD")]
        public IList<Server> Hard { get; set; }
        /// <summary>
        /// TIER 4-8 - TOP 350
        /// </summary>
        [JsonProperty("TIER 4-8 - TOP 350")]
        public IList<Server> Top { get; set; }
    }
}

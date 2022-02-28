using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class PUBLIC
    {
        /// <summary>
        /// ONLY DUST2
        /// </summary>
        [JsonProperty("ONLY DUST2")]
        public IEnumerable<Server> OnlyDust { get; set; }
        /// <summary>
        /// ONLY MIRAGE
        /// </summary>
        [JsonProperty("ONLY MIRAGE")]
        public IEnumerable<Server> OnlyMirage { get; set; }
        /// <summary>
        /// NO LIMIT
        /// </summary>
        [JsonProperty("NO LIMIT")]
        public IEnumerable<Server> NoLimit { get; set; }
        /// <summary>
        /// COMPETITIVE MAPS
        /// </summary>
        [JsonProperty("COMPETITIVE MAPS")]
        public IEnumerable<Server> Competitive { get; set; }
        /// <summary>
        /// WH ON
        /// </summary>
        [JsonProperty("WH ON")]
        public IEnumerable<Server> WallHack { get; set; }
        /// <summary>
        /// ALL MAPS
        /// </summary>
        [JsonProperty("ALL MAPS")]
        public IEnumerable<Server> AllMaps { get; set; }
        /// <summary>
        /// DESTRUCTIBLE INFERNO
        /// </summary>
        [JsonProperty("DESTRUCTIBLE INFERNO")]
        public IEnumerable<Server> DestructibleInferno { get; set; }
    }
}

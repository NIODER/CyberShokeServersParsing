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
        public List<Server> OnlyDust { get; set; }
        /// <summary>
        /// ONLY MIRAGE
        /// </summary>
        [JsonProperty("ONLY MIRAGE")]
        public List<Server> OnlyMirage { get; set; }
        /// <summary>
        /// NO LIMIT
        /// </summary>
        [JsonProperty("NO LIMIT")]
        public List<Server> NoLimit { get; set; }
        /// <summary>
        /// COMPETITIVE MAPS
        /// </summary>
        [JsonProperty("COMPETITIVE MAPS")]
        public List<Server> Competitive { get; set; }
        /// <summary>
        /// WH ON
        /// </summary>
        [JsonProperty("WH ON")]
        public List<Server> WallHack { get; set; }
        /// <summary>
        /// ALL MAPS
        /// </summary>
        [JsonProperty("ALL MAPS")]
        public List<Server> AllMaps { get; set; }
        /// <summary>
        /// DESTRUCTIBLE INFERNO
        /// </summary>
        [JsonProperty("DESTRUCTIBLE INFERNO")]
        public List<Server> DestructibleInferno { get; set; }
    }
}

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
        public IList<Server> OnlyDust { get; set; }
        /// <summary>
        /// ONLY MIRAGE
        /// </summary>
        [JsonProperty("ONLY MIRAGE")]
        public IList<Server> OnlyMirage { get; set; }
        /// <summary>
        /// NO LIMIT
        /// </summary>
        [JsonProperty("TRENDING")]
        public IList<Server> Trending { get; set; }
        /// <summary>
        /// WH ON
        /// </summary>
        [JsonProperty("WH ON")]
        public IList<Server> WallHack { get; set; }
        /// <summary>
        /// ALL MAPS
        /// </summary>
        [JsonProperty("ALL MAPS")]
        public IList<Server> AllMaps { get; set; }
    }
}

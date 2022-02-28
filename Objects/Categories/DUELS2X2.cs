using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DUELS2X2
    {
        /// <summary>
        /// ONLY MIRAGE
        /// </summary>
        [JsonProperty("ONLY MIRAGE")]
        public IEnumerable<Server> OnlyMirage { get; set; }
        /// <summary>
        /// ONLY DUST2
        /// </summary>
        [JsonProperty("ONLY DUST2")]
        public IEnumerable<Server> OnlyDust { get; set; }
        /// <summary>
        /// ALL MAPS
        /// </summary>
        [JsonProperty("ALL MAPS")]
        public IEnumerable<Server> AllMaps { get; set; }
    }
}

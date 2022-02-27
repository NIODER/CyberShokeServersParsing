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
        public List<Server> OnlyMirage { get; set; }
        /// <summary>
        /// ONLY DUST2
        /// </summary>
        [JsonProperty("ONLY DUST2")]
        public List<Server> OnlyDust { get; set; }
        /// <summary>
        /// ALL MAPS
        /// </summary>
        [JsonProperty("ALL MAPS")]
        public List<Server> AllMaps { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class MINIGAMES
    {
        /// <summary>
        /// FUN MAPS
        /// </summary>
        [JsonProperty("FUN MAPS")]
        public IEnumerable<Server> FunMaps { get; set; }
        /// <summary>
        /// BATTLE MAPS
        /// </summary>
        [JsonProperty("BATTLE MAPS")]
        public IEnumerable<Server> BattleMaps { get; set; }
    }
}

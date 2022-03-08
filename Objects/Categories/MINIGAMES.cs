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
        public IList<Server> FunMaps { get; set; }
        /// <summary>
        /// BATTLE MAPS
        /// </summary>
        [JsonProperty("BATTLE MAPS")]
        public IList<Server> BattleMaps { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class AIM_DM
    {
        [JsonProperty]
        public List<Server> AIMDM { get; set; }
        /// <summary>
        /// PISTOL AIMDM
        /// </summary>
        [JsonProperty("PISTOL AIMDM")]
        public List<Server> PistolAimDM { get; set; }
    }
}

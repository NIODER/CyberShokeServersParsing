using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class AIM_DM
    {
        [JsonProperty]
        public IList<Server> AIMDM { get; set; }
        /// <summary>
        /// PISTOL AIMDM
        /// </summary>
        [JsonProperty("PISTOL AIMDM")]
        public IList<Server> PistolAimDM { get; set; }
    }
}

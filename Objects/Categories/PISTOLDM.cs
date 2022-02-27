using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class PISTOLDM
    {
        /// <summary>
        /// PISTOL HSDM
        /// </summary>
        [JsonProperty("PISTOL HSDM")]
        public List<Server> PistolHSDM { get; set; }
        /// <summary>
        /// PISTOLDM LITE
        /// </summary>
        [JsonProperty("PISTOLDM LITE")]
        public List<Server> PistolDMLite { get; set; }
        /// <summary>
        /// PISTOLDM
        /// </summary>
        [JsonProperty("PISTOLDM")]
        public List<Server> PistolsDM { get; set; }
    }
}

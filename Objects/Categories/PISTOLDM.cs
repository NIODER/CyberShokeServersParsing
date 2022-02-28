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
        public IEnumerable<Server> PistolHSDM { get; set; }
        /// <summary>
        /// PISTOLDM LITE
        /// </summary>
        [JsonProperty("PISTOLDM LITE")]
        public IEnumerable<Server> PistolDMLite { get; set; }
        /// <summary>
        /// PISTOLDM
        /// </summary>
        [JsonProperty("PISTOLDM")]
        public IEnumerable<Server> PistolsDM { get; set; }
    }
}

using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class PISTOLDM
    {
        /// <summary>
        /// PISTOL HSDM
        /// </summary>
        [JsonProperty("HSDM")]
        public IList<Server> HSDM { get; set; }
        /// <summary>
        /// PISTOLDM LITE
        /// </summary>
        [JsonProperty("MEDIUM")]
        public IList<Server> Medium { get; set; }
    }
}

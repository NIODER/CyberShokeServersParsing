using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class HSDM
    {
        /// <summary>
        /// HSDM LITE
        /// </summary>
        [JsonProperty("HSDM LITE")]
        public IEnumerable<Server> Lite { get; set; }
        /// <summary>
        /// HSDM
        /// </summary>
        [JsonProperty("HSDM")]
        public IEnumerable<Server> Classic { get; set; }
        /// <summary>
        /// HSDM ONETAP
        /// </summary>
        [JsonProperty("HSDM ONETAP")]
        public IEnumerable<Server> Onetap { get; set; }
    }
}

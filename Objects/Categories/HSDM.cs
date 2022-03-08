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
        public IList<Server> Lite { get; set; }
        /// <summary>
        /// HSDM
        /// </summary>
        [JsonProperty("HSDM")]
        public IList<Server> Classic { get; set; }
        /// <summary>
        /// HSDM ONETAP
        /// </summary>
        [JsonProperty("HSDM ONETAP")]
        public IList<Server> Onetap { get; set; }
    }
}

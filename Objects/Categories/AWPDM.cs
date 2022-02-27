using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class AWPDM
    {
        /// <summary>
        /// AWPDM LITE
        /// </summary>
        [JsonProperty("AWPDM LITE")]
        public List<Server> AwpDMLite { get; set; }
        /// <summary>
        /// AWPDM
        /// </summary>
        [JsonProperty("AWPDM")]
        public List<Server> AwpDM { get; set; }
        /// <summary>
        /// NOSCOPEDM
        /// </summary>
        [JsonProperty("NOSCOPEDM")]
        public List<Server> NoscopeDM { get; set; }
    }
}

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
        public IEnumerable<Server> AwpDMLite { get; set; }
        /// <summary>
        /// AWPDM
        /// </summary>
        [JsonProperty("AWPDM")]
        public IEnumerable<Server> AwpDM { get; set; }
        /// <summary>
        /// NOSCOPEDM
        /// </summary>
        [JsonProperty("NOSCOPEDM")]
        public IEnumerable<Server> NoscopeDM { get; set; }
    }
}

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
        public IList<Server> AwpDMLite { get; set; }
        /// <summary>
        /// AWPDM
        /// </summary>
        [JsonProperty("AWPDM")]
        public IList<Server> AwpDM { get; set; }
        /// <summary>
        /// NOSCOPEDM
        /// </summary>
        [JsonProperty("NOSCOPEDM")]
        public IList<Server> NoscopeDM { get; set; }
    }
}

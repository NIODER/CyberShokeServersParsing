using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class JAIL
    {
        /// <summary>
        /// CT 16
        /// </summary>
        [JsonProperty("CT 16")]
        public IEnumerable<Server> Sixteen { get; set; }
        /// <summary>
        /// CT 14
        /// </summary>
        [JsonProperty("CT 14")]
        public IEnumerable<Server> Fourteen { get; set; }
        /// <summary>
        /// CT 0
        /// </summary>
        [JsonProperty("CT 0")]
        public IEnumerable<Server> Zero { get; set; }
    }
}

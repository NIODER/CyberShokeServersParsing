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
        public IList<Server> Sixteen { get; set; }
        /// <summary>
        /// CT 14
        /// </summary>
        [JsonProperty("CT 14")]
        public IList<Server> Fourteen { get; set; }
        /// <summary>
        /// CT 0
        /// </summary>
        [JsonProperty("CT 0")]
        public IList<Server> Zero { get; set; }
    }
}

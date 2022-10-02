using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DM
    {
        /// <summary>
        /// EASY
        /// </summary>
        [JsonProperty("EASY")]
        public IList<Server> Easy { get; set; }
        /// <summary>
        /// 16 SLOTS
        /// </summary>
        [JsonProperty("MEDIUM")]
        public IList<Server> Medium { get; set; }
        /// <summary>
        /// NOAWP
        /// </summary>
        [JsonProperty("HARD")]
        public IList<Server> Hard { get; set; }
    }
}

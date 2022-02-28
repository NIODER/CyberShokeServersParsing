using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class AWP
    {
        /// <summary>
        /// AWP CANNONS
        /// </summary>
        [JsonProperty("AWP CANNONS")]
        public IEnumerable<Server> AwpCannons { get; set; }
        /// <summary>
        /// ONLY AWP LEGO 2
        /// </summary>
        [JsonProperty("ONLY AWP LEGO 2")]
        public IEnumerable<Server> OnlyAwpLego { get; set; }
        /// <summary>
        /// AWP SERVERS
        /// </summary>
        [JsonProperty("AWP SERVERS")]
        public IEnumerable<Server> AwpServers { get; set; }
    }
}

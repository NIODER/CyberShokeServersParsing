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
        public List<Server> AwpCannons { get; set; }
        /// <summary>
        /// ONLY AWP LEGO 2
        /// </summary>
        [JsonProperty("ONLY AWP LEGO 2")]
        public List<Server> OnlyAwpLego { get; set; }
        /// <summary>
        /// AWP SERVERS
        /// </summary>
        [JsonProperty("AWP SERVERS")]
        public List<Server> AwpServers { get; set; }
    }
}

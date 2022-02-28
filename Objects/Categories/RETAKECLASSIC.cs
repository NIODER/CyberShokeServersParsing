using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class RETAKECLASSIC
    {
        /// <summary>
        /// 1-3 LVL FACEIT
        /// </summary>
        [JsonProperty("1-3 LVL FACEIT")]
        public IEnumerable<Server> LowSkill { get; set; }
        /// <summary>
        /// 8-10 LVL FACEIT
        /// </summary>
        [JsonProperty("8-10 LVL FACEIT")]
        public IEnumerable<Server> Advanced { get; set; }
        /// <summary>
        /// 4-7 LVL FACEIT
        /// </summary>
        [JsonProperty("4-7 LVL FACEIT")]
        public IEnumerable<Server> Middle { get; set; }
        /// <summary>
        /// OPEN TO ALL - 9 SLOTS
        /// </summary>
        [JsonProperty("OPEN TO ALL - 9 SLOTS")]
        public IEnumerable<Server> NineSlots { get; set; }
        /// <summary>
        /// OPEN TO ALL - 7 SLOTS
        /// </summary>
        [JsonProperty("OPEN TO ALL - 7 SLOTS")]
        public IEnumerable<Server> SevenSlots { get; set; }
    }
}

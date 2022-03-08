using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class RETAKE
    {
        /// <summary>
        /// 1-3 LVL FACEIT
        /// </summary>
        [JsonProperty("1-3 LVL FACEIT")]
        public IList<Server> LowSkillFaceit { get; set; }
        /// <summary>
        /// 8-10 LVL FACEIT
        /// </summary>
        [JsonProperty("8-10 LVL FACEIT")]
        public IList<Server> AdvancedFaceit { get; set; }
        /// <summary>
        /// 9 SLOTS
        /// </summary>
        [JsonProperty("9 SLOTS")]
        public IList<Server> NineSlots { get; set; }
        /// <summary>
        /// 7 SLOTS
        /// </summary>
        [JsonProperty("7 SLOTS")]
        public IList<Server> SevenSlots { get; set; }
    }
}

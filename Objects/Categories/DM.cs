using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DM
    {
        /// <summary>
        /// 18 SLOTS LITE 1-3LVL FACEIT
        /// </summary>
        [JsonProperty("18 SLOTS LITE 1-3LVL FACEIT")]
        public IEnumerable<Server> EighteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 16 SLOTS LITE 1-3LVL FACEIT
        /// </summary>
        [JsonProperty("16 SLOTS LITE 1-3LVL FACEIT ")]
        public IEnumerable<Server> SixteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 14 SLOTS LITE 1-3LVL FACEIT
        /// </summary>
        [JsonProperty("14 SLOTS LITE 1-3LVL FACEIT ")]
        public IEnumerable<Server> FourteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 20 SLOTS LITE
        /// </summary>
        [JsonProperty("20 SLOTS LITE")]
        public IEnumerable<Server> TwentySlotsLite { get; set; }
        /// <summary>
        /// 18 SLOTS LITE
        /// </summary>
        [JsonProperty("18 SLOTS LITE")]
        public IEnumerable<Server> EighteenSlotsLite { get; set; }
        /// <summary>
        /// 18 SLOTS
        /// </summary>
        [JsonProperty("18 SLOTS")]
        public IEnumerable<Server> EighteenSlots { get; set; }
        /// <summary>
        /// 16 SLOTS LITE
        /// </summary>
        [JsonProperty("16 SLOTS LITE")]
        public IEnumerable<Server> SixteenSlotsLite { get; set; }
        /// <summary>
        /// 16 SLOTS
        /// </summary>
        [JsonProperty("16 SLOTS")]
        public IEnumerable<Server> SixteenSlots { get; set; }
        /// <summary>
        /// NOAWP
        /// </summary>
        [JsonProperty("NOAWP")]
        public IEnumerable<Server> NoAwp { get; set; }
    }
}

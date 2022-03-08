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
        public IList<Server> EighteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 16 SLOTS LITE 1-3LVL FACEIT
        /// </summary>
        [JsonProperty("16 SLOTS LITE 1-3LVL FACEIT ")]
        public IList<Server> SixteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 14 SLOTS LITE 1-3LVL FACEIT
        /// </summary>
        [JsonProperty("14 SLOTS LITE 1-3LVL FACEIT ")]
        public IList<Server> FourteenSlotsLiteLowSkill { get; set; }
        /// <summary>
        /// 20 SLOTS LITE
        /// </summary>
        [JsonProperty("20 SLOTS LITE")]
        public IList<Server> TwentySlotsLite { get; set; }
        /// <summary>
        /// 18 SLOTS LITE
        /// </summary>
        [JsonProperty("18 SLOTS LITE")]
        public IList<Server> EighteenSlotsLite { get; set; }
        /// <summary>
        /// 18 SLOTS
        /// </summary>
        [JsonProperty("18 SLOTS")]
        public IList<Server> EighteenSlots { get; set; }
        /// <summary>
        /// 16 SLOTS LITE
        /// </summary>
        [JsonProperty("16 SLOTS LITE")]
        public IList<Server> SixteenSlotsLite { get; set; }
        /// <summary>
        /// 16 SLOTS
        /// </summary>
        [JsonProperty("16 SLOTS")]
        public IList<Server> SixteenSlots { get; set; }
        /// <summary>
        /// NOAWP
        /// </summary>
        [JsonProperty("NOAWP")]
        public IList<Server> NoAwp { get; set; }
    }
}

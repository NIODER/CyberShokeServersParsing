using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class PISTOLRETAKE
    {
        /// <summary>
        /// 9 SLOTS
        /// </summary>
        [JsonProperty("9 SLOTS")]
        public IEnumerable<Server> NineSlots { get; set; }
    }
}

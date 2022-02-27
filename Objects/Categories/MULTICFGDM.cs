using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class MULTICFGDM
    {
        [JsonProperty("")]
        public List<Server> Servers { get; set; }
    }
}

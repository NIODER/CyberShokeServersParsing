using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class MULTICFGDM
    {
        [JsonProperty("")]
        public IList<Server> Servers { get; set; }
    }
}

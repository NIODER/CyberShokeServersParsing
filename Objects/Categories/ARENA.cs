using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class ARENA
    {
        [JsonProperty("")]
        public List<Server> Servers { get; set; }
    }
}

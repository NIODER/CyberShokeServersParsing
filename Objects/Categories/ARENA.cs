using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class ARENA
    {
        [JsonProperty("")]
        public IList<Server> Servers { get; set; }
    }
}

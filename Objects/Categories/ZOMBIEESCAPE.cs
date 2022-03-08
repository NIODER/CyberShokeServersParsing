using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class ZOMBIEESCAPE
    {
        [JsonProperty("")]
        public IList<Server> Servers { get; set; }
    }
}

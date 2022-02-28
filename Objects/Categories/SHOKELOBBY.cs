using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class SHOKELOBBY
    {
        [JsonProperty("")]
        public IEnumerable<Server> Servers { get; set; }
    }
}

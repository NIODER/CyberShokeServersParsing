using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class EXECUTE
    {
        [JsonProperty("")]
        public List<Server> Servers { get; set; }
    }
}

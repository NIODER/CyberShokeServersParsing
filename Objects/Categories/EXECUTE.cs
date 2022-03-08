using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class EXECUTE
    {
        [JsonProperty("")]
        public IList<Server> Servers { get; set; }
    }
}

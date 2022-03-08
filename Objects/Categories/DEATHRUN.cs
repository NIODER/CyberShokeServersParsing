using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DEATHRUN
    {
        [JsonProperty]
        public IList<Server> EASY { get; set; }
        [JsonProperty]
        public IList<Server> WARMUP { get; set; }
    }
}

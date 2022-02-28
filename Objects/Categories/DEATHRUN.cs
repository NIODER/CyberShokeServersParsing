using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DEATHRUN
    {
        [JsonProperty]
        public IEnumerable<Server> EASY { get; set; }
        [JsonProperty]
        public IEnumerable<Server> WARMUP { get; set; }
    }
}

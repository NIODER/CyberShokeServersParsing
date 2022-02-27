using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class DEATHRUN
    {
        [JsonProperty]
        public List<Server> EASY { get; set; }
        [JsonProperty]
        public List<Server> WARMUP { get; set; }
    }
}

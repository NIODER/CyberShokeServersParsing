﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class SHOKELOBBY
    {
        [JsonProperty("")]
        public List<Server> Servers { get; set; }
    }
}

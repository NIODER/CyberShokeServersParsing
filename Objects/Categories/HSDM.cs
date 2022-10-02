using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Objects.Categories
{
    class HSDM
    {
        /// <summary>
        /// HSDM
        /// </summary>
        [JsonProperty("")]
        public IList<Server> Classic { get; set; }
    }
}

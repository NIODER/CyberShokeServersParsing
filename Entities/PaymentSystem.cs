using Newtonsoft.Json;
using System.Collections.Generic;

namespace CyberShoke.Entities
{
    public class PaymentSystem
    {
        [JsonProperty("alt")]
        public string Alt { get; set; }
        [JsonProperty("label")]
        public string Label { get; set; }
        [JsonProperty("image_alt")]
        public string ImageAlt { get; set; }
        [JsonProperty("currency")]
        public IEnumerable<string> Currencies { get; set; }
    }
}

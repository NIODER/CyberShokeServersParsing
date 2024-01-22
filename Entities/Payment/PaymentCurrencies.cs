using Newtonsoft.Json;

namespace CyberShoke.Entities.Payment
{
    public class PaymentCurrencies
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

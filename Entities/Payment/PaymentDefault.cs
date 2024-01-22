using Newtonsoft.Json;

namespace CyberShoke.Entities.Payment
{
    public class PaymentDefault
    {
        [JsonProperty("sum")]
        public long Sum { get; set; }
        [JsonProperty("sum_coins")]
        public long SumCoins { get; set; }
        [JsonProperty("currency_sign")]
        public string CurrencySign { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

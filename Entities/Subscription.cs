using CyberShoke.Infrastructure.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CyberShoke.Entities
{
    public class Subscription
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("time"), JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan Time { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("price_coins")]
        public int PriceCoins { get; set; }
        [JsonProperty("discount")]
        public int? Discount { get; set; }
        [JsonProperty("access_gift")]
        public bool AccessGift { get; set; }
        [JsonProperty("access_recurring")]
        public bool AccessRecurring { get; set; }
        [JsonProperty("access_single")]
        public bool AccessSingle { get; set; }
        [JsonProperty("currency_conversion")]
        public IDictionary<string, float> CurrencyConversion { get; set; }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}

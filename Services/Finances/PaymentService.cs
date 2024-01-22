using CyberShoke.Entities;
using CyberShoke.Entities.Payment;
using CyberShoke.Infrastructure.CyberShokeData;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace CyberShoke.Services.Finances
{
    public class PaymentService : ICyberShokePayment
    {
        private readonly ICyberShokeData cyberShokeData;

        public PaymentService(ICyberShokeData cyberShokeData)
        {
            this.cyberShokeData = cyberShokeData;
        }

        public IEnumerable<Subscription> GetLiteSubscriptions()
        {
            JToken liteSubscriptionsToken = GetLiteSubscriptionsToken(GetJson());
            return liteSubscriptionsToken.ToObject<IEnumerable<Subscription>>();
        }

        private JObject GetJson()
        {
            return JObject.Parse(cyberShokeData.GetJsonData());
        }

        private JToken GetLiteSubscriptionsToken(JObject json)
        {
            return GetSubscriptionsToken(json)["LITE"];
        }

        private JToken GetSubscriptionsToken(JObject json)
        {
            return json["data"]["modules"]["subscriptions"]["data"];
        }

        public IEnumerable<PaymentCurrencies> GetPaymentCurrencies()
        {
            JToken paymentCurrenciesToken = GetPaymentCurrenciesToken(GetJson());
            return paymentCurrenciesToken.ToObject<IDictionary<string, PaymentCurrencies>>().Values;
        }

        private JToken GetPaymentCurrenciesToken(JObject json)
        {
            return json["data"]["modules"]["payment_currencies"]["data"];
        }

        public IDictionary<string, float> GetPaymentCurrenciesExchange()
        {
            JToken exchangeToken = GetPaymentCurrenciesExchangeToken(GetJson());
            return exchangeToken.ToObject<IDictionary<string, float>>();
        }

        private JToken GetPaymentCurrenciesExchangeToken(JObject json)
        {
            return json["data"]["modules"]["payment_currencies_exchange"]["data"];
        }

        public PaymentDefault GetPaymentDefault()
        {
            JToken paymentDefaultToken = GetPaymentDefaultToken(GetJson());
            return paymentDefaultToken.ToObject<PaymentDefault>();
        }

        private JToken GetPaymentDefaultToken(JObject json)
        {
            return json["data"]["modules"]["payment_default"]["data"];
        }

        public IEnumerable<PaymentSystem> GetPaymentSystems()
        {
            JToken paymentSystemsToken = GetPaymentSystemsToken(GetJson());
            return paymentSystemsToken.ToObject<IDictionary<string, PaymentSystem>>().Values;
        }

        private JToken GetPaymentSystemsToken(JObject json)
        {
            return json["data"]["modules"]["payment_systems"]["data"];
        }

        public IEnumerable<Subscription> GetPremiumSubscriptions()
        {
            JToken premiumSubscriptionsToken = GetPremiumSubscriptionsToken(GetJson());
            return premiumSubscriptionsToken.ToObject<IEnumerable<Subscription>>();
        }

        private JToken GetPremiumSubscriptionsToken(JObject json)
        {
            return GetSubscriptionsToken(json)["PREMIUM"];
        }
    }
}

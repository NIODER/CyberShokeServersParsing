using CyberShoke.Entities;
using CyberShoke.Entities.Payment;
using System.Collections.Generic;

namespace CyberShoke.Services.Finances
{
    public interface ICyberShokePayment
    {
        public IEnumerable<PaymentSystem> GetPaymentSystems();
        public IEnumerable<PaymentCurrencies> GetPaymentCurrencies();
        public IDictionary<string, float> GetPaymentCurrenciesExchange();
        public PaymentDefault GetPaymentDefault();
        public IEnumerable<Subscription> GetLiteSubscriptions();
        public IEnumerable<Subscription> GetPremiumSubscriptions();
    }
}

# CyberShokeServersParsing
Library to parse cybershoke.net counter-strike servers

Now (>=3.0) you need to use services that implements interfaces showed below. 

# Service classes

```
    CyberShoke.Services.Servers.ServersService
    CyberShoke.Services.Modes.ModesService
    CyberShoke.Services.Information.InformationService
    CyberShoke.Services.Finances.PaymentService
```

To create service class you need data class that implements this interface:

```
    public interface ICyberShokeData
    {
        public string GetJsonData();
    }
```
This is the way you want to request json data from cybershoke. There are two implementations by default: `CyberShoke.Infrastructure.CyberShokeData.CyberShokeStaticData` and `CyberShoke.Infrastructure.CyberShokeData.CyberShokeUpdatingData`.

Static saves copy of data in memory and then returns it every time. Updating requests cybershoke instead.

To create CyberShokeStaticData instance use `CyberShokeStaticData.Request()` or `CyberShokeStaticData.RequestAsync()` function.


# Interfaces:

Servers interface
```
    public interface ICyberShokeServers
    {
        public Stats GetStats();
        public IEnumerable<Game> GetGames();
        public IEnumerable<Server> GetCSGOServers();
        public IEnumerable<Server> GetCS2Servers();
        public IEnumerable<ServerPing> GetPingServers();
    }
```

```
    public interface ICyberShokeModes
    {
        public IEnumerable<Mode> GetCSGOModes();
        public IEnumerable<Mode> GetCS2Modes();
        public IEnumerable<string> ListAllModes();
        public IEnumerable<string> ListCSGOModes();
        public IEnumerable<string> ListCS2Modes();
    }
```

```
    public interface ICyberShokeInformation
    {
        public IDictionary<string, SocialNetwork> GetSocialNetworks();
        public string GetPolicyDocumentsType();
        public IEnumerable<string> GetLanguages();
        public IDictionary<string, string> GetCountries();
        public DateTime GetLastUpdateTimeUtc();
    }
```

```
    public interface ICyberShokePayment
    {
        public IEnumerable<PaymentSystem> GetPaymentSystems();
        public IEnumerable<PaymentCurrencies> GetPaymentCurrencies();
        public IDictionary<string, float> GetPaymentCurrenciesExchange();
        public PaymentDefault GetPaymentDefault();
        public IEnumerable<Subscription> GetLiteSubscriptions();
        public IEnumerable<Subscription> GetPremiumSubscriptions();
    }
```

# Entities

You can check entities in Entities/ folder of this repo.

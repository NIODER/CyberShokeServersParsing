using CyberShoke.Entities;
using CyberShoke.Infrastructure.Converters;
using CyberShoke.Infrastructure.CyberShokeData;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CyberShoke.Services.Information
{
    public class InformationService : ICyberShokeInformation
    {
        private readonly ICyberShokeData cyberShokeData;

        public InformationService(ICyberShokeData cyberShokeData)
        {
            this.cyberShokeData = cyberShokeData;
        }

        public IDictionary<string, string> GetCountries()
        {
            JToken countriesToken = GetCountriesToken(GetJson());
            return GetCountriesListFromToken(countriesToken);
        }

        private JObject GetJson()
        {
            return JObject.Parse(cyberShokeData.GetJsonData());
        }

        private JToken GetCountriesToken(JObject json)
        {
            return json["data"]["modules"]["country_list"]["data"];
        }

        private IDictionary<string, string> GetCountriesListFromToken(JToken countriesToken)
        {
            return countriesToken.ToObject<IDictionary<string, string>>();
        }

        public IEnumerable<string> GetLanguages()
        {
            JToken languagesToken = GetLanguagesToken(GetJson());
            return GetLanguagesFromToken(languagesToken);
        }

        private JToken GetLanguagesToken(JObject json)
        {
            return json["data"]["modules"]["langs"]["data"];
        }

        private IEnumerable<string> GetLanguagesFromToken(JToken languagesToken)
        {
            return languagesToken.ToObject<IDictionary<string, string>>().Values;
        }

        public string GetPolicyDocumentsType()
        {
            JToken policyDocumentsTypeToken = GetPolicyDocumentsTypeToken(GetJson());
            return policyDocumentsTypeToken.Value<string>();
        }

        private JToken GetPolicyDocumentsTypeToken(JObject json)
        {
            return json["data"]["modules"]["policy_documents"]["data"]["type"];
        }

        public IDictionary<string, SocialNetwork> GetSocialNetworks()
        {
            JToken socialNetworksToken = GetSocialNetworksToken(GetJson());
            return socialNetworksToken.ToObject<IDictionary<string, SocialNetwork>>();
        }

        private JToken GetSocialNetworksToken(JObject json)
        {
            return json["data"]["modules"]["social_networks"]["data"];
        }

        public DateTime GetLastUpdateTimeUtc()
        {
            JToken lastUpdateTimeToken = GetLastUpdateTimeToken(GetJson());
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new DateTimeConverter());
            return lastUpdateTimeToken.ToObject<DateTime>(serializer);
        }

        private JToken GetLastUpdateTimeToken(JObject json)
        {
            return json["data"]["modules"]["web_translation"]["data"]["unixtime_last_update"];
        }
    }
}

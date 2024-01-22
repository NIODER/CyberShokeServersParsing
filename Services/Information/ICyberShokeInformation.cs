using CyberShoke.Entities;
using System;
using System.Collections.Generic;

namespace CyberShoke.Services.Information
{
    public interface ICyberShokeInformation
    {
        public IDictionary<string, SocialNetwork> GetSocialNetworks();
        public string GetPolicyDocumentsType();
        public IEnumerable<string> GetLanguages();
        public IDictionary<string, string> GetCountries();
        public DateTime GetLastUpdateTimeUtc();
    }
}

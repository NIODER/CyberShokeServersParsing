using CyberShoke.Entities;
using CyberShoke.Infrastructure.CyberShokeData;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace CyberShoke.Services.Modes
{
    public class ModesService : ICyberShokeModes
    {
        private readonly ICyberShokeData cyberShokeData;

        public ModesService(ICyberShokeData cyberShokeData)
        {
            this.cyberShokeData = cyberShokeData;
        }

        public IEnumerable<Mode> GetCS2Modes()
        {
            JToken modesToken = GetModesToken(GetJson())["2"];
            return GetModesList(modesToken);
        }

        private JObject GetJson()
        {
            return JObject.Parse(cyberShokeData.GetJsonData());
        }

        private JToken GetModesToken(JObject json)
        {
            return json["data"]["modules"]["servers"]["data"]["modes"];
        }

        private IEnumerable<Mode> GetModesList(JToken modesVersionToken)
        {
            return modesVersionToken
                .Children()
                .Children()
                .Select(mode => mode.ToObject<Mode>());
        }

        public IEnumerable<Mode> GetCSGOModes()
        {
            JToken modesToken = GetModesToken(GetJson())["1"];
            return GetModesList(modesToken);
        }

        public IEnumerable<string> ListAllModes()
        {
            JToken listModesToken = GetListModesToken(GetJson())["all"];
            return listModesToken.ToObject<IDictionary<string, string>>().Values;
        }

        private JToken GetListModesToken(JObject json)
        {
            return json["data"]["modules"]["servers"]["data"]["list_modes"];
        }

        public IEnumerable<string> ListCSGOModes()
        {
            JToken listModesToken = GetListModesToken(GetJson())["1"];
            return listModesToken.ToObject<IDictionary<string, string>>().Values;
        }

        public IEnumerable<string> ListCS2Modes()
        {
            JToken listModesToken = GetListModesToken(GetJson())["2"];
            return listModesToken.ToObject<IDictionary<string, string>>().Values;
        }
    }
}

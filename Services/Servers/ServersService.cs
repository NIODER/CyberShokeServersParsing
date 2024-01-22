using CyberShoke.Entities;
using CyberShoke.Infrastructure.CyberShokeData;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace CyberShoke.Services.Servers
{
    public class ServersService : ICyberShokeServers
    {
        private readonly ICyberShokeData cyberShokeData;

        public ServersService(ICyberShokeData cyberShokeData)
        {
            this.cyberShokeData = cyberShokeData;
        }

        public IEnumerable<Server> GetCS2Servers()
        {
            JToken gameVersionToken = GetServersToken(GetJson())["2"];
            return GetServers(gameVersionToken);
        }

        private JObject GetJson()
        {
            return JObject.Parse(cyberShokeData.GetJsonData());
        }

        private JToken GetServersToken(JObject json)
        {
            return json["data"]["modules"]["servers"]["data"]["servers"];
        }

        private IEnumerable<Server> GetServers(JToken gameVersionToken)
        {
            return gameVersionToken
                .Children()
                .Children()
                .Children()
                .Children()
                .Children()
                .Select(server => server.ToObject<Server>());
        }

        public IEnumerable<Server> GetCSGOServers()
        {
            JToken gameVersionToken = GetServersToken(GetJson())["1"];
            return GetServers(gameVersionToken);
        }

        public IEnumerable<Game> GetGames()
        {
            JToken gamesListToken = GetGamesListToken(GetJson());
            return gamesListToken.ToObject<Dictionary<string, Game>>().Values.ToList();
        }

        private JToken GetGamesListToken(JObject json)
        {
            return json["data"]["modules"]["games_list"]["data"];
        }

        public IEnumerable<ServerPing> GetPingServers()
        {
            JToken serversPing = GetServersPingToken(GetJson());
            return serversPing.ToObject<List<ServerPing>>();
        }

        private JToken GetServersPingToken(JObject json)
        {
            return json["data"]["modules"]["servers_ping"]["data"];
        }

        public Stats GetStats()
        {
            JToken statsToken = GetStatsToken(GetJson());
            return statsToken.ToObject<Stats>();
        }

        private JToken GetStatsToken(JObject json)
        {
            return json["data"]["modules"]["servers"]["data"]["stats"];
        }
    }
}


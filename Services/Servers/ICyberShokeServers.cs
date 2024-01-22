using CyberShoke.Entities;
using System.Collections.Generic;

namespace CyberShoke.Services.Servers
{
    public interface ICyberShokeServers
    {
        public Stats GetStats();
        public IEnumerable<Game> GetGames();
        public IEnumerable<Server> GetCSGOServers();
        public IEnumerable<Server> GetCS2Servers();
        public IEnumerable<ServerPing> GetPingServers();
    }
}

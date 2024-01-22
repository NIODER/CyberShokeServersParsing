using Newtonsoft.Json;

namespace CyberShoke.Entities
{
    public class Stats
    {
        [JsonProperty("countPlayers")]
        public long CountPlayers { get; set; }
        [JsonProperty("countPlayers24h")]
        public long CountPlayers24h { get; set; }
        [JsonProperty("countNewPlayers24h")]
        public long CountNewPlayers24h { get; set; }
        [JsonProperty("countServers")]
        public int CountServers { get; set; }
        [JsonProperty("countModes")]
        public int CountModes { get; set; }
        [JsonProperty("countPlayersOnServers")]
        public long CountPlayersOnServers { get; set; }
        [JsonProperty("countMaxPlayersOnServers")]
        public long CountMaxPlayersOnServers { get; set; }
    }
}

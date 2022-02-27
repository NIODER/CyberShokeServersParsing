using Newtonsoft.Json;

namespace CyberShoke.Objects
{
    class Stats
    {
        [JsonProperty]
        public int countPlayers { get; set; }

        [JsonProperty]
        public int countPlayers24h { get; set; }

        [JsonProperty]
        public int countNewPlayers24h { get; set; }

        [JsonProperty]
        public int countServers { get; set; }

        [JsonProperty]
        public int countModes { get; set; }

        [JsonProperty]
        public int countPlayersOnServers { get; set; }

        [JsonProperty]
        public int countMaxPlayersOnServers { get; set; }
    }
}

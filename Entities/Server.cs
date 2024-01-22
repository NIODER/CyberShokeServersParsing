using CyberShoke.Infrastructure.Converters;
using Newtonsoft.Json;
using System.Net;

namespace CyberShoke.Entities
{
    public class Server
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name_alt")]
        public string AlternativeName { get; set; }
        [JsonProperty("ip"), JsonConverter(typeof(IpAddressConverter))]
        public IPAddress Ip { get; set; }
        [JsonProperty("port")]
        public int Port { get; set; }
        [JsonProperty("id_games")]
        public int IdGames { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("modeAlt")]
        public string AlternativeMode { get; set; }
        [JsonProperty("num")]
        public int Number { get; set; }
        [JsonProperty("location")]
        public string Location { get; set; }
        [JsonProperty("map")]
        public string Map { get; set; }
        [JsonProperty("prime"), JsonConverter(typeof(BooleanConverter))]
        public bool Prime { get; set; }
        [JsonProperty("players")]
        public uint Players { get; set; }
        [JsonProperty("maxplayers")]
        public uint MaxPlayers { get; set; }
        [JsonProperty("faceit_avg")]
        public int FaceitAvg { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("time_avg_complete")]
        public int? TimeAvgComplete { get; set; }
    }
}

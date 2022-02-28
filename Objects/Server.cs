using Newtonsoft.Json;

namespace CyberShoke.Objects
{
    public class Server
    {
        [JsonProperty]
        public int id { get; set; }

        [JsonProperty]
        public string name_alt { get; set; }

        [JsonProperty]
        public string ip { get; set; }

        [JsonProperty]
        public int port { get; set; }

        [JsonProperty]
        public string mode { get; set; }

        [JsonProperty]
        public string modeAlt { get; set; }

        [JsonProperty]
        public int num { get; set; }

        [JsonProperty]
        public string location { get; set; }

        [JsonProperty]
        public string country { get; set; }

        [JsonProperty]
        public string map { get; set; }

        [JsonProperty]
        public int prime { get; set; }

        [JsonProperty]
        public int players { get; set; }

        [JsonProperty]
        public int maxplayers { get; set; }

        [JsonProperty]
        public string status { get; set; }

        [JsonProperty]
        public int faceit_avg { get; set; }

        [JsonProperty]
        public int show_maps_avg_time { get; set; }

        [JsonProperty]
        public int statusAlt { get; set; }

        [JsonProperty]
        public string category { get; set; }

        [JsonProperty]
        public int? time_avg_complete { get; set; }

        [JsonProperty]
        public int faceit_limiter_enable { get; set; }

        [JsonProperty]
        public int? faceit_min_elo { get; set; }

        [JsonProperty]
        public int? faceit_max_elo { get; set; }
    }
}

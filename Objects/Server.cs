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
        public bool prime { get; set; }

        [JsonProperty]
        public int players { get; set; }

        [JsonProperty]
        public int maxplayers { get; set; }

        [JsonProperty]
        public string status { get; set; }

        [JsonProperty]
        public int faceit_avg { get; set; }

        [JsonProperty]
        public bool show_maps_avg_time { get; set; }

        [JsonProperty]
        public int statusAlt { get; set; }

        [JsonProperty]
        public string category { get; set; }

        [JsonProperty]
        public int? time_avg_complete { get; set; }

        [JsonProperty]
        public bool faceit_limiter_enable { get; set; }

        [JsonProperty]
        public int? faceit_min_elo { get; set; }

        [JsonProperty]
        public int? faceit_max_elo { get; set; }

        public override string ToString()
        {
            return $"id: {id},\n" +
                $"name_alt: {name_alt},\n" +
                $"ip: {ip},\n" +
                $"port: {port},\n" +
                $"mode: {mode},\n" +
                $"modeAlt: {modeAlt},\n" +
                $"num: {num},\n" +
                $"location: {location},\n" +
                $"country: {country},\n" +
                $"map: {map},\n" +
                $"prime: {prime},\n" +
                $"players: {players},\n" +
                $"maxplayers: {maxplayers},\n" +
                $"status: {status},\n" +
                $"faceit_avg: {faceit_avg},\n" +
                $"show_maps_avg_time: {show_maps_avg_time},\n" +
                $"statusAlt: {statusAlt},\n" +
                $"category: {category},\n" +
                $"time_avg_complete: {time_avg_complete},\n" +
                $"faceit_limiter_enable: {faceit_limiter_enable},\n" +
                $"faceit_min_elo: {faceit_min_elo},\n" +
                $"faceit_max_elo: {faceit_max_elo}";
        }
    }
}

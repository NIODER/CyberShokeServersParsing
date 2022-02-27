using CyberShoke.Objects.Categories;
using Newtonsoft.Json;

namespace CyberShoke.Objects
{
    class Servers
    {
        [JsonProperty]
        public AIM_DM AIMDM { get; set; }

        [JsonProperty]
        public AMONGUS AMONGUS { get; set; }

        [JsonProperty]
        public ARENA ARENA { get; set; }

        [JsonProperty]
        public AWP AWP { get; set; }

        [JsonProperty]
        public AWPDM AWPDM { get; set; }

        [JsonProperty]
        public BHOP BHOP { get; set; }

        [JsonProperty]
        public DEATHRUN DEATHRUN { get; set; }

        [JsonProperty]
        public DM DM { get; set; }

        [JsonProperty]
        public DUELS DUELS { get; set; }

        [JsonProperty]
        public DUELS2X2 DUELS2X2 { get; set; }

        [JsonProperty]
        public EXECUTE EXECUTE { get; set; }
        [JsonProperty]
        public HNS HNS { get; set; }

        [JsonProperty]
        public HSDM HSDM { get; set; }

        [JsonProperty]
        public JAIL JAIL { get; set; }

        [JsonProperty]
        public KNIFE KNIFE { get; set; }

        [JsonProperty]
        public KZ KZ { get; set; }

        [JsonProperty]
        public MANIAC MANIAC { get; set; }

        [JsonProperty]
        public MINIGAMES MINIGAMES { get; set; }

        [JsonProperty]
        public MULTICFGDM MULTICFGDM { get; set; }

        [JsonProperty]
        public PISTOLDM PISTOLDM { get; set; }

        [JsonProperty]
        public PISTOLRETAKE PISTOLRETAKE { get; set; }

        [JsonProperty]
        public PROPHUNT PROPHUNT { get; set; }

        [JsonProperty]
        public PUBLIC PUBLIC { get; set; }

        [JsonProperty]
        public RETAKE RETAKE { get; set; }

        [JsonProperty]
        public RETAKECLASSIC RETAKECLASSIC { get; set; }

        [JsonProperty]
        public SHOKELOBBY SHOKELOBBY { get; set; }

        [JsonProperty]
        public SURF SURF { get; set; }

        [JsonProperty]
        public SURFCOMBAT SURFCOMBAT { get; set; }

        [JsonProperty]
        public ZOMBIEESCAPE ZOMBIEESCAPE { get; set; }
    }
}

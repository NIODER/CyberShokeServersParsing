using CyberShoke.Objects;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace CyberShoke
{
    public class CSServers
    {
        private Response Json { get; set; }

        public CSServers()
        {
            WebRequest request = WebRequest.Create("https://apiv2.cybershoke.net:2096/api/v3/servers/online");
            WebHeaderCollection headerCollection = new WebHeaderCollection();
            string[] headers = {
                "Host: apiv2.cybershoke.net:2096",
                "Accept: application/json, text/plain, */*",
                "Origin: https://cybershoke.net",
                "Alt-Used: apiv2.cybershoke.net:2096",
                "Referer: https://cybershoke.net/",
                "Sec-Fetch-Dest: empty",
                "Sec-Fetch-Mode: cors",
                "Sec-Fetch-Site: same-site",
                "Pragma: no-cache",
                "Cache-Control: no-cache",
            };
            foreach (string header in headers)
            {
                headerCollection.Add(header);
            }
            request.Headers = headerCollection;
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            string json = new StreamReader(stream).ReadToEnd();
            Json = JsonConvert.DeserializeObject<Response>(json);
        }

        public (IEnumerable<Server> AIMDM, IEnumerable<Server> PISTOL_AIMDM) GetAIM_DM() =>
            (Json.servers.AIMDM.AIMDM, Json.servers.AIMDM.PistolAimDM);

        public IEnumerable<Server> GetAMONGUS() => Json.servers.AMONGUS.Servers;

        public IEnumerable<Server> GetARENA() => Json.servers.ARENA.Servers;

        public (IEnumerable<Server> AWP_CANNONS, IEnumerable<Server> ONLY_AWP_LEGO_2, IEnumerable<Server> AWP_SERVERS) GetAWP() =>
            (Json.servers.AWP.AwpCannons, Json.servers.AWP.OnlyAwpLego, Json.servers.AWP.AwpServers);

        public (IEnumerable<Server> AWPDM_LITE, IEnumerable<Server> AWPDM, IEnumerable<Server> NOSCOPEDM) GetAWPDM() =>
            (Json.servers.AWPDM.AwpDMLite, Json.servers.AWPDM.AwpDM, Json.servers.AWPDM.NoscopeDM);

        public (IEnumerable<Server> EASY, IEnumerable<Server> MEDIUM, IEnumerable<Server> HARD, IEnumerable<Server> LEGEMDARY, IEnumerable<Server> TICK) GetBHOP() =>
            (Json.servers.BHOP.Easy, Json.servers.BHOP.Medium, Json.servers.BHOP.Hard, Json.servers.BHOP.Legendary, Json.servers.BHOP.Tick);

        public (IEnumerable<Server> EASY, IEnumerable<Server> WARMUP) GetDEATHRUN() =>
            (Json.servers.DEATHRUN.EASY, Json.servers.DEATHRUN.WARMUP);

        public (IEnumerable<Server> EASY18,
            IEnumerable<Server> EASY16,
            IEnumerable<Server> EASY14,
            IEnumerable<Server> LITE20,
            IEnumerable<Server> LITE18,
            IEnumerable<Server> LITE16,
            IEnumerable<Server> SLOTS18,
            IEnumerable<Server> SLOTS16,
            IEnumerable<Server> NOAWP) GetDM() =>
            (Json.servers.DM.EighteenSlotsLiteLowSkill,
            Json.servers.DM.SixteenSlotsLiteLowSkill,
            Json.servers.DM.FourteenSlotsLiteLowSkill,
            Json.servers.DM.TwentySlotsLite,
            Json.servers.DM.EighteenSlotsLite,
            Json.servers.DM.SixteenSlotsLite,
            Json.servers.DM.EighteenSlots,
            Json.servers.DM.SixteenSlots,
            Json.servers.DM.NoAwp);

        public (IEnumerable<Server> ONLY_MIRAGE, IEnumerable<Server> ONLY_DUST2, IEnumerable<Server> ALL_MAPS) GetDUELS() =>
            (Json.servers.DUELS.OnlyMirage, Json.servers.DUELS.OnlyDust, Json.servers.DUELS.AllMaps);

        public (IEnumerable<Server> ONLY_MIRAGE, IEnumerable<Server> ONLY_DUST2, IEnumerable<Server> ALL_MAPS) GetDUELS2X2() =>
            (Json.servers.DUELS2X2.OnlyMirage, Json.servers.DUELS2X2.OnlyDust, Json.servers.DUELS2X2.AllMaps);

        public IEnumerable<Server> GetEXECUTE() => Json.servers.EXECUTE.Servers;

        public (IEnumerable<Server> HNS_SERVERS, IEnumerable<Server> HNS_NO_RULES, IEnumerable<Server> HNS_TRAINING) GetHNS() =>
            (Json.servers.HNS.HNSServers, Json.servers.HNS.NoRules, Json.servers.HNS.Training);

        public (IEnumerable<Server> HSDM_LITE, IEnumerable<Server> HSDM, IEnumerable<Server> HSDM_ONETAP) GetHSDM() =>
            (Json.servers.HSDM.Lite, Json.servers.HSDM.Classic, Json.servers.HSDM.Onetap);

        public (IEnumerable<Server> CT_16, IEnumerable<Server> CT_14, IEnumerable<Server> CT_0) GetJAIL() =>
            (Json.servers.JAIL.Sixteen, Json.servers.JAIL.Fourteen, Json.servers.JAIL.Zero);

        public IEnumerable<Server> GetKNIFE() => Json.servers.KNIFE.Servers;

        public (IEnumerable<Server> TIMER_EASY,
            IEnumerable<Server> GO_EASY,
            IEnumerable<Server> TIMER_MEDIUM,
            IEnumerable<Server> GO_MEDIUM,
            IEnumerable<Server> TIMER_HARD,
            IEnumerable<Server> GO_HARD) GetKZ() =>
            (Json.servers.KZ.TimerLowSkill,
            Json.servers.KZ.GoLowSkill,
            Json.servers.KZ.TimerMiddle,
            Json.servers.KZ.GoMiddle,
            Json.servers.KZ.TimerAdvanced,
            Json.servers.KZ.GoAdvanced);

        public IEnumerable<Server> GetMANIAC() => Json.servers.MANIAC.Servers;

        public (IEnumerable<Server> FUN_MAPS, IEnumerable<Server> BATTLE_MAPS) GetMINIGAMES() =>
            (Json.servers.MINIGAMES.FunMaps, Json.servers.MINIGAMES.BattleMaps);

        public IEnumerable<Server> GetMULTICFGDM() => Json.servers.MULTICFGDM.Servers;

        public (IEnumerable<Server> PISTOL_HSDM, IEnumerable<Server> PISTOLDM_LITE, IEnumerable<Server> PISTOLDM) GetPISTOLDM() =>
            (Json.servers.PISTOLDM.PistolHSDM, Json.servers.PISTOLDM.PistolDMLite, Json.servers.PISTOLDM.PistolsDM);

        public IEnumerable<Server> GetPISTOLRETAKE() => Json.servers.PISTOLRETAKE.NineSlots;

        public IEnumerable<Server> GetPROPHUNT() => Json.servers.PROPHUNT.Servers;

        public (IEnumerable<Server> ONLY_DUST2,
            IEnumerable<Server> ONLY_MIRAGE,
            IEnumerable<Server> NO_LIMIT,
            IEnumerable<Server> COMPETITIVE_MAPS,
            IEnumerable<Server> WH_ON,
            IEnumerable<Server> ALL_MAPS,
            IEnumerable<Server> DESTRUCTIBLE_INFERNO) GetPUBLIC() =>
            (Json.servers.PUBLIC.OnlyDust,
            Json.servers.PUBLIC.OnlyMirage,
            Json.servers.PUBLIC.NoLimit,
            Json.servers.PUBLIC.Competitive,
            Json.servers.PUBLIC.WallHack,
            Json.servers.PUBLIC.AllMaps,
            Json.servers.PUBLIC.DestructibleInferno);

        public (IEnumerable<Server> EASY,
            IEnumerable<Server> HARD,
            IEnumerable<Server> SLOTS9,
            IEnumerable<Server> SLOTS7) GetRETAKE() =>
            (Json.servers.RETAKE.LowSkillFaceit,
            Json.servers.RETAKE.AdvancedFaceit,
            Json.servers.RETAKE.NineSlots,
            Json.servers.RETAKE.SevenSlots);

        public (IEnumerable<Server> EASY,
            IEnumerable<Server> MEDIUM,
            IEnumerable<Server> HARD,
            IEnumerable<Server> SLOTS9,
            IEnumerable<Server> SLOTS7) GetRETAKECLASSIC() =>
            (Json.servers.RETAKECLASSIC.LowSkill,
            Json.servers.RETAKECLASSIC.Middle,
            Json.servers.RETAKECLASSIC.Advanced,
            Json.servers.RETAKECLASSIC.NineSlots,
            Json.servers.RETAKECLASSIC.SevenSlots);

        public IEnumerable<Server> GetSHOKELOBBY() => Json.servers.SHOKELOBBY.Servers;

        public (IEnumerable<Server> BEGINNER,
            IEnumerable<Server> EASY,
            IEnumerable<Server> NORMAL,
            IEnumerable<Server> MEDIUM,
            IEnumerable<Server> HARD,
            IEnumerable<Server> TOP) GetSURF() =>
            (Json.servers.SURF.Beginner,
            Json.servers.SURF.Easy,
            Json.servers.SURF.Normal,
            Json.servers.SURF.Medium,
            Json.servers.SURF.Hard,
            Json.servers.SURF.Top);

        public IEnumerable<Server> GetSURFCOMBAT() => Json.servers.SURFCOMBAT.Servers;

        public IEnumerable<Server> GetZOMBIEESCAPE() => Json.servers.ZOMBIEESCAPE.Servers;
    }
}

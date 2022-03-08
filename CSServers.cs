using CyberShoke.Objects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace CyberShoke
{
    public class CSServers
    {
        public IList<string> Listmodes { get; }
        public IList<Mode> Modes { get; }
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

            var modes = JObject.Parse(json).GetValue("modes").Children();
            Modes = new List<Mode>();
            foreach (var mode in modes)
            {
                string body = string.Empty;
                foreach (var item in mode.Children())
                {
                    body += item;
                }
                var mod = JsonConvert.DeserializeObject<Mode>(body);
                Modes.Add(mod);
            }

            var listmode = JObject.Parse(json).GetValue("listmodes").Children();
            Listmodes = new List<string>();
            foreach (var child in listmode.Values())
            {
                this.Listmodes.Add(child.ToString());
            }
        }


        public (IList<Server> AIMDM, IList<Server> PISTOL_AIMDM) GetAIM_DM() =>
            (Json.servers.AIMDM.AIMDM, Json.servers.AIMDM.PistolAimDM);

        public IList<Server> GetAMONGUS() => Json.servers.AMONGUS.Servers;

        public IList<Server> GetARENA() => Json.servers.ARENA.Servers;

        public (IList<Server> AWP_CANNONS, IList<Server> ONLY_AWP_LEGO_2, IList<Server> AWP_SERVERS) GetAWP() =>
            (Json.servers.AWP.AwpCannons, Json.servers.AWP.OnlyAwpLego, Json.servers.AWP.AwpServers);

        public (IList<Server> AWPDM_LITE, IList<Server> AWPDM, IList<Server> NOSCOPEDM) GetAWPDM() =>
            (Json.servers.AWPDM.AwpDMLite, Json.servers.AWPDM.AwpDM, Json.servers.AWPDM.NoscopeDM);

        public (IList<Server> EASY, IList<Server> MEDIUM, IList<Server> HARD, IList<Server> LEGEMDARY, IList<Server> TICK) GetBHOP() =>
            (Json.servers.BHOP.Easy, Json.servers.BHOP.Medium, Json.servers.BHOP.Hard, Json.servers.BHOP.Legendary, Json.servers.BHOP.Tick);

        public (IList<Server> EASY, IList<Server> WARMUP) GetDEATHRUN() =>
            (Json.servers.DEATHRUN.EASY, Json.servers.DEATHRUN.WARMUP);

        public (IList<Server> EASY18,
            IList<Server> EASY16,
            IList<Server> EASY14,
            IList<Server> LITE20,
            IList<Server> LITE18,
            IList<Server> LITE16,
            IList<Server> SLOTS18,
            IList<Server> SLOTS16,
            IList<Server> NOAWP) GetDM() =>
            (Json.servers.DM.EighteenSlotsLiteLowSkill,
            Json.servers.DM.SixteenSlotsLiteLowSkill,
            Json.servers.DM.FourteenSlotsLiteLowSkill,
            Json.servers.DM.TwentySlotsLite,
            Json.servers.DM.EighteenSlotsLite,
            Json.servers.DM.SixteenSlotsLite,
            Json.servers.DM.EighteenSlots,
            Json.servers.DM.SixteenSlots,
            Json.servers.DM.NoAwp);

        public (IList<Server> ONLY_MIRAGE, IList<Server> ONLY_DUST2, IList<Server> ALL_MAPS) GetDUELS() =>
            (Json.servers.DUELS.OnlyMirage, Json.servers.DUELS.OnlyDust, Json.servers.DUELS.AllMaps);

        public (IList<Server> ONLY_MIRAGE, IList<Server> ONLY_DUST2, IList<Server> ALL_MAPS) GetDUELS2X2() =>
            (Json.servers.DUELS2X2.OnlyMirage, Json.servers.DUELS2X2.OnlyDust, Json.servers.DUELS2X2.AllMaps);

        public IList<Server> GetEXECUTE() => Json.servers.EXECUTE.Servers;

        public (IList<Server> HNS_SERVERS, IList<Server> HNS_NO_RULES, IList<Server> HNS_TRAINING) GetHNS() =>
            (Json.servers.HNS.HNSServers, Json.servers.HNS.NoRules, Json.servers.HNS.Training);

        public (IList<Server> HSDM_LITE, IList<Server> HSDM, IList<Server> HSDM_ONETAP) GetHSDM() =>
            (Json.servers.HSDM.Lite, Json.servers.HSDM.Classic, Json.servers.HSDM.Onetap);

        public (IList<Server> CT_16, IList<Server> CT_14, IList<Server> CT_0) GetJAIL() =>
            (Json.servers.JAIL.Sixteen, Json.servers.JAIL.Fourteen, Json.servers.JAIL.Zero);

        public IList<Server> GetKNIFE() => Json.servers.KNIFE.Servers;

        public (IList<Server> TIMER_EASY,
            IList<Server> GO_EASY,
            IList<Server> TIMER_MEDIUM,
            IList<Server> GO_MEDIUM,
            IList<Server> TIMER_HARD,
            IList<Server> GO_HARD) GetKZ() =>
            (Json.servers.KZ.TimerLowSkill,
            Json.servers.KZ.GoLowSkill,
            Json.servers.KZ.TimerMiddle,
            Json.servers.KZ.GoMiddle,
            Json.servers.KZ.TimerAdvanced,
            Json.servers.KZ.GoAdvanced);

        public IList<Server> GetMANIAC() => Json.servers.MANIAC.Servers;

        public (IList<Server> FUN_MAPS, IList<Server> BATTLE_MAPS) GetMINIGAMES() =>
            (Json.servers.MINIGAMES.FunMaps, Json.servers.MINIGAMES.BattleMaps);

        public IList<Server> GetMULTICFGDM() => Json.servers.MULTICFGDM.Servers;

        public (IList<Server> PISTOL_HSDM, IList<Server> PISTOLDM_LITE, IList<Server> PISTOLDM) GetPISTOLDM() =>
            (Json.servers.PISTOLDM.PistolHSDM, Json.servers.PISTOLDM.PistolDMLite, Json.servers.PISTOLDM.PistolsDM);

        public IList<Server> GetPISTOLRETAKE() => Json.servers.PISTOLRETAKE.NineSlots;

        public IList<Server> GetPROPHUNT() => Json.servers.PROPHUNT.Servers;

        public (IList<Server> ONLY_DUST2,
            IList<Server> ONLY_MIRAGE,
            IList<Server> NO_LIMIT,
            IList<Server> COMPETITIVE_MAPS,
            IList<Server> WH_ON,
            IList<Server> ALL_MAPS,
            IList<Server> DESTRUCTIBLE_INFERNO) GetPUBLIC() =>
            (Json.servers.PUBLIC.OnlyDust,
            Json.servers.PUBLIC.OnlyMirage,
            Json.servers.PUBLIC.NoLimit,
            Json.servers.PUBLIC.Competitive,
            Json.servers.PUBLIC.WallHack,
            Json.servers.PUBLIC.AllMaps,
            Json.servers.PUBLIC.DestructibleInferno);

        public (IList<Server> EASY,
            IList<Server> HARD,
            IList<Server> SLOTS9,
            IList<Server> SLOTS7) GetRETAKE() =>
            (Json.servers.RETAKE.LowSkillFaceit,
            Json.servers.RETAKE.AdvancedFaceit,
            Json.servers.RETAKE.NineSlots,
            Json.servers.RETAKE.SevenSlots);

        public (IList<Server> EASY,
            IList<Server> MEDIUM,
            IList<Server> HARD,
            IList<Server> SLOTS9,
            IList<Server> SLOTS7) GetRETAKECLASSIC() =>
            (Json.servers.RETAKECLASSIC.LowSkill,
            Json.servers.RETAKECLASSIC.Middle,
            Json.servers.RETAKECLASSIC.Advanced,
            Json.servers.RETAKECLASSIC.NineSlots,
            Json.servers.RETAKECLASSIC.SevenSlots);

        public IList<Server> GetSHOKELOBBY() => Json.servers.SHOKELOBBY.Servers;

        public (IList<Server> BEGINNER,
            IList<Server> EASY,
            IList<Server> NORMAL,
            IList<Server> MEDIUM,
            IList<Server> HARD,
            IList<Server> TOP) GetSURF() =>
            (Json.servers.SURF.Beginner,
            Json.servers.SURF.Easy,
            Json.servers.SURF.Normal,
            Json.servers.SURF.Medium,
            Json.servers.SURF.Hard,
            Json.servers.SURF.Top);

        public IList<Server> GetSURFCOMBAT() => Json.servers.SURFCOMBAT.Servers;

        public IList<Server> GetZOMBIEESCAPE() => Json.servers.ZOMBIEESCAPE.Servers;
    }
}

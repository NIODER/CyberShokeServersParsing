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
            WebRequest request = WebRequest.Create("https://api.cybershoke.net/api/v1/main/data");
            WebHeaderCollection headerCollection = new WebHeaderCollection();
            string[] headers = {
                "Host: api.cybershoke.net",
                "Accept: application/json, text/plain, */*",
                "Origin: https://cybershoke.net",
                "Alt-Used: api.cybershoke.net",
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
            JObject jsonObject = JObject.Parse(json);
            json = jsonObject["data"]["modules"]["servers"]["data"].ToString();
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

        public IList<Server> GetAWPDM() => Json.servers.AWPDM.AwpDM;

        public (IList<Server> EASY, IList<Server> MEDIUM, IList<Server> HARD, IList<Server> LEGENDARY) GetBHOP() =>
            (Json.servers.BHOP.Easy, Json.servers.BHOP.Medium, Json.servers.BHOP.Hard, Json.servers.BHOP.Legendary);

        public (IList<Server> EASY, IList<Server> WARMUP) GetDEATHRUN() =>
            (Json.servers.DEATHRUN.EASY, Json.servers.DEATHRUN.WARMUP);

        public (IList<Server> Easy, IList<Server> Medium, IList<Server> Hard) GetDM() => 
            (Json.servers.DM.Easy, Json.servers.DM.Medium, Json.servers.DM.Hard);

        public (IList<Server> ONLY_MIRAGE, IList<Server> ONLY_DUST2, IList<Server> ALL_MAPS) GetDUELS() =>
            (Json.servers.DUELS.OnlyMirage, Json.servers.DUELS.OnlyDust, Json.servers.DUELS.AllMaps);

        public (IList<Server> ONLY_MIRAGE, IList<Server> ONLY_DUST2, IList<Server> ALL_MAPS) GetDUELS2X2() =>
            (Json.servers.DUELS2X2.OnlyMirage, Json.servers.DUELS2X2.OnlyDust, Json.servers.DUELS2X2.AllMaps);

        public IList<Server> GetEXECUTE() => Json.servers.EXECUTE.Servers;

        public (IList<Server> HNS_SERVERS, IList<Server> HNS_NO_RULES, IList<Server> HNS_TRAINING) GetHNS() =>
            (Json.servers.HNS.HNSServers, Json.servers.HNS.NoRules, Json.servers.HNS.Training);

        public IList<Server> GetHSDM() => Json.servers.HSDM.Classic;

        public (IList<Server> CT_16, IList<Server> CT_14, IList<Server> CT_0) GetJAIL() =>
            (Json.servers.JAIL.Sixteen, Json.servers.JAIL.Fourteen, Json.servers.JAIL.Zero);

        public IList<Server> GetKNIFE() => Json.servers.KNIFE.Servers;

        public (IList<Server> GO_EASY, IList<Server> GO_MEDIUM, IList<Server> GO_HARD) GetKZ() =>
            (Json.servers.KZ.GoLowSkill, Json.servers.KZ.GoMiddle, Json.servers.KZ.GoAdvanced);

        public IList<Server> GetMANIAC() => Json.servers.MANIAC.Servers;

        public (IList<Server> FUN_MAPS, IList<Server> BATTLE_MAPS) GetMINIGAMES() =>
            (Json.servers.MINIGAMES.FunMaps, Json.servers.MINIGAMES.BattleMaps);

        public IList<Server> GetMULTICFGDM() => Json.servers.MULTICFGDM.Servers;

        public (IList<Server> HSDM, IList<Server> MEDIUM) GetPISTOLDM() =>
            (Json.servers.PISTOLDM.HSDM, Json.servers.PISTOLDM.Medium);

        public IList<Server> GetPISTOLRETAKE() => Json.servers.PISTOLRETAKE.NineSlots;

        public IList<Server> GetPROPHUNT() => Json.servers.PROPHUNT.Servers;

        public (IList<Server> ONLY_DUST2,
            IList<Server> ONLY_MIRAGE,
            IList<Server> TRENDING,
            IList<Server> WH_ON,
            IList<Server> ALL_MAPS) GetPUBLIC() =>
            (Json.servers.PUBLIC.OnlyDust,
            Json.servers.PUBLIC.OnlyMirage,
            Json.servers.PUBLIC.Trending,
            Json.servers.PUBLIC.WallHack,
            Json.servers.PUBLIC.AllMaps);

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

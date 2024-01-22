using System;
using System.Threading.Tasks;

namespace CyberShoke.Infrastructure.CyberShokeData
{
    public class CyberShokeStaticData : ICyberShokeData
    {
        private readonly string json = null;

        private CyberShokeStaticData(string json)
        {
            this.json = json;
        }

        public static CyberShokeStaticData Request()
        {
            return new CyberShokeStaticData(CyberShokeWebRequest.GetJson());
        }

        public static async Task<CyberShokeStaticData> RequestAsync()
        {
            return new CyberShokeStaticData(await CyberShokeWebRequest.GetJsonAsync());
        }

        public string GetJsonData()
        {
            if (string.IsNullOrEmpty(json))
            {
                throw new ArgumentNullException(nameof(json));
            }
            return json;
        }
    }
}

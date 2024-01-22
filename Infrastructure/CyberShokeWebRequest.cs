using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace CyberShoke.Infrastructure
{
    public static class CyberShokeWebRequest
    {
        private const string URL_REQUEST_ADDRESS = @"api.cybershoke.net";
        private const string API_VERSION2 = @"api/v2";
        private const string METHOD = @"main/data";

        private static string CyberShokeUrl => $"https://{URL_REQUEST_ADDRESS}/{API_VERSION2}/{METHOD}";

        private static NameValueCollection Headers => new NameValueCollection
        {
            { "Host", "api.cybershoke.net" },
            { "Accept", "application/json, text/plain, */*" },
            { "Origin", "https://cybershoke.net" },
            { "Referer", "https://cybershoke.net/" },
            { "Sec-Fetch-Dest", "empty" },
            { "Sec-Fetch-Mode", "cors" },
            { "Pragma", "no-cache" },
            { "Cache-Control", "no-cache" }
        };

        public static string GetJson()
        {
            WebRequest request = CreateRequest();
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            return new StreamReader(stream).ReadToEnd();
        }

        public static async Task<string> GetJsonAsync()
        {
            WebRequest request = CreateRequest();
            WebResponse response = await request.GetResponseAsync();
            Stream stream = response.GetResponseStream();
            return new StreamReader(stream).ReadToEnd();
        }

        private static WebRequest CreateRequest()
        {
            WebRequest request = WebRequest.Create(CyberShokeUrl);
            request.Headers.Add(Headers);
            return request;
        }
    }
}

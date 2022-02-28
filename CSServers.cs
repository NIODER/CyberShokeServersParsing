using CyberShoke.Objects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CyberShoke
{
    class CSServers
    {
        public Response obj { get; }

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
            obj = JsonConvert.DeserializeObject<Response>(json);
        }
    }
}

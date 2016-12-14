using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NetRdapClient.Objects;
using Newtonsoft.Json;

namespace NetRdapClient
{
    public class RdapClient
    {
        private readonly string _baseUrl;
        private readonly Encoding _encoding;

        public RdapClient(string baseUrl = "http://rdap.org/", Encoding encoding = null)
        {
            if (baseUrl == null) throw new ArgumentNullException(nameof(baseUrl));

            _baseUrl = baseUrl;
            _encoding = encoding ?? Encoding.UTF8;
        }

        public string BaseUrl => _baseUrl;

        public async Task<RdapResponse> Get(RdapObjectType type, string id)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));

            string url = $"{_baseUrl}{type.ToString().ToLowerInvariant()}/{id}";
            var client = (HttpWebRequest) WebRequest.Create(url);
            client.Accept = "application/json";

            using (var response = (HttpWebResponse)await client.GetResponseAsync())
            {
                if (response.StatusCode == HttpStatusCode.NotFound)
                    return null;

                using (var stream = response.GetResponseStream())
                {
                    if (stream == null)
                        throw new IOException("Unexpected NULL response");

                    using (var reader = new StreamReader(stream, _encoding))
                    {
                        var content = reader.ReadToEnd();
                        return JsonConvert.DeserializeObject<RdapResponse>(content);
                    }
                }
            }
        }
    }
}

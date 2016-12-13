using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    // NOTE: curre
    public class RdapResponse
    {
        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("startAddress")]
        public string StartAddress { get; set; }

        [JsonProperty("endAddress")]
        public string EndAddress { get; set; }

        [JsonProperty("ipVersion")]
        public string IpVersion { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("entities")]
        public IList<RdapEntity> Entities { get; set; }

        [JsonProperty("links")]
        public IList<RdapLink> Links { get; set; }

        [JsonProperty("events")]
        public IList<RdapEvent> Events { get; set; }

        [JsonProperty("rdapConformance")]
        public IList<string> RdapConformance { get; set; }

        [JsonProperty("notices")]
        public IList<RdapNotice> Notices { get; set; }

        [JsonProperty("port43")]
        public string Port43 { get; set; }

        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }
    }
}

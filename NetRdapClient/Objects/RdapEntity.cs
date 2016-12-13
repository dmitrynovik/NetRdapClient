using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    public class RdapEntity
    {
        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("vcardArray")]
        public IList<object> VcardArray { get; set; }

        [JsonProperty("roles")]
        public IList<string> Roles { get; set; }

        [JsonProperty("links")]
        public IList<RdapLink> Links { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("networks")]
        public IList<string> Networks { get; set; }

        [JsonProperty("autnums")]
        public IList<string> Autnums { get; set; }

        [JsonProperty("entities")]
        public IList<RdapEntity> Entities { get; set; }

        [JsonProperty("events")]
        public IList<RdapEvent> Events { get; set; }
    }
}
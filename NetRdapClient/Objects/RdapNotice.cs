using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    public class RdapNotice
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public IList<string> Description { get; set; }

        [JsonProperty("links")]
        public IList<RdapLink> Links { get; set; }
    }
}
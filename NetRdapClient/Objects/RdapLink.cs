using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    public class RdapLink
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rel")]
        public string Rel { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
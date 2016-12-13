using System;
using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    public class RdapEvent
    {
        [JsonProperty("eventAction")]
        public string EventAction { get; set; }

        [JsonProperty("eventDate")]
        public DateTime EventDate { get; set; }
    }
}
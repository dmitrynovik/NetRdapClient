using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NetRdapClient.Objects
{
    public class RdapEntity
    {
        private readonly JCardParser _jCardParser = new JCardParser();
        private IList<object> _vcardArrayRaw;

        public RdapEntity()
        {
            Telephones = new List<string>();
            Emails = new List<string>();
            Address = new List<string>();
        }

        [JsonProperty("objectClassName")]
        public string ObjectClassName { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("vcardArray")]
        public IList<object> VcardArrayRaw
        {
            get { return _vcardArrayRaw; }
            set
            {
                _vcardArrayRaw = value;
                try
                {
                    // Ugly but necessary JCard parsing. For jCard, see https://www.rfc-editor.org/info/rfc7095
                    _jCardParser.Parse(_vcardArrayRaw, this);
                }
                catch (Exception ex)
                {
                    throw new JCardParseException(ex);
                }
            }
        }

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

        [JsonIgnore]
        public string FullName { get; set; }

        [JsonIgnore]
        public string Kind { get; set; }

        [JsonIgnore]
        public string Organisation { get; set; }

        [JsonIgnore]
        public ICollection<string> Telephones { get; set; }

        [JsonIgnore]
        public ICollection<string> Emails { get; set; }

        [JsonIgnore]
        public ICollection<string> Address { get; set; }
    }
}
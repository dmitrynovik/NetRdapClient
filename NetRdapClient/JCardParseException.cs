using System;

namespace NetRdapClient
{
    public class JCardParseException : Exception
    {
        public JCardParseException(Exception exception) : base("Could not parse jCard", exception) { }

        public JCardParseException(string message) : base(message) {  }
    }
}
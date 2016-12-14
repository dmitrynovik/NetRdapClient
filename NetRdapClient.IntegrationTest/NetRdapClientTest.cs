using System.Linq;
using System.Threading.Tasks;
using NetRdapClient.Objects;
using NUnit.Framework;

namespace NetRdapClient.IntegrationTest
{
    [TestFixture]
    public class NetRdapClientTest
    {
        private RdapResponse _response;
        const string ExpectedStartAddress = "200.7.84.0";

        public NetRdapClientTest()
        {

            var client = new RdapClient();
            _response = client.Get(RdapObjectType.Ip, ExpectedStartAddress).Result;

        }

        [Test]
        public async Task Correct_Ip_Address_Returned()
        {
            Assert.AreEqual(ExpectedStartAddress, _response.StartAddress);
        }

        [Test]
        public async Task Correct_Street_Address_Returned()
        {
            Assert.Contains("Montevideo", _response.Entities.SelectMany(x => x.Address).ToArray());
        }

        [Test]
        public async Task Correct_Full_Name_Returned()
        {
            Assert.Contains("Carlos M. Martínez", _response.Entities.Select(x => x.FullName).ToArray());
        }

        [Test]
        public async Task Correct_Organisation_Returned()
        {
            Assert.Contains("LACNIC - Latin American and Caribbean IP address", _response.Entities.Select(x => x.Organisation).ToArray());
        }

        [Test]
        public async Task Correct_Tel_Returned()
        {
            Assert.Contains("598 2 6042222", _response.Entities.SelectMany(x => x.Telephones).ToArray());
        }

        [Test]
        public async Task Correct_Email_Returned()
        {
            Assert.Contains("ipadmin@lacnic.net", _response.Entities.SelectMany(x => x.Emails).Select(x => x.ToLowerInvariant()).ToArray());
        }
    }
}

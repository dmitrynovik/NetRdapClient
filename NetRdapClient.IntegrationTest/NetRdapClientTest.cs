using System.Threading.Tasks;
using NUnit.Framework;

namespace NetRdapClient.IntegrationTest
{
    [TestFixture]
    public class NetRdapClientTest
    {
        [Test]
        public async Task When_Type_Ip_And_Key_Addr_Correct_Address_Returned()
        {
            const string expectedStartAddress = "200.7.84.0";

            var client = new RdapClient();
            var ipObject = await client.Get(RdapObjectType.Ip, expectedStartAddress);
            Assert.AreEqual(expectedStartAddress, ipObject.StartAddress);
        }
    }
}

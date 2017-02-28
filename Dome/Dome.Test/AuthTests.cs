using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dome.Client;

namespace Dome.Test
{

    [TestClass]
    public class AuthTests
    {

        [TestMethod]
        public void Config()
        {
            Assert.IsFalse(string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Dome_urlBase"]));
            Assert.IsFalse(string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Dome_username"]));
            Assert.IsFalse(string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["Dome_password"]));

        }

        [TestMethod]
        public void AuthentificationShouldSucceed()
        {
            var domeClient = TestHelper.GetNewClient();

            Assert.IsTrue(domeClient.StructureProfilId != 0);
            Assert.IsTrue(domeClient.AccountId != 0);


        }
    }

}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace Dome.Test
{
    [TestClass]
    public class AuthTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            
        }

        [TestMethod]
        public void AuthentificationShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));
        }

        [TestMethod]
        public void AuthentificationShouldFail()
        {
            string username = "toto";
            string password = "tata";

            AuthentificationHelper.Instance.connect(username, password);

            Assert.IsFalse(AuthentificationHelper.Instance.isConnected);
            Assert.IsTrue(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));
        }
    }
}

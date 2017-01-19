using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R511;
using Dome.R521;

namespace Dome.Test
{
    [TestClass]
    public class DomeTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];
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

        [TestMethod]
        public void CreationPersonShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

            var person = new CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassagne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69003",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "personne test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "guillaume",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "dumont",
                personLieuDit = "",
                personMobilePhoneNumber = "",
                personNIR = "",
                personPhoneNumber = "",
                personPostBox = "",
                personRoadName = "rue lalala",
                personRoadType = "",
                personRoadNumber = "",
                personRPPS = ""
            };

            CreatePersonResponseDto resp = DomeCall.createPerson(person);
            Assert.IsTrue(resp.statusId == 0);
        }

        [TestMethod]
        public void CreationPatientShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

            var person = new CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassagne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69003",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "personne test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "guillaume",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "dumont",
                personLieuDit = "",
                personMobilePhoneNumber = "",
                personNIR = "",
                personPhoneNumber = "",
                personPostBox = "",
                personRoadName = "rue lalala",
                personRoadType = "",
                personRoadNumber = "",
                personRPPS = ""
            };

            CreatePersonResponseDto resp = DomeCall.createPerson(person);
            Assert.IsTrue(resp.statusId == 0);

            createProfileDto profile = new createProfileDto()
            {
                accountId = resp.accountId,
                accountIdSpecified = true,
                profileCibleType = 10,
                profileCibleTypeSpecified = true
            };

            /*var res = DomeCall.createProfile(profile);

            Assert.IsTrue(res.statusId == 0);*/
        }
    }
}

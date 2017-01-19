using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R511;
using Dome.R521;
using Dome.Enum;

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

            CreatePersonInnerDto person = new CreatePersonInnerDto()
            {
                personBirthDate = new DateTime(1988, 2, 8),
                personBirthDateSpecified = true,
                personBirthName = "person",
                personCityName = "Lyon",
                personCityZipCode = "69001",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personFirstName = "person",
                personLastName = "person",
                personMobilePhoneNumber = "0601020304",
                personPhoneNumber = "0401020304",
                personRoadName = "rue lalala",
                personRoadNumber = "1337",
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

            CreatePersonInnerDto person = new CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassagne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69002",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "patient test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "patient",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "patient",
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
                profileCibleType = (int)Profile.Beneficiaire,
                profileCibleTypeSpecified = true
            };

            var res = DomeCall.createProfile(profile);

            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void CreationEntourageShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

            CreatePersonInnerDto person = new CreatePersonInnerDto()
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
                personComment = "proche test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "proche",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "proche",
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
                profileCibleType = (int)Profile.Proche,
                profileCibleTypeSpecified = true
            };

            var res = DomeCall.createProfile(profile);

            Assert.IsTrue(res.statusId == 0);
        }
    }
}

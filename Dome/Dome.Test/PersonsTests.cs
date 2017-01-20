using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R511;
using Dome.R521;
using Dome.R542a;
using Dome.Enum;

namespace Dome.Test
{
    [TestClass]
    public class PersonsTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];

            AuthentificationHelper.Instance.connect(settings.username, settings.password);
        }

        [TestMethod]
        public void CreationPersonShouldSucceed()
        {
            R511.CreatePersonInnerDto person = new R511.CreatePersonInnerDto()
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
        public void UpdatePersonShouldSucceed()
        {
            UpdatePersonDto person = new UpdatePersonDto()
            {
                accountId = 15,
                accountIdSpecified = true,
                DOME_createPerson = new R542a.CreatePersonInnerDto()
                {
                    personBirthDate = new DateTime(1988, 2, 8),
                    personBirthDateSpecified = true,
                    personBirthName = "person",
                    personCityName = "PARIS",
                    personCityZipCode = "75000",
                    personCivilityId = (int)civilite.Madame,
                    personCivilityIdSpecified = true,
                    personFirstName = "person",
                    personLastName = "person",
                    personMobilePhoneNumber = "0601020304",
                    personPhoneNumber = "0401020304",
                    personRoadName = "rue lalala",
                    personRoadNumber = "1337",
                }
            };

            UpdatePersonResponseDto resp = DomeCall.updatePerson(person);
            Assert.IsTrue(resp.statusId == 0);
        }

        [TestMethod]
        public void CreationPatientShouldSucceed()
        {
            R511.CreatePersonInnerDto person = new R511.CreatePersonInnerDto()
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
            R511.CreatePersonInnerDto person = new R511.CreatePersonInnerDto()
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

        [TestMethod]
        public void CreationSalarieShouldSucceed()
        {
            R511.CreatePersonInnerDto person = new R511.CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassagne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69004",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "salarie test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "salarie",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "salarie",
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
                profileCibleType = (int)Profile.PersonnelMedical,
                profileCibleTypeSpecified = true
            };

            var res = DomeCall.createProfile(profile);

            Assert.IsTrue(res.statusId == 0);
        }

        [TestMethod]
        public void CreationStructureShouldSucceed()
        {
            R511.CreatePersonInnerDto person = new R511.CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassagne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69005",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "structure test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "structure",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "structure",
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
                profileCibleType = (int)Profile.StructureMedicale,
                profileCibleTypeSpecified = true
            };

            var res = DomeCall.createProfile(profile);

            Assert.IsTrue(res.statusId == 0);
        }
    }
}

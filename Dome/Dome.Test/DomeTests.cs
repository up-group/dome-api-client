using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R511;
using Dome.R521;
using Dome.R830a;
using Dome.R542a;
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

        #region Auth
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
        #endregion

        #region Person
        [TestMethod]
        public void CreationPersonShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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
        #endregion

        [TestMethod]
        public void CreationPatientShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

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

        #region AGGIR
        [TestMethod]
        public void CreationGrilleAGGIRShouldSucceed()
        {
            AuthentificationHelper.Instance.connect(settings.username, settings.password);

            Assert.IsTrue(AuthentificationHelper.Instance.isConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.auth.token));

            addNewAGGIRDto aggir = new addNewAGGIRDto()
            {
                benefProfileIdSpecified = true,
                benefProfileId = 15,
                DOME_medAGGIR = new addNewAggirInnerDto()
                {
                    AGGIREvaluationDate = DateTime.Now.Date,
                    AGGIRCreationProfileId = 40,
                    AGGIRCreatorName = "moi",
                    AGGIRCreationDate = DateTime.Now.Date,
                    AGGIRCreatorEntityName = "Structure",
                    AGGIRCode = 1,
                    AGGIRCoherence = 1,
                    AGGIROrientation = 1,
                    AGGIRToilette = 1,
                    AGGIRHabillage = 1,
                    AGGIRAlimentation = 1,
                    AGGIRElimination = 1,
                    AGGIRTransferts = 1,
                    AGGIRDeplacInt = 1,
                    AGGIRDeplacExt = 1,
                    AGGIRAlerter = 1,
                    AGGIRGestion = 1,
                    AGGIRCuisine = 1,
                    AGGIRMenage = 1,
                    AGGIRTransport = 1,
                    AGGIRSuiviTraitement = 1,
                    AGGIRTempsLibre = 1,
                    AGGIRAchats = 1,
                }
            };

            addNewAGGIRResponseDto resp = DomeCall.addNewAGGIR(aggir);

            Assert.IsTrue(resp.statusId == 0);
        }
        #endregion
    }
}

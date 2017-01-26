//using System;
//using Dome.Client;
//using Dome.Client.dto.createPerson;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Dome.DomeProxy;
//using Dome.Enum;
//using Dome.Service_References.R511;
//using Dome.Service_References.R521;
//using Dome.Service_References.R525;
//using Dome.Service_References.R542a;
//using CreatePersonInnerDto = Dome.Service_References.R511.CreatePersonInnerDto;

//namespace Dome.Test
//{
//    [TestClass]
//    public classPersonsTests
//    {
//        private int createdAccountId = 0;
//        private int createdPatientId = 0;
//        private int createdIntervenantId = 0;

//        [ClassInitialize()]
//        public static void ClassInit(TestContext context)
//        {
//            AuthentificationHelper.Instance.Connect(Settings.Username, Settings.Password);
//        }

//        [TestMethod]
//        public void CreationPersonShouldSucceed()
//        {
//            CreatePersonDtoPerson = new CreatePersonDto()
//            {
//                DOME_createPerson = new CreatePersonInnerDto()
//                {
//                  PersonBirthDate = new DateTime(1988, 2, 8),
//                  PersonBirthDateSpecified = true,
//                   PersonBirthName = "person",
//                   PersonCityName = "Lyon",
//                   PersonCityZipCode = "69001",
//                   PersonCivilityId = (int)Civilite.Monsieur,
//                   PersonCivilityIdSpecified = true,
//                   PersonFirstName = "person",
//                   PersonLastName = "person",
//                   PersonMobilePhoneNumber = "0601020304",
//                   PersonPhoneNumber = "0401020304",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadNumber = "1337",
//                }
//            };
//            var DomeCall = new DomeClient();
//            CreatePersonResponseDto resp = DomeCall.createPerson(person);
//            Assert.IsTrue(resp.statusId == 0);

//            createdAccountId = resp.accountId;
//        }

//        [TestMethod]
//        public void UpdatePersonShouldSucceed()
//        {
//            Assert.IsTrue(createdAccountId > 0);

//            UpdatePersonDtoPerson = new UpdatePersonDto()
//            {
//                accountId = 15,
//                accountIdSpecified = true,
//                DOME_createPerson = new Service_References.R542a.CreatePersonInnerDto()
//                {
//                   PersonBirthDate = new DateTime(1988, 2, 8),
//                   PersonBirthDateSpecified = true,
//                   PersonBirthName = "person",
//                   PersonCityName = "PARIS",
//                   PersonCityZipCode = "75000",
//                   PersonCivilityId = (int)Civilite.Madame,
//                   PersonCivilityIdSpecified = true,
//                   PersonFirstName = "person",
//                   PersonLastName = "person",
//                   PersonMobilePhoneNumber = "0601020304",
//                   PersonPhoneNumber = "0401020304",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadNumber = "1337",
//                }
//            };
//            var DomeCall = new DomeClient();
//            UpdatePersonResponseDto resp = DomeCall.updatePerson(person);
//            Assert.IsTrue(resp.statusId == 0);
//        }

//        [TestMethod]
//        public void CreationPatientShouldSucceed()
//        {
//            CreatePersonDtoPerson = new CreatePersonDto()
//            {
//                DOME_createPerson = new CreatePersonInnerDto()
//                {
//                   PersonAddressComp1 = "63 avenue lacassagne",
//                   PersonAddressComp2 = "",
//                   PersonBirthDate = new DateTime(1993, 9, 16),
//                   PersonBirthDateSpecified = true,
//                   PersonBirthName = "",
//                   PersonCedex = "",
//                   PersonCityName = "Lyon",
//                   PersonCityZipCode = "69002",
//                   PersonCivilityId = (int)Civilite.Monsieur,
//                   PersonCivilityIdSpecified = true,
//                   PersonComment = "patient test",
//                   PersonEmail1 = "test@test.fr",
//                   PersonEmail2 = "",
//                   PersonFirstName = "patient",
//                   PersonINSC = "",
//                   PersonINSA = "",
//                   PersonJob = "",
//                   PersonLastName = "patient",
//                   PersonLieuDit = "",
//                   PersonMobilePhoneNumber = "",
//                   PersonNIR = "",
//                   PersonPhoneNumber = "",
//                   PersonPostBox = "",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadType = "",
//                   PersonRoadNumber = "",
//                   PersonRPPS = ""
//                }
//            };
//            var DomeCall = new DomeClient();
//            CreatePersonResponseDto resp = DomeCall.createPerson(person);
//            Assert.IsTrue(resp.statusId == 0);

//            createdPatientId = resp.accountId;

//            createProfileDto profile = new createProfileDto()
//            {
//                accountId = resp.accountId,
//                accountIdSpecified = true,
//                profileCibleType = (int)Profile.Beneficiaire,
//                profileCibleTypeSpecified = true
//            };

//            var res = DomeCall.createProfile(profile);

//            Assert.IsTrue(res.statusId == 0);
//        }

//        [TestMethod]
//        public void CreationEntourageShouldSucceed()
//        {
//            CreateEntouragePerson = new CreateEntourage()
//            {
                
//                   PersonAddressComp1 = "63 avenue lacassagne",
//                   PersonAddressComp2 = "",
//                   PersonBirthDate = new DateTime(1993, 9, 16),
//                    //personBirthDateSpecified = true,
//                   PersonBirthName = "",
//                   PersonCedex = "",
//                   PersonCityName = "Lyon",
//                   PersonCityZipCode = "69003",
//                   PersonCivilityId = (int)Civilite.Monsieur,
//                   PersonCivilityIdSpecified = true,
//                   PersonComment = "proche test",
//                   PersonEmail1 = "test@test.fr",
//                   PersonEmail2 = "",
//                   PersonFirstName = "proche",
//                   PersonINSC = "",
//                   PersonINSA = "",
//                   PersonJob = "",
//                   PersonLastName = "proche",
//                   PersonLieuDit = "",
//                   PersonMobilePhoneNumber = "",
//                   PersonNIR = "",
//                   PersonPhoneNumber = "",
//                   PersonPostBox = "",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadType = "",
//                   PersonRoadNumber = "",
//                   PersonRPPS = ""
                
//            };
//            var DomeCall = new DomeClient();
//            CreatePersonResponseDto resp = DomeCall.createPerson(person);
//            Assert.IsTrue(resp.statusId == 0);

//            createProfileDto profile = new createProfileDto()
//            {
//                accountId = resp.accountId,
//                accountIdSpecified = true,
//                profileCibleType = (int)Profile.Proche,
//                profileCibleTypeSpecified = true
//            };

//            var res = DomeCall.createProfile(profile);

//            Assert.IsTrue(res.statusId == 0);
//        }

//        [TestMethod]
//        public void CreationSalarieShouldSucceed()
//        {
//            CreatePersonDtoPerson = new CreatePersonDto()
//            {
//                DOME_createPerson = new CreatePersonInnerDto()
//                {
//                   PersonAddressComp1 = "63 avenue lacassagne",
//                   PersonAddressComp2 = "",
//                   PersonBirthDate = new DateTime(1993, 9, 16),
//                   PersonBirthDateSpecified = true,
//                   PersonBirthName = "",
//                   PersonCedex = "",
//                   PersonCityName = "Lyon",
//                   PersonCityZipCode = "69004",
//                   PersonCivilityId = (int)Civilite.Monsieur,
//                   PersonCivilityIdSpecified = true,
//                   PersonComment = "salarie test",
//                   PersonEmail1 = "test@test.fr",
//                   PersonEmail2 = "",
//                   PersonFirstName = "salarie",
//                   PersonINSC = "",
//                   PersonINSA = "",
//                   PersonJob = "",
//                   PersonLastName = "salarie",
//                   PersonLieuDit = "",
//                   PersonMobilePhoneNumber = "",
//                   PersonNIR = "",
//                   PersonPhoneNumber = "",
//                   PersonPostBox = "",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadType = "",
//                   PersonRoadNumber = "",
//                   PersonRPPS = ""
//                }
//            };
//            var DomeCall = new DomeClient();
//            CreatePersonResponseDto resp = DomeCall.createPerson(person);
//            Assert.IsTrue(resp.statusId == 0);

//            createdIntervenantId = resp.accountId;

//            createProfileDto profile = new createProfileDto()
//            {
//                accountId = resp.accountId,
//                accountIdSpecified = true,
//                profileCibleType = (int)Profile.PersonnelMedical,
//                profileCibleTypeSpecified = true
//            };

//            var res = DomeCall.createProfile(profile);

//            Assert.IsTrue(res.statusId == 0);
//        }

//        [TestMethod]
//        public void AssociationIntervenantPatientShouldSucceed()
//        {
//            Assert.IsTrue(createdPatientId > 0);
//            Assert.IsTrue(createdIntervenantId > 0);

//            linkIntervenantToBenefDto link = new linkIntervenantToBenefDto()
//            {
//                intervenantProfileIdSpecified = true,
//                intervenantProfileId = createdIntervenantId,
//                benefProfileIdSpecified = true,
//                benefProfileId = createdPatientId
//            };
//            var DomeCall = new DomeClient();
//            linkIntervenantToBenefResponseDto resp = DomeCall.linkIntervenantToBenef(link);
//            Assert.IsTrue(resp.statusId == 0);
//        }

//        [TestMethod]
//        public void CreationStructureShouldSucceed()
//        {
//            CreatePersonDtoPerson = new CreateStructure()
//            {
               
//                   PersonAddressComp1 = "63 avenue lacassagne",
//                   PersonAddressComp2 = "",
//                   PersonBirthDate = new DateTime(1993, 9, 16),
//                   /*PersonBirthDateSpecified*/ = true,
//                   PersonBirthName = "",
//                   PersonCedex = "",
//                   PersonCityName = "Lyon",
//                   PersonCityZipCode = "69005",
//                   PersonCivility = Civilite.Monsieur,
//                   ProfileCibleTypeFieldSpecified = true,
//                   PersonComment = "structure test",
//                   PersonEmail1 = "test@test.fr",
//                   PersonEmail2 = "",
//                   PersonFirstName = "structure",
//                   PersonInsc = "",
//                   PersonInsa = "",
//                   PersonJob = "",
//                   PersonLastName = "structure",
//                   PersonLieuDit = "",
//                   PersonMobilePhoneNumber = "",
//                   PersonNir = "",
//                   PersonPhoneNumber = "",
//                   PersonPostBox = "",
//                   PersonRoadName = "rue lalala",
//                   PersonRoadType = "",
//                   PersonRoadNumber = "",
//                   PersonRpps = ""
//            };
//            var DomeCall = new DomeClient();
//            CreatePersonResponseDto resp = DomeCall.createPerson(person);
//            Assert.IsTrue(resp.statusId == 0);

//            createProfileDto profile = new createProfileDto()
//            {
//                accountId = resp.accountId,
//                accountIdSpecified = true,
//                profileCibleType = (int)Profile.StructureMedicale,
//                profileCibleTypeSpecified = true
//            };
//            var res = DomeCall.createProfile(profile);

//            Assert.IsTrue(res.statusId == 0);
//        }
//    }
//}

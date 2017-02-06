using System;
using System.Linq;
using Dome.Client;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.updatePerson;
using Dome.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dome.Test
{
    [TestClass]
    public class PatientTest
    {
        [TestMethod]
        public void CreationPatientWithMail()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileStructureId = domeClient.StructureProfilId
            };


            var data = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsTrue(data.Succeeded);

        }

        [TestMethod]
        public void CreationPatientWithPhone()
        {
            var domeClient = new DomeClient();
            var fakeId = Guid.NewGuid().ToString();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonPhoneNumber = "0671757846",
                ProfileStructureId = domeClient.StructureProfilId
            };

            var data = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsTrue(data.Succeeded);

        }

        [TestMethod]
        public void CreationPatientWitoutPhoneMail()
        {
            var domeClient = new DomeClient();
            var fakeId = Guid.NewGuid().ToString();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                ProfileStructureId = domeClient.StructureProfilId
            };

            var data = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsFalse(data.Succeeded);

        }

        [TestMethod]
        public void CreationPatientShouldFail()
        {
            var domeClient = new DomeClient();
            var fakeId = Guid.NewGuid().ToString();

            var createPatient = new CreateBeneficiaire()
            {
                AccountId = -1,
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                ProfileStructureId = domeClient.StructureProfilId
            };

            var data = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsFalse(data.Succeeded);

        }


        [TestMethod]
        public void CreationPatientWithoutStructure()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCivility = Civilite.Monsieur,
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
            };
            var patient = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsFalse(patient.Succeeded);

        }
        

        [TestMethod]
        public void UpdatePatient()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com"
            };


            var patient = domeClient.CreateBeneficiaire(createPatient);


            var beforeUpdate = domeClient.GetAccount(patient.Entity.AccountId).Entity.DOME_profileList.Single(profil => profil.profileId == patient.Entity.ProfileId);

            Assert.AreEqual(beforeUpdate.DOME_personData.personCityName, "Bron");
            Assert.AreEqual(beforeUpdate.DOME_personData.personCityZipCode, "69500");


            fakeId = Guid.NewGuid().ToString();

            var updatePerson = new UpdatePerson()
            {
                PersonCityName = "Lyon",
                PersonCityZipCode = "69003",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
            };

            var entourage = domeClient.UpdatePerson(patient.Entity.AccountId, updatePerson);

            Assert.IsTrue(entourage.Succeeded);

            var afterUpdate = domeClient.GetAccount(patient.Entity.AccountId).Entity.DOME_profileList.Single(profil => profil.profileId == patient.Entity.ProfileId);

            Assert.AreEqual(afterUpdate.DOME_personData.personCityName, "Lyon");
            Assert.AreEqual(afterUpdate.DOME_personData.personCityZipCode, "69003");


        }


        [TestMethod]
        public void UpdatePatientFail()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreateBeneficiaire()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com"
            };


            var patient = domeClient.CreateBeneficiaire(createPatient);


            var beforeUpdate = domeClient.GetAccount(patient.Entity.AccountId).Entity.DOME_profileList.Single(profil => profil.profileId == patient.Entity.ProfileId);

            Assert.AreEqual(beforeUpdate.DOME_personData.personCityName, "Bron");
            Assert.AreEqual(beforeUpdate.DOME_personData.personCityZipCode, "69500");


            fakeId = Guid.NewGuid().ToString();

            var updatePerson = new UpdatePerson()
            {
                PersonCityName = "Lyon",
                PersonCityZipCode = "69003",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
            };

            var entourage = domeClient.UpdatePerson(-1, updatePerson);

            Assert.IsFalse(entourage.Succeeded);

            var afterUpdate = domeClient.GetAccount(patient.Entity.AccountId).Entity.DOME_profileList.Single(profil => profil.profileId == patient.Entity.ProfileId);

            Assert.AreEqual(afterUpdate.DOME_personData.personCityName, "Bron");
            Assert.AreEqual(afterUpdate.DOME_personData.personCityZipCode, "69500");


        }

    }
}

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
    public class EntourageTest
    {
        [TestMethod]
        public void CreationEntourage()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreatePatient()
            {
                PersonCivility = Civilite.Monsieur,
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileStructureId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId
            };

            var patient = domeClient.CreatePatient(createPatient);


            fakeId = Guid.NewGuid().ToString();


            var createEntourage = new CreateEntourage()
            {
                PersonCivility = Civilite.Monsieur,
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = patient.Entity.ProfileId
            };

            var entourage = domeClient.CreateEntourage(createEntourage);

            Assert.IsTrue(entourage.Succeeded);

        }



    }
}
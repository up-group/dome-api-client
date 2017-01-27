using System;
using Dome.Client;
using Dome.Client.dto.createPerson;
using Dome.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dome.Test
{
    [TestClass]
    public class IntervenantTest
    {
     
        [TestMethod]
        public void CreationIntervenant()
        {
            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createIntervenant = new CreateIntervenant(Profile.PersonnelMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId
            };

            var intervenant = domeClient.CreateIntervenant(createIntervenant);

            Assert.IsTrue(intervenant.Succeeded);
        }


        

        [TestMethod]
        public void CreationLinkIntervenantPatient()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createPatient = new CreatePatient()
            {
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

            var createIntervenant = new CreateIntervenant(Profile.PersonnelMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId
            };

            var intervenant = domeClient.CreateIntervenant(createIntervenant);

            Assert.IsTrue(intervenant.Succeeded);

            var link = domeClient.LinkIntervenantToBenef(patient.Entity.ProfileId, intervenant.Entity.ProfileId);

            Assert.IsTrue(link.Succeeded);


        }



    }
}
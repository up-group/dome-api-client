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
            var domeClient = TestHelper.GetNewClient();

            var createIntervenant = new CreateIntervenantExterne(Profile.PersonnelMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = domeClient.StructureProfilId
            };

            var intervenant = domeClient.CreateIntervenantExterne(createIntervenant);

            Assert.IsTrue(intervenant.Succeeded);
        }


        

        [TestMethod]
        public void CreationLinkIntervenantPatient()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = TestHelper.GetNewClient();

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

            var patient = domeClient.CreateBeneficiaire(createPatient);

            fakeId = Guid.NewGuid().ToString();

            var createIntervenant = new CreateIntervenantExterne(Profile.PersonnelMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = domeClient.StructureProfilId
            };

            var intervenant = domeClient.CreateIntervenantExterne(createIntervenant);

            Assert.IsTrue(intervenant.Succeeded);

            var link = domeClient.LinkIntervenantToBenef(patient.Entity.ProfileId, intervenant.Entity.ProfileId);

            Assert.IsTrue(link.Succeeded);


        }



    }
}
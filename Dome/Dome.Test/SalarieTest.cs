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
    public class SalarieTest
    {

    

        [TestMethod]
        public void CreationSalarie()
        {

            var fakeId = Guid.NewGuid().ToString();
            var domeClient = new DomeClient();

            var createSalarie = new CreateSalarie(Profile.PersonnelNonMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
                ProfileParentId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId
            };

            var intervenant = domeClient.CreateSalarie(createSalarie);

            Assert.IsTrue(intervenant.Succeeded);

        }





    }
}
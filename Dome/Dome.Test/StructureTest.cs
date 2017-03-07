using System;
using Dome.Client;
using Dome.Client.dto.createPerson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dome.Test
{
    [TestClass]
    public class StructureTest
    {

        [TestMethod]
        public void CreationStructure()
        {

            var domeClient = TestHelper.GetNewClient();

            var fakeId = Guid.NewGuid().ToString();

            CreateStructure domeStructure = new CreateStructure()
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonEmail1 = "testdome@yopmail.com",
               ProfileParentId = domeClient.StructureProfilId

            };


            var result = domeClient.CreateStructure(domeStructure);



        }


        [TestMethod]
        public void CreationOperateurStructure()
        {

            //var fakeId = Guid.NewGuid().ToString();
            //var domeClient = TestHelper.GetNewClient();
        }
    }
}
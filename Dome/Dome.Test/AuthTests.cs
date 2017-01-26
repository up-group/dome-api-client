using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dome.Client;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.createPerson.basic;
using Dome.DomeProxy;

namespace Dome.Test
{

    [TestClass]
    public class CreationTest
    {


        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }





        [TestMethod]
        public void CreatePerson()
        {
            //var PersonTestBase = new CreatePerson()
            //{
            //    PersonCityName = "Lyon",
            //    PersonCityZipCode = "69003",
            //    PersonFirstName = "Sam",
            //    PersonLastName = "winchester",
            //    PersonRoadName = "rue pi",
            //    PersonEmail1 = "bob@test.fr",
            //};

            //var dome = new DomeClient.DomeClient();

            //var R = dome.(PersonTestBase);

            //Assert.IsTrue(R.Succeeded);

            ////recup duplicate
            //var accountId = R.Entity.DOME_createPersonList[0].accountId;
            //var account = dome.GetAccount(accountId);

            //Assert.IsTrue(account.Succeeded);

        }


        [TestMethod]
        public void CreatePatient()
        {
            //var PersonTestBase = new CreatePerson()
            //{
            //    PersonCityName = "Lyon",
            //    PersonCityZipCode = "69003",
            //    PersonFirstName = "Sam",
            //    PersonLastName = "winchester",
            //    PersonRoadName = "rue pi",
            //    PersonEmail1 = "bob@test.fr",
            //};

            //var dome = new DomeCall();

            //var createPatientResult = dome.CreatePatient(PersonTestBase, new CreatePatient());

            //Assert.IsTrue(createPatientResult.Succeeded);




        }

    }
























































    [TestClass]
    public class AuthTests
    {
        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [TestMethod]
        public void AuthentificationShouldSucceed()
        {
            AuthentificationHelper.Instance.Connect(Settings.Username, Settings.Password);

            Assert.IsTrue(AuthentificationHelper.Instance.IsConnected);
            Assert.IsFalse(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.Auth.Token));
        }

        [TestMethod]
        public void AuthentificationShouldFail()
        {
            string username = "toto";
            string password = "tata";

            AuthentificationHelper.Instance.Connect(username, password);

            Assert.IsFalse(AuthentificationHelper.Instance.IsConnected);
            Assert.IsTrue(String.IsNullOrWhiteSpace(AuthentificationHelper.Instance.Auth.Token));
        }
    }
}

using System;
using Dome.Client;
using Dome.Client.dto.aggir;
using Dome.Client.dto.createPerson;
using Dome.Enum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dome.Test
{
    [TestClass]
    public class AggirTests
    {


        [TestMethod]
        public void CreationAggir()
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

            Assert.IsTrue(patient.Succeeded);

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

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.StructureProfilId,

                AggirCoherence = 2,
                AggirOrientation = 3,
                AggirToilette = 2,
                AggirHabillage = 1,
                AggirAlimentation = 1,
                AggirElimination = 1,
                AggirTransferts = 1,
                AggirDeplacInt = 1,
                AggirDeplacExt = 1,
                AggirAlerter = 1,
                AggirGestion = 1,
                AggirCuisine = 1,
                AggirMenage = 1,
                AggirTransport = 1,
                AggirSuiviTraitement = 1,
                AggirTempsLibre = 1,
                AggirAchats = 1,
            };

            var agir = domeClient.CreateAggir(patient.Entity.ProfileId, createAggir);

            Assert.IsTrue(agir.Succeeded);
        }


        [TestMethod]
        public void CreationAggirShouldFail()
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

            Assert.IsTrue(patient.Succeeded);

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

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,
                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.StructureProfilId,
                AggirCoherence = 3,
            };

            var agir = domeClient.CreateAggir(patient.Entity.ProfileId, createAggir);

            Assert.IsFalse(agir.Succeeded);
        }


        [TestMethod]
        public void CreationAggirWrongValue()
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

            Assert.IsTrue(patient.Succeeded);

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

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.StructureProfilId,

                AggirCoherence = 0,
                AggirOrientation = 0,
                AggirToilette = 0,
                AggirHabillage = 0,
                AggirAlimentation = 0,
                AggirElimination = 0,
                AggirTransferts = 0,
                AggirDeplacInt = 0,
                AggirDeplacExt = 0,
                AggirAlerter = 0,
                AggirGestion = 0,
                AggirCuisine = 0,
                AggirMenage = 0,
                AggirTransport = 0,
                AggirSuiviTraitement = 0,
                AggirTempsLibre = 0,
                AggirAchats = 0,
            };

            var agir = domeClient.CreateAggir(patient.Entity.ProfileId, createAggir);

            Assert.IsFalse(agir.Succeeded);
        }


        [TestMethod]
        public void UpdateAggir()
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
                //PersonEmail1 = "testdome@yopmail.com",
                PersonPhoneNumber = "0102030405",
                ProfileStructureId = domeClient.StructureProfilId
            };


            var patient = domeClient.CreateBeneficiaire(createPatient);

            Assert.IsTrue(patient.Succeeded);

            fakeId = Guid.NewGuid().ToString();

            var createIntervenant = new CreateIntervenantExterne(Profile.PersonnelMedical)
            {
                PersonCityName = "Bron",
                PersonCityZipCode = "69500",
                PersonFirstName = "FirstName" + fakeId,
                PersonLastName = "LastName" + fakeId,
                PersonRoadName = "rue edison",
                PersonPhoneNumber = "0102030405",
                ProfileParentId = domeClient.StructureProfilId
            };

            var intervenant = domeClient.CreateIntervenantExterne(createIntervenant);

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.StructureProfilId,

                AggirCoherence = 1,
                AggirOrientation = 1,
                AggirToilette = 1,
                AggirHabillage = 1,
                AggirAlimentation = 1,
                AggirElimination = 1,
                AggirTransferts = 1,
                AggirDeplacInt = 1,
                AggirDeplacExt = 1,
                AggirAlerter = 1,
                AggirGestion = 1,
                AggirCuisine = 1,
                AggirMenage = 1,
                AggirTransport = 1,
                AggirSuiviTraitement = 1,
                AggirTempsLibre = 1,
                AggirAchats = 1,
            };

            var agir = domeClient.CreateAggir(patient.Entity.ProfileId, createAggir);

            Assert.IsTrue(agir.Succeeded);


            var agir1 = domeClient.GetListAggir(patient.Entity.ProfileId).Entity.dOME_medAGGIRField[0];

            Assert.AreEqual(agir1.AGGIRCoherence, 1);
            Assert.AreEqual(agir1.AGGIROrientation, 1);
            Assert.AreEqual(agir1.AGGIRToilette, 1);
            Assert.AreEqual(agir1.AGGIRHabillage, 1);
            Assert.AreEqual(agir1.AGGIRAlimentation, 1);
            Assert.AreEqual(agir1.AGGIRElimination, 1);
            Assert.AreEqual(agir1.AGGIRTransferts, 1);
            Assert.AreEqual(agir1.AGGIRDeplacInt, 1);
            Assert.AreEqual(agir1.AGGIRDeplacExt, 1);
            Assert.AreEqual(agir1.AGGIRAlerter, 1);
            Assert.AreEqual(agir1.AGGIRGestion, 1);
            Assert.AreEqual(agir1.AGGIRCuisine, 1);
            Assert.AreEqual(agir1.AGGIRMenage, 1);
            Assert.AreEqual(agir1.AGGIRTransport, 1);
            Assert.AreEqual(agir1.AGGIRSuiviTraitement, 1);
            Assert.AreEqual(agir1.AGGIRTempsLibre, 1);
            Assert.AreEqual(agir1.AGGIRAchats, 1);











            var updateAggir = new UpdateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.StructureProfilId,
                
                AggirCoherence = 2,
                AggirOrientation = 2,
                AggirToilette = 2,
                AggirHabillage = 2,
                AggirAlimentation = 2,
                AggirElimination =2,
                AggirTransferts = 2,
                AggirDeplacInt = 2,
                AggirDeplacExt =2,
                AggirAlerter = 2,
                AggirGestion = 2,
                AggirCuisine = 2,
                AggirMenage = 2,
                AggirTransport = 2,
                AggirSuiviTraitement = 2,
                AggirTempsLibre = 2,
                AggirAchats = 2,
            };

            var agirUpdate = domeClient.UpdateAggir(agir.Entity, updateAggir);


            Assert.IsTrue(agirUpdate.Succeeded);



            var agir2 = domeClient.GetListAggir(patient.Entity.ProfileId).Entity.dOME_medAGGIRField[0];

            Assert.AreEqual(agir2.AGGIRCoherence,2);
            Assert.AreEqual(agir2.AGGIROrientation, 2);
            Assert.AreEqual(agir2.AGGIRToilette,2);
            Assert.AreEqual(agir2.AGGIRHabillage,2);
            Assert.AreEqual(agir2.AGGIRAlimentation,2);
            Assert.AreEqual(agir2.AGGIRElimination,2);
            Assert.AreEqual(agir2.AGGIRTransferts,2);
            Assert.AreEqual(agir2.AGGIRDeplacInt,2);
            Assert.AreEqual(agir2.AGGIRDeplacExt,2);
            Assert.AreEqual(agir2.AGGIRAlerter,2);
            Assert.AreEqual(agir2.AGGIRGestion, 2);
            Assert.AreEqual(agir2.AGGIRCuisine, 2);
            Assert.AreEqual(agir2.AGGIRMenage, 2);
            Assert.AreEqual(agir2.AGGIRTransport, 2);
            Assert.AreEqual(agir2.AGGIRSuiviTraitement, 2);
            Assert.AreEqual(agir2.AGGIRTempsLibre, 2);
            Assert.AreEqual(agir2.AGGIRAchats, 2);




        }


    }
}

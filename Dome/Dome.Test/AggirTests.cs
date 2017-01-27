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

            Assert.IsTrue(patient.Succeeded);

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

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId =  domeClient.OpenData.OperateurStructureConnected.StructureProfilId,
                


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
        public void UpdateAggir()
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

            Assert.IsTrue(patient.Succeeded);

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

            var createAggir = new CreateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId,

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

            var updateAggir = new UpdateAggirDto()
            {
                AggirCreatorName = "AggirCreatorName",
                AggirCreationDate = DateTime.Now,
                AggirEvaluationDate = DateTime.Now,
                AggirCode = 6,
                AggirCreationProfileId = intervenant.Entity.ProfileId,

                AggirCreatorEntityName = "AggirCreatorEntityName",
                StructureProfileId = domeClient.OpenData.OperateurStructureConnected.StructureProfilId,
                
                AggirCoherence = 2,
                AggirOrientation = 3,
                AggirToilette = 2,
                AggirHabillage = 3,
                AggirAlimentation = 3,
                AggirElimination =3,
                AggirTransferts = 3,
                AggirDeplacInt = 3,
                AggirDeplacExt =3,
                AggirAlerter = 1,
                AggirGestion = 1,
                AggirCuisine = 1,
                AggirMenage = 1,
                AggirTransport = 1,
                AggirSuiviTraitement = 1,
                AggirTempsLibre = 1,
                AggirAchats = 1,
            };

            var agirUpdate = domeClient.UpdateAggir(agir.Entity, updateAggir);


            Assert.IsTrue(agirUpdate.Succeeded);




        }


    }
}

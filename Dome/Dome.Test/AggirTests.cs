using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R830a;
using Dome.R833a;

namespace Dome.Test
{
    [TestClass]
    public class AggirTests
    {
        private int createdAggirGridId = 0;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];

            AuthentificationHelper.Instance.connect(settings.username, settings.password);
        }

        [TestMethod]
        public void CreationGrilleAGGIRShouldSucceed()
        {
            addNewAGGIRDto aggir = new addNewAGGIRDto()
            {
                benefProfileIdSpecified = true,
                benefProfileId = 15,
                DOME_medAGGIR = new R830a.addNewAggirInnerDto()
                {
                    AGGIREvaluationDate = DateTime.Now.Date,
                    AGGIRCreationProfileId = 40,
                    AGGIRCreatorName = "moi",
                    AGGIRCreationDate = DateTime.Now.Date,
                    AGGIRCreatorEntityName = "Structure",
                    AGGIRCode = 1,
                    AGGIRCoherence = 1,
                    AGGIROrientation = 1,
                    AGGIRToilette = 1,
                    AGGIRHabillage = 1,
                    AGGIRAlimentation = 1,
                    AGGIRElimination = 1,
                    AGGIRTransferts = 1,
                    AGGIRDeplacInt = 1,
                    AGGIRDeplacExt = 1,
                    AGGIRAlerter = 1,
                    AGGIRGestion = 1,
                    AGGIRCuisine = 1,
                    AGGIRMenage = 1,
                    AGGIRTransport = 1,
                    AGGIRSuiviTraitement = 1,
                    AGGIRTempsLibre = 1,
                    AGGIRAchats = 1,
                }
            };

            addNewAGGIRResponseDto resp = DomeCall.addNewAGGIR(aggir);

            Assert.IsTrue(resp.statusId == 0);

            createdAggirGridId = resp.AGGIRGridId;
        }

        [TestMethod]
        public void ModificationGrilleAGGIRShouldSucceed()
        {
            Assert.IsTrue(createdAggirGridId > 0);

            alterAGGIRDto aggir = new alterAGGIRDto()
            {
                AGGIRGridId = createdAggirGridId,
                AGGIRGridIdSpecified = true,
                DOME_medAGGIRdetail = new alterAGGIRInnerDto()
                {
                    AGGIREvaluationDate = DateTime.Now.Date,
                    AGGIRCreationProfileId = 40,
                    AGGIRCreatorName = "moi",
                    AGGIRCreationDate = DateTime.Now.Date,
                    AGGIRCreatorEntityName = "Structure",
                    AGGIRCode = 1,
                    AGGIRCoherence = 1,
                    AGGIROrientation = 1,
                    AGGIRToilette = 1,
                    AGGIRHabillage = 1,
                    AGGIRAlimentation = 1,
                    AGGIRElimination = 1,
                    AGGIRTransferts = 1,
                    AGGIRDeplacInt = 1,
                    AGGIRDeplacExt = 1,
                    AGGIRAlerter = 1,
                    AGGIRGestion = 1,
                    AGGIRCuisine = 1,
                    AGGIRMenage = 1,
                    AGGIRTransport = 1,
                    AGGIRSuiviTraitement = 1,
                    AGGIRTempsLibre = 1,
                    AGGIRAchats = 1,
                }
            };

            R833a.domeResponseDto resp = DomeCall.alterAggir(aggir);

            Assert.IsTrue(resp.statusId == 0);
        }
    }
}

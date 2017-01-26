//using System;
//using Dome.Client;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Dome.DomeProxy;
//using Dome.Service_References.R830a;
//using Dome.Service_References.R833a;
//using addNewAggirInnerDto = Dome.Service_References.R830a.addNewAggirInnerDto;
//using domeResponseDto = Dome.Service_References.R833a.domeResponseDto;

//namespace Dome.Test
//{
//    [TestClass]
//    public class AggirTests
//    {
//        private int createdAggirGridId = 0;

//        [ClassInitialize()]
//        public static void ClassInit(TestContext context)
//        {
//            AuthentificationHelper.Instance.Connect(Settings.Username, Settings.Password);
//        }

//        [TestMethod]
//        public void CreationGrilleAGGIRShouldSucceed()
//        {
//            addNewAGGIRDto aggir = new addNewAGGIRDto()
//            {
//                benefProfileIdSpecified = true,
//                benefProfileId = 15,
//                DOME_medAGGIR = new addNewAggirInnerDto()
//                {
//                    AGGIREvaluationDate = DateTime.Now.Date,
//                    AGGIRCreationProfileId = 40,
//                    AGGIRCreatorName = "moi",
//                    AGGIRCreationDate = DateTime.Now.Date,
//                    AGGIRCreatorEntityName = "Structure",
//                    AGGIRCode = 1,
//                    AGGIRCoherence = 1,
//                    AGGIROrientation = 1,
//                    AGGIRToilette = 1,
//                    AGGIRHabillage = 1,
//                    AGGIRAlimentation = 1,
//                    AGGIRElimination = 1,
//                    AGGIRTransferts = 1,
//                    AGGIRDeplacInt = 1,
//                    AGGIRDeplacExt = 1,
//                    AGGIRAlerter = 1,
//                    AGGIRGestion = 1,
//                    AGGIRCuisine = 1,
//                    AGGIRMenage = 1,
//                    AGGIRTransport = 1,
//                    AGGIRSuiviTraitement = 1,
//                    AGGIRTempsLibre = 1,
//                    AGGIRAchats = 1,
//                }
//            };
//            var DomeCall = new DomeClient();
//            var resp = DomeCall.CreateAggir(aggir);

//            Assert.IsTrue(resp.statusId == 0);

//            createdAggirGridId = resp.AGGIRGridId;
//        }

//        [TestMethod]
//        public void ModificationGrilleAGGIRShouldSucceed()
//        {
//            Assert.IsTrue(createdAggirGridId > 0);

//            alterAGGIRDto aggir = new alterAGGIRDto()
//            {
//                AGGIRGridId = createdAggirGridId,
//                AGGIRGridIdSpecified = true,
//                DOME_medAGGIRdetail = new alterAGGIRInnerDto()
//                {
//                    AGGIREvaluationDate = DateTime.Now.Date,
//                    AGGIRCreationProfileId = 40,
//                    AGGIRCreatorName = "moi",
//                    AGGIRCreationDate = DateTime.Now.Date,
//                    AGGIRCreatorEntityName = "Structure",
//                    AGGIRCode = 1,
//                    AGGIRCoherence = 1,
//                    AGGIROrientation = 1,
//                    AGGIRToilette = 1,
//                    AGGIRHabillage = 1,
//                    AGGIRAlimentation = 1,
//                    AGGIRElimination = 1,
//                    AGGIRTransferts = 1,
//                    AGGIRDeplacInt = 1,
//                    AGGIRDeplacExt = 1,
//                    AGGIRAlerter = 1,
//                    AGGIRGestion = 1,
//                    AGGIRCuisine = 1,
//                    AGGIRMenage = 1,
//                    AGGIRTransport = 1,
//                    AGGIRSuiviTraitement = 1,
//                    AGGIRTempsLibre = 1,
//                    AGGIRAchats = 1,
//                }
//            };
//            var DomeCall = new DomeClientSoap();
//            domeResponseDto resp = DomeCall.alterAggir(aggir);

//            Assert.IsTrue(resp.statusId == 0);
//        }
//    }
//}

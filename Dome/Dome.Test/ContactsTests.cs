//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Dome.DomeProxy;
//using Dome.Enum;
//using Dome.Service_References.R101;

//namespace Dome.Test
//{
//    [TestClass]
//    public class ContactsTests
//    {
//        private int createdContactId = 0;

//        [ClassInitialize()]
//        public static void ClassInit(TestContext context)
//        {
//            AuthentificationHelper.Instance.Connect(Settings.Username, Settings.Password);
//        }

//        [TestMethod]
//        public void CreationContactShouldSucceed()
//        {
//            createContactDto contact = new createContactDto()
//            {
//                DOME_contactCreate = new createContactInnerDto()
//                {
//                    contactCityName = "LYON",
//                    contactPersonCityZipCode = "69000",
//                    contactCategoryIdSpecified = true,
//                    contactCategoryId = (int)ContactCategorie.Autre,
//                    contactRelationShipId = (int)ContactRelationship.Autre,
//                    contactRelationShipIdSpecified = true,
//                }
//            };
//            var DomeCall = new DomeClientSoap();
//            createContactResponseDto res = DomeCall.createContact(contact);
//            Assert.IsTrue(res.statusId == 0);

//            createdContactId = res.contactId;
//        }

//        /*[TestMethod]
//        public void ModificationContactShouldSucceed()
//        {
//            Assert.IsTrue(createdContactId > 0);

           
//        }*/
//    }
//}

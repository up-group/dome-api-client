using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;
using Dome.R101;
using Dome.Enum;

namespace Dome.Test
{
    [TestClass]
    public class ContactsTests
    {
        private int createdContactId = 0;

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];

            AuthentificationHelper.Instance.connect(settings.username, settings.password);
        }

        [TestMethod]
        public void CreationContactShouldSucceed()
        {
            createContactDto contact = new createContactDto()
            {
                DOME_contactCreate = new createContactInnerDto()
                {
                    contactCityName = "LYON",
                    contactPersonCityZipCode = "69000",
                    contactCategoryIdSpecified = true,
                    contactCategoryId = (int)ContactCategorie.Autre,
                    contactRelationShipId = (int)ContactRelationship.Autre,
                    contactRelationShipIdSpecified = true,
                }
            };

            createContactResponseDto res = DomeCall.createContact(contact);
            Assert.IsTrue(res.statusId == 0);

            createdContactId = res.contactId;
        }

        /*[TestMethod]
        public void ModificationContactShouldSucceed()
        {
            Assert.IsTrue(createdContactId > 0);

           
        }*/
    }
}

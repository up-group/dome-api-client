using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dome.R511;

using System.Configuration;
using Dome;
using Dome.Enum;

namespace DomeConsole
{
    class Program
    {
        public static void Main()
        {
            settings.password = ConfigurationManager.AppSettings["password"];
            settings.urlbase = ConfigurationManager.AppSettings["urlbase"];
            settings.username = ConfigurationManager.AppSettings["username"];


            AuthentificationHelper.Instance.connect(settings.username,settings.password);









            var data = new CreatePersonInnerDto()
            {
                personAddressComp1 = "63 avenue lacassgne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69003",
                personCivilityId = (int)civilite.Monsieur,
                personCivilityIdSpecified = true,
                personComment = "personne test",
                personEmail1 = "test@test.fr",
                personEmail2 = "",
                personFirstName = "guillaume",
                personINSC = "",
                personINSA = "",
                personJob = "",
                personLastName = "dumont",
                personLieuDit = "",
                personMobilePhoneNumber = "",
                personNIR = "",
                personPhoneNumber = "",
                personPostBox = "",
                personRoadName = "",
                personRoadType = "",
                personRoadNumber = "",
                personRPPS = "",
                specialCriteria = ""
            };




            var a = DomeCall.createPerson(data);


            //var t = DomeCall.GetProfileList(40);

           // var a = DomeCall.profileDetails(15);





        }

    }
}

using Dome;
using System.Diagnostics;

namespace DomeConsole
{
    class Program
    {
        public static void Main()
        {

            //AuthentificationHelper.Instance.connect();




            //var data = new CreatePersonInnerDto()
            //{
            //    personAddressComp1 = "63 avenue lacassgne",
            //    personAddressComp2 = "",
            //    personBirthDate = new DateTime(1993, 9, 16),
            //    personBirthDateSpecified = true,
            //    personBirthName = "",
            //    personCedex = "",
            //    personCityName = "Lyon",
            //    personCityZipCode = "69003",
            //    personCivilityId = (int)civilite.Monsieur,
            //    personCivilityIdSpecified = true,
            //    personComment = "personne test",
            //    personEmail1 = "test@test.fr",
            //    personEmail2 = "",
            //    personFirstName = "guillaume",
            //    personINSC = "",
            //    personINSA = "",
            //    personJob = "",
            //    personLastName = "dumont",
            //    personLieuDit = "",
            //    personMobilePhoneNumber = "",
            //    personNIR = "",
            //    personPhoneNumber = "",
            //    personPostBox = "",
            //    personRoadName = "",
            //    personRoadType = "",
            //    personRoadNumber = "",
            //    personRPPS = "",
            //    specialCriteria = ""
            //};




            // var a = DomeCall.createPerson(data);

            Debugger.Break();

            var d = new DomeCall();

            var t = d.GetProfileList(40);

            var a = d.profileDetails(15);





        }

    }
}

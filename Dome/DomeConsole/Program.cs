using Dome;
using Dome.Enum;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DomeConsole
{
    class Program
    {
        public static void Main()
        {

            //AuthentificationHelper.Instance.connect();

            Debugger.Break();



            var data = new CreatePerson()
            {

                personCivility = Dome.Enum.Civilite.Monsieur,
                personAddressComp1 = "63 avenue lacassgne",
                personAddressComp2 = "",
                personBirthDate = new DateTime(1993, 9, 16),
                //personBirthDateSpecified = true,
                personBirthName = "",
                personCedex = "",
                personCityName = "Lyon",
                personCityZipCode = "69003",
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
                personRoadName = "test",
                personRoadType = "",
                personRoadNumber = "",
                personRPPS = "",
                specialCriteria = "",

            };

            var d = new DomeCallSoap();
            var d2 = new DomeCall();

            //var l1 = new List<object>();
            //for (int i = 35; i < 45; i++)
            //{

            //    var a2 = d2.GetAccount(i);

            //    if (a2.Succeeded)
            //    {
            //        l1.Add(a2.Entity);
            //    }
            //}


            //var l2 = new List<object>();
            //for (int i = 10; i < 20; i++)
            //{

            //    var a2 = d2.GetProfile(i);

            //    if (a2.Succeeded)
            //    {
            //        l2.Add(a2.Entity);
            //    }
            //}



            //var da = d.selectProfile(new Dome.R532.selectProfileDto()
            //{

            //    DOME_header = new Dome.R532.domeHeaderDto()
            //    {
            //        langue = "fr",
            //        deviceTypeSpecified = true,
            //        deviceType = (int)DeviceType.LogicielMétier,
            //        dateSpecified = true,
            //        date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
            //        version = AuthentificationHelper.Instance.auth.DOME_header.version,
            //    }
            //       ,
            //    profileId = 15,
            //    profileIdSpecified = true
            //});
            var a = d2.SelectProfil(15);
            var a2 = d2.CreatePerson(data);



            //  var t = d.GetProfileList(40);
            //var fezt = d.GetProfileList(40);

            //var htra = d.profileDetails(1005);
            //var htr = d.profileDetails(15);





        }

    }
}

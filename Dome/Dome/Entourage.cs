using Dome.Authentification;
using Dome.R101;
using Dome.R201;
using Dome.R213b;
using Dome.R221;
using Dome.R221s;
using Dome.R511;
using Dome.R521;
using Dome.R541b;
using Dome.R541c;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Configuration;

namespace Dome
{

    public static class DomeCall
    {
        ///101 <see cref="aaa"/>
        ///201 <see cref="aaa"/>
        ///213b <see cref="aaa"/>
        ///221 <see cref="aaa"/>
        ///221s <see cref="aaa"/>
        ///231 <see cref="aaa"/>
        ///401 <see cref="aaa"/>
        ///511 <see cref="createPerson"/>
        ///521 <see cref="aaa"/>
        ///523 <see cref="aaa"/>
        ///525 <see cref="aaa"/>
        ///532 <see cref="aaa"/>
        ///541b  <see cref="GetProfileList"/>
        ///541c <see cref="aaa"/>
        ///542a <see cref="aaa"/>
        ///543b <see cref="aaa"/>
        ///590 <see cref="aaa"/>
        ///820 <see cref="aaa"/>
        ///821 <see cref="aaa"/>
        ///822 <see cref="aaa"/>
        ///823 <see cref="aaa"/>
        ///824 <see cref="aaa"/>
        ///830a <see cref="aaa"/>
        ///831a <see cref="aaa"/>
        ///833a <see cref="aaa"/>











        //public static CreatePersonResponseDto createPerson(createContactDto createContactDto)
        //{
        //    var CreatePersonDto = new CreatePersonDto()
        //    {

        //        DOME_createPerson = CreatePersonInnerDto,

        //        DOME_header = new R511.domeHeaderDto()
        //        {
        //            dateSpecified = true,
        //            date = AuthentificationHelper.auth.DOME_header.date,
        //            version = AuthentificationHelper.auth.DOME_header.version,

        //        }
        //    };


        //    var data = DomeCallHelper.call2<DOME_BUS_EAI_R101contactCreateWSClient, DOME_BUS_EAI_R101contactCreateWS, CreatePersonResponseDto>(
        //        (x) =>
        //        {
        //            var person = x.createContact(,);
        //            return person;
        //        }
        //        );
        //    return data;
        //}



        public static authentificationResponseDto GetProfileList(int accountId)
        {

            var authentificationInputDto = new authentificationInputDto()
            {
                accountIdSpecified = true,
                accountId = accountId,
                DOME_header = new R541b.domeHeaderDto()
                {
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,

                }
            };



            var data = DomeCallHelper.call2<DOME_BUS_EAI_R541bGetProfileListWSClient, DOME_BUS_EAI_R541bGetProfileListWS, authentificationResponseDto>(
                (x) =>
                {
                    var t = x.getProfileListWS(authentificationInputDto);
                    return t;
                }

                );
            return data;
        }




        public static CreatePersonResponseDto createPerson(CreatePersonInnerDto CreatePersonInnerDto)
        {
            var CreatePersonDto = new CreatePersonDto()
            {

                DOME_createPerson = CreatePersonInnerDto,
                DOME_header = new R511.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = false,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            };


            var data = DomeCallHelper.call2<DOME_BUS_EAI_R511createPersonWSClient, DOME_BUS_EAI_R511createPersonWS, CreatePersonResponseDto>(
                (x) =>
                {
                    var person = x.createPerson(CreatePersonDto);
                    return person;
                }
                );
            return data;
        }


    }


    public class Entourage
    {
        //public void test()
        //{


        //    var t = new authentificationInputDto()
        //    {
        //        accountId = 102,
        //        DOME_header = new R541b.domeHeaderDto()
        //        {
        //            date = AuthentificationHelper.auth.DOME_header.date,
        //            //dateSpecified = result2.DOME_header.dateSpecified,
        //            version = AuthentificationHelper.auth.DOME_header.version,

        //        }
        //    };


        //    var client = DomeCallHelper.call<DOME_BUS_EAI_R541bGetProfileListWSClient, DOME_BUS_EAI_R541bGetProfileListWS>();

        //    var result = client.getProfileListWS(t);
        //}

        //public void test2()
        //{


        //    var profileDetailDto = new profileDetailDto()
        //    {
        //        profileIdSpecified = true,
        //        profileId = 102,
        //        DOME_header = new R541c.domeHeaderDto()
        //        {
        //            date = AuthentificationHelper.auth.DOME_header.date,
        //            version = AuthentificationHelper.auth.DOME_header.version,

        //        }
        //    };



        //    var data = DomeCallHelper.call2<DOME_BUS_EAI_R541cGetProfileDetailWSClient, DOME_BUS_EAI_R541cGetProfileDetailWS>(
        //        (x) => { return x.profileDetails(profileDetailDto); }
        //        );
        //    var a = 0;

        //}

        public void getProfile()
        {

            var authentificationInputDto = new authentificationInputDto()
            {
                accountIdSpecified = true,
                accountId = 40,
                DOME_header = new R541b.domeHeaderDto()
                {
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            };
            var data = DomeCallHelper.call2<DOME_BUS_EAI_R541bGetProfileListWSClient, DOME_BUS_EAI_R541bGetProfileListWS, authentificationResponseDto>(
                (x) =>
                {
                    var t = x.getProfileListWS(authentificationInputDto);
                    return t;
                }
                );
        }



        //public void createProfile()
        //{
        //    var createProfileDto = new createProfileDto()
        //    {
        //        accountId = (int)AuthentificationHelper.auth.account_id,
        //        accountIdSpecified = AuthentificationHelper.auth.account_idSpecified,


        //        DOME_header = new R521.domeHeaderDto()
        //        {
        //            date = AuthentificationHelper.auth.DOME_header.date,
        //            //dateSpecified = result2.DOME_header.dateSpecified,
        //            version = AuthentificationHelper.auth.DOME_header.version,

        //        }
        //    };

        //    var data = DomeCallHelper.call2<DOME_BUS_EAI_R521createProfileWSClient, DOME_BUS_EAI_R521createProfileWS, createProfileResponseDto>(
        //        (x) => { return x.createProfile(createProfileDto); }
        //        );

        //    //var url = @"http://159.122.2.36/soap/DOME_BUS_EAI_R521createProfileWS";
        //    //var binding = new BasicHttpBinding();
        //    //var endpoint = new EndpointAddress(url);
        //    //var client = new DOME_BUS_EAI_R521createProfileWSClient(binding, endpoint);

        //    //using (new OperationContextScope(client.InnerChannel))
        //    //{
        //    //    HttpRequestMessageProperty request = new HttpRequestMessageProperty();
        //    //    request.Headers["Authorization"] = "Bearer " + AuthentificationHelper.Token;

        //    //    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = request;


        //    //    var data = new createProfileDto()
        //    //    {
        //    //        accountId = (int)AuthentificationHelper.auth.account_id,
        //    //        accountIdSpecified = AuthentificationHelper.auth.account_idSpecified,


        //    //        DOME_header = new R521.domeHeaderDto()
        //    //        {
        //    //            date = AuthentificationHelper.auth.DOME_header.date,
        //    //            //dateSpecified = result2.DOME_header.dateSpecified,
        //    //            version = AuthentificationHelper.auth.DOME_header.version,

        //    //        }
        //    //    };

        //    //    var result = client.createProfile(data);
        //    //    var hy = 0;
        //    //}
        //}


        //public void getNot()
        //{

        //    var url = @"http://159.122.2.36/soap/DOME_BUS_EAI_R213beventGetNotificationStructureWS";
        //    var binding = new BasicHttpBinding();
        //    var endpoint = new EndpointAddress(url);
        //    var client = new DOME_BUS_EAI_R213beventGetNotificationStructureWSClient(binding, endpoint);

        //    using (new OperationContextScope(client.InnerChannel))
        //    {
        //        HttpRequestMessageProperty request = new HttpRequestMessageProperty();
        //        request.Headers["Authorization"] = "Bearer " + AuthentificationHelper.auth.token;

        //        OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = request;


        //        var data = new eventGetNotificationStructureDto()
        //        {
        //            structureProfileIdSpecified = true,
        //            structureProfileId = 102,

        //            DOME_header = new R213b.domeHeaderDto()
        //            {
        //                date = AuthentificationHelper.auth.DOME_header.date,
        //                //dateSpecified = result2.DOME_header.dateSpecified,
        //                version = AuthentificationHelper.auth.DOME_header.version,
        //            }
        //        };

        //        var result = client.getNotifications(data);
        //        var hy = 0;
        //    }
        //}

    }

    public enum civilite
    {
        Aucun = 0,
        Monsieur = 1,
        Madame = 2
    }

    public class MCP02
    {


        //public void createPerson()
        //{
        //    var CreatePersonDto = new CreatePersonDto()
        //    {

        //        DOME_createPerson = new CreatePersonInnerDto()
        //        {
        //            personAddressComp1 = "63 avenue lacassgne",
        //            personAddressComp2 = "",
        //            personBirthDate = new DateTime(1993, 9, 16),
        //            personBirthDateSpecified = true,
        //            personBirthName = "",
        //            personCedex = "",
        //            personCityName = "Lyon",
        //            personCityZipCode = "69003",
        //            personCivilityId = (int)civilite.Monsieur,
        //            personCivilityIdSpecified = true,
        //            personComment = "personne test",
        //            personEmail1 = "test@test.fr",
        //            personEmail2 = "",
        //            personFirstName = "guillaume",
        //            personINSC = "",
        //            personINSA = "",
        //            personJob = "",
        //            personLastName = "dumont",
        //            personLieuDit = "",
        //            personMobilePhoneNumber = "",
        //            personNIR = "",
        //            personPhoneNumber = "",
        //            personPostBox = "",
        //            personRoadName = "",
        //            personRoadType = "",
        //            personRoadNumber = "",
        //            personRPPS = "",
        //            specialCriteria = ""
        //        },

        //        DOME_header = new R511.domeHeaderDto()
        //        {
        //            dateSpecified = true,
        //            date = AuthentificationHelper.auth.DOME_header.date,
        //            version = AuthentificationHelper.auth.DOME_header.version,

        //        }
        //    };


        //    //var url = ConstHelper.urlbase + "/soap/DOME_BUS_EAI_R511createPersonWS";
        //    //var binding = new BasicHttpBinding();
        //    //var endpoint = new EndpointAddress(url);
        //    //var client = new DOME_BUS_EAI_R511createPersonWSClient(binding, endpoint);

        //    //using (new OperationContextScope(client.InnerChannel))
        //    //{

        //    //    HttpRequestMessageProperty request = new HttpRequestMessageProperty();
        //    //    request.Headers["Authorization"] = "Bearer " + AuthentificationHelper.auth.token;

        //    //    OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = request;
        //    //    var data = client.createPerson(CreatePersonDto);
        //    //}

        //    var data = DomeCallHelper.call2<DOME_BUS_EAI_R511createPersonWSClient, DOME_BUS_EAI_R511createPersonWS, createProfileResponseDto>(
        //        (x) =>
        //        {
        //            var person = x.createPerson(CreatePersonDto);
        //            return person;
        //        }
        //        );
        //    var a = 0;
        //}

    }





}

using Dome.Authentification;
using Dome.R101;
using Dome.R201;
using Dome.R213b;
using Dome.R221;
using Dome.R221s;
using Dome.R511;
using Dome.R523;
using Dome.R521;
using Dome.R541b;
using Dome.R231;
using Dome.R401a;
using Dome.R532;
using Dome.R525;
using Dome.R542a;
using Dome.R541c;
using Dome.R590;
using Dome.R543b;
using Dome.R820;
using Dome.R821;
using Dome.R822;
using Dome.R823;
using Dome.R824;
using Dome.R830a;
using Dome.R831a;
using Dome.R833a;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Configuration;

namespace Dome
{

    public static class DomeCall
    {
        ///101 <see cref="createContact"/>
        ///201 <see cref="createEvent"/>
        ///213b <see cref="getNotifications"/>
        ///221 <see cref="updateEvent"/>
        ///221s <see cref="updateEventState"/>
        ///231 <see cref="deleteEvent"/>
        ///401 <see cref="addDocument"/>
        ///511 <see cref="createPerson"/>
        ///521 <see cref="createProfile"/>
        ///523 <see cref="subscriptionPersonStructure"/>
        ///525 <see cref="linkIntervenantToBenef"/>
        ///532 <see cref="selectProfile"/>
        ///541b  <see cref="GetProfileList"/>
        ///541c <see cref="profileDetails"/>
        ///542a <see cref="updatePerson"/>
        ///543b <see cref="updatereferent"/>
        ///590 <see cref="uploadFileWs"/>
        ///820 <see cref="addCourseEntry"/>
        ///821 <see cref="getListCourseEntry"/>
        ///822 <see cref="getDetailsCourseEntry"/>
        ///823 <see cref="alterCourseEntry"/>
        ///824 <see cref="deleteCourseEntry"/>
        ///830a <see cref="addNewAGGIR"/>
        ///831a <see cref="getListAGGIR"/>
        ///833a <see cref="alterAggir"/>




        public static createContactResponseDto createContact(createContactDto createContactDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R101contactCreateWSClient, DOME_BUS_EAI_R101contactCreateWS, createContactResponseDto>
                ((client) => { return client.createContact(createContactDto); });
        }

        public static createEventResponseDto createEvent(createEventDto createEventDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R201eventCreateWSClient, DOME_BUS_EAI_R201eventCreateWS, createEventResponseDto>
                ((client) => { return client.createEvent(createEventDto); });
        }

        public static eventGetNotificationStructureResponseDto getNotifications(eventGetNotificationStructureDto eventGetNotificationStructureDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R213beventGetNotificationStructureWSClient, DOME_BUS_EAI_R213beventGetNotificationStructureWS, eventGetNotificationStructureResponseDto>
                ((client) => { return client.getNotifications(eventGetNotificationStructureDto); });
        }


        public static R221.domeResponseDto updateEvent(eventUpdateDto eventUpdateDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R221eventUpdateWSClient, DOME_BUS_EAI_R221eventUpdateWS, R221.domeResponseDto>
                ((client) => { return client.updateEvent(eventUpdateDto); });
        }

        public static eventUpdateStateResponseDto updateEventState(eventUpdateStateDto eventUpdateStateDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R221eventUpdateStateWSClient, DOME_BUS_EAI_R221eventUpdateStateWS, eventUpdateStateResponseDto>
                ((client) => { return client.updateEventState(eventUpdateStateDto); });
        }

        
        public static R231.domeResponseDto deleteEvent(deleteEventDto deleteEventDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R231eventDeleteWSClient, DOME_BUS_EAI_R231eventDeleteWS, R231.domeResponseDto>
                ((client) => { return client.deleteEvent(deleteEventDto); });
        }

        public static addDocumentResponseDto addDocument(addDocumentInputDto addDocumentInputDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R401aDocProvisionningAcquisitionWSClient, DOME_BUS_EAI_R401aDocProvisionningAcquisitionWS, addDocumentResponseDto>
                ((client) => { return client.addDocument(addDocumentInputDto); });
        }
        
        public static CreatePersonResponseDto createPerson(R511.CreatePersonInnerDto CreatePersonInnerDto)
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

        public static createProfileResponseDto createProfile(createProfileDto createProfileDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R521createProfileWSClient, DOME_BUS_EAI_R521createProfileWS, createProfileResponseDto>
                ((client) => { return client.createProfile(createProfileDto); });
        }
                
        public static subscriptionStructureResponseDto subscriptionPersonStructure(subscriptionStructureDto subscriptionStructureDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R523benefSubscriptionWSClient, DOME_BUS_EAI_R523benefSubscriptionWS, subscriptionStructureResponseDto>
                ((client) => { return client.subscriptionPersonStructure(subscriptionStructureDto); });
        }

        public static linkIntervenantToBenefResponseDto linkIntervenantToBenef(linkIntervenantToBenefDto linkIntervenantToBenefDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R525linkIntervenantToBenefWSClient, DOME_BUS_EAI_R525linkIntervenantToBenefWS, linkIntervenantToBenefResponseDto>
                ((client) => { return client.linkIntervenantToBenef(linkIntervenantToBenefDto); });
        }

                public static selectProfileResponseDto selectProfile(selectProfileDto selectProfileDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R532selectProfileWSClient, DOME_BUS_EAI_R532selectProfileWS, selectProfileResponseDto>
                ((client) => { return client.selectProfile(selectProfileDto); });
        }

                public static profileDetailResponseDto profileDetails(profileDetailDto profileDetailDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R541cGetProfileDetailWSClient, DOME_BUS_EAI_R541cGetProfileDetailWS, profileDetailResponseDto>
                ((client) => { return client.profileDetails(profileDetailDto); });
        }

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

        public static UpdatePersonResponseDto updatePerson(UpdatePersonDto UpdatePersonDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R542aUpdatePersonWSClient, DOME_BUS_EAI_R542aUpdatePersonWS, UpdatePersonResponseDto>
                ((client) => { return client.updatePerson(UpdatePersonDto); });
        }

        public static R543b.domeResponseDto updatereferent(updateReferentDto updateReferentDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R543bSwitchReferentWSClient, DOME_BUS_EAI_R543bSwitchReferentWS, R543b.domeResponseDto>
                ((client) => { return client.updatereferent(updateReferentDto); });
        }

        public static createdMediaResponseDto uploadFileWs(uploadFileWSDto uploadFileWSDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R590getMultimediaFileClient, DOME_BUS_EAI_R590getMultimediaFile, createdMediaResponseDto>
                ((client) => { return client.uploadFileWs(uploadFileWSDto); });
        }

                public static addCourseEntryResponseDto addCourseEntry(R820.addCourseEntryDto addCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R820addNewJourneyEntryWSClient, DOME_BUS_EAI_R820addNewJourneyEntryWS, addCourseEntryResponseDto>
                ((client) => { return client.addCourseEntry(addCourseEntryDto); });
        }



        public static getListCourseEntryResponseDto getListCourseEntry(getListCourseEntryDto getListCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R821getListJourneyEntryWSClient, DOME_BUS_EAI_R821getListJourneyEntryWS, getListCourseEntryResponseDto>
                ((client) => { return client.getListCourseEntry(getListCourseEntryDto); });
        }

        public static getCourseEntryDetailsResponseDto getDetailsCourseEntry(getCourseEntryDetailsDto getCourseEntryDetailsDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R822getDetailJourneyEntryWSClient, DOME_BUS_EAI_R822getDetailJourneyEntryWS, getCourseEntryDetailsResponseDto>
                ((client) => { return client.getDetailsCourseEntry(getCourseEntryDetailsDto); });
        }

        public static R823.domeResponseDto alterCourseEntry(alterCourseEntryDto alterCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R823setDetailJourneyEntryWSClient, DOME_BUS_EAI_R823setDetailJourneyEntryWS, R823.domeResponseDto>
                ((client) => { return client.alterCourseEntry(alterCourseEntryDto); });
        }

        public static R824.domeResponseDto deleteCourseEntry(deleteCourseEntryDto deleteCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R824deleteJourneyEntryWSClient, DOME_BUS_EAI_R824deleteJourneyEntryWS, R824.domeResponseDto>
                ((client) => { return client.deleteCourseEntry(deleteCourseEntryDto); });
        }

        public static addNewAGGIRResponseDto addNewAGGIR(addNewAGGIRDto addNewAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R830aAddNewAGGIRWSClient, DOME_BUS_EAI_R830aAddNewAGGIRWS, addNewAGGIRResponseDto>
                ((client) => { return client.addNewAGGIR(addNewAGGIRDto); });
        }

        public static getListAGGIRResponseDto getListAGGIR(getListAGGIRDto getListAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R831aGetListAGGIRWSClient, DOME_BUS_EAI_R831aGetListAGGIRWS, getListAGGIRResponseDto>
                ((client) => { return client.getListAGGIR(getListAGGIRDto); });
        }

        public static R833a.domeResponseDto alterAggir(alterAGGIRDto alterAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R833aSetDetailAGGIRWSClient, DOME_BUS_EAI_R833aSetDetailAGGIRWS, R833a.domeResponseDto>
                ((client) => { return client.alterAggir(alterAGGIRDto); });
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

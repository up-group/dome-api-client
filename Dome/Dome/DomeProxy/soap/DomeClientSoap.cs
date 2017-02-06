using Dome.Service_References.R101;
using Dome.Service_References.R201;
using Dome.Service_References.R213b;
using Dome.Service_References.R221;
using Dome.Service_References.R221s;
using Dome.Service_References.R231;
using Dome.Service_References.R401a;
using Dome.Service_References.R511;
using Dome.Service_References.R521;
using Dome.Service_References.R523;
using Dome.Service_References.R525;
using Dome.Service_References.R532;
using Dome.Service_References.R541b;
using Dome.Service_References.R541c;
using Dome.Service_References.R542a;
using Dome.Service_References.R543b;
using Dome.Service_References.R590;
using Dome.Service_References.R820;
using Dome.Service_References.R821;
using Dome.Service_References.R822;
using Dome.Service_References.R823;
using Dome.Service_References.R824;
using Dome.Service_References.R830a;
using Dome.Service_References.R831a;
using Dome.Service_References.R833a;
using addCourseEntryDto = Dome.Service_References.R820.addCourseEntryDto;
using domeResponseDto = Dome.Service_References.R221.domeResponseDto;

namespace Dome.DomeProxy.soap
{
    internal class DomeClientSoap
    {
        
      

    
        ///101 <see cref="CreateContact"/>
        ///201 <see cref="CreateEvent"/>
        ///213b <see cref="GetNotifications"/>
        ///221 <see cref="UpdateEvent"/>
        ///221s <see cref="UpdateEventState"/>
        ///231 <see cref="DeleteEvent"/>
        ///401 <see cref="AddDocument"/>
        ///511 <see cref="CreatePerson"/>
        ///521 <see cref="CreateProfile"/>
        ///523 <see cref="SubscriptionPersonStructure"/>
        ///525 <see cref="LinkIntervenantToBenef"/>
        ///532 <see cref="SelectProfile"/>
        ///541b  <see cref="GetProfileList"/>
        ///541c <see cref="ProfileDetails"/>
        ///542a <see cref="UpdatePerson"/>
        ///543b <see cref="UpdateReferent"/>
        ///590 <see cref="UploadFileWs"/>
        ///820 <see cref="AddCourseEntry"/>
        ///821 <see cref="GetListCourseEntry"/>
        ///822 <see cref="GetDetailsCourseEntry"/>
        ///823 <see cref="AlterCourseEntry"/>
        ///824 <see cref="DeleteCourseEntry"/>
        ///830a <see cref="AddNewAggir"/>
        ///831a <see cref="GetListAggir"/>
        ///833a <see cref="AlterAggir"/>


        public createContactResponseDto CreateContact(createContactDto createContactDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R101contactCreateWSClient, DOME_BUS_EAI_R101contactCreateWS, createContactResponseDto>
                ((client) => { return client.createContact(createContactDto); });
        }

        public createEventResponseDto CreateEvent(createEventDto createEventDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R201eventCreateWSClient, DOME_BUS_EAI_R201eventCreateWS, createEventResponseDto>
                ((client) => { return client.createEvent(createEventDto); });
        }

        public eventGetNotificationStructureResponseDto GetNotifications(eventGetNotificationStructureDto eventGetNotificationStructureDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R213beventGetNotificationStructureWSClient, DOME_BUS_EAI_R213beventGetNotificationStructureWS, eventGetNotificationStructureResponseDto>
                ((client) => { return client.getNotifications(eventGetNotificationStructureDto); });
        }


        public domeResponseDto UpdateEvent(eventUpdateDto eventUpdateDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R221eventUpdateWSClient, DOME_BUS_EAI_R221eventUpdateWS, domeResponseDto>
                ((client) => { return client.updateEvent(eventUpdateDto); });
        }

        public eventUpdateStateResponseDto UpdateEventState(eventUpdateStateDto eventUpdateStateDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R221eventUpdateStateWSClient, DOME_BUS_EAI_R221eventUpdateStateWS, eventUpdateStateResponseDto>
                ((client) => { return client.updateEventState(eventUpdateStateDto); });
        }


        public Service_References.R231.domeResponseDto DeleteEvent(deleteEventDto deleteEventDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R231eventDeleteWSClient, DOME_BUS_EAI_R231eventDeleteWS, Service_References.R231.domeResponseDto>
                ((client) => { return client.deleteEvent(deleteEventDto); });
        }

        public addDocumentResponseDto AddDocument(addDocumentInputDto addDocumentInputDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R401aDocProvisionningAcquisitionWSClient, DOME_BUS_EAI_R401aDocProvisionningAcquisitionWS, addDocumentResponseDto>
                ((client) => { return client.addDocument(addDocumentInputDto); });
        }

        public CreatePersonResponseDto CreatePerson(CreatePersonDto createPersonDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R511createPersonWSClient, DOME_BUS_EAI_R511createPersonWS, CreatePersonResponseDto>
                 ((client) => { return client.createPerson(createPersonDto); });
        }

        public createProfileResponseDto CreateProfile(createProfileDto createProfileDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R521createProfileWSClient, DOME_BUS_EAI_R521createProfileWS, createProfileResponseDto>
                ((client) => { return client.createProfile(createProfileDto); });
        }

        public subscriptionStructureResponseDto SubscriptionPersonStructure(subscriptionStructureDto subscriptionStructureDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R523benefSubscriptionWSClient, DOME_BUS_EAI_R523benefSubscriptionWS, subscriptionStructureResponseDto>
                ((client) => { return client.subscriptionPersonStructure(subscriptionStructureDto); });
        }

        public linkIntervenantToBenefResponseDto LinkIntervenantToBenef(linkIntervenantToBenefDto linkIntervenantToBenefDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R525linkIntervenantToBenefWSClient, DOME_BUS_EAI_R525linkIntervenantToBenefWS, linkIntervenantToBenefResponseDto>
                ((client) => { return client.linkIntervenantToBenef(linkIntervenantToBenefDto); });
        }

        public selectProfileResponseDto SelectProfile(selectProfileDto selectProfileDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R532selectProfileWSClient, DOME_BUS_EAI_R532selectProfileWS, selectProfileResponseDto>
                ((client) => { return client.selectProfile(selectProfileDto); });
        }

        public profileDetailResponseDto ProfileDetails(profileDetailDto profileDetailDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R541cGetProfileDetailWSClient, DOME_BUS_EAI_R541cGetProfileDetailWS, profileDetailResponseDto>
                ((client) => { return client.profileDetails(profileDetailDto); });
        }

        public authentificationResponseDto GetProfileList(authentificationInputDto authentificationInputDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R541bGetProfileListWSClient, DOME_BUS_EAI_R541bGetProfileListWS, authentificationResponseDto>
                ((client) => { return client.getProfileListWS(authentificationInputDto); });
        }

        public UpdatePersonResponseDto UpdatePerson(UpdatePersonDto updatePersonDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R542aUpdatePersonWSClient, DOME_BUS_EAI_R542aUpdatePersonWS, UpdatePersonResponseDto>
                ((client) => { return client.updatePerson(updatePersonDto); });
        }

        public Service_References.R543b.domeResponseDto UpdateReferent(updateReferentDto updateReferentDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R543bSwitchReferentWSClient, DOME_BUS_EAI_R543bSwitchReferentWS, Service_References.R543b.domeResponseDto>
                ((client) => { return client.updatereferent(updateReferentDto); });
        }

        public createdMediaResponseDto UploadFileWs(uploadFileWSDto uploadFileWsDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R590getMultimediaFileClient, DOME_BUS_EAI_R590getMultimediaFile, createdMediaResponseDto>
                ((client) => { return client.uploadFileWs(uploadFileWsDto); });
        }

        public addCourseEntryResponseDto AddCourseEntry(addCourseEntryDto addCourseEntryDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R820addNewJourneyEntryWSClient, DOME_BUS_EAI_R820addNewJourneyEntryWS, addCourseEntryResponseDto>
                ((client) => { return client.addCourseEntry(addCourseEntryDto); });
        }

        public getListCourseEntryResponseDto GetListCourseEntry(getListCourseEntryDto getListCourseEntryDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R821getListJourneyEntryWSClient, DOME_BUS_EAI_R821getListJourneyEntryWS, getListCourseEntryResponseDto>
                ((client) => { return client.getListCourseEntry(getListCourseEntryDto); });
        }

        public getCourseEntryDetailsResponseDto GetDetailsCourseEntry(getCourseEntryDetailsDto getCourseEntryDetailsDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R822getDetailJourneyEntryWSClient, DOME_BUS_EAI_R822getDetailJourneyEntryWS, getCourseEntryDetailsResponseDto>
                ((client) => { return client.getDetailsCourseEntry(getCourseEntryDetailsDto); });
        }

        public Service_References.R823.domeResponseDto AlterCourseEntry(alterCourseEntryDto alterCourseEntryDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R823setDetailJourneyEntryWSClient, DOME_BUS_EAI_R823setDetailJourneyEntryWS, Service_References.R823.domeResponseDto>
                ((client) => { return client.alterCourseEntry(alterCourseEntryDto); });
        }

        public Service_References.R824.domeResponseDto DeleteCourseEntry(deleteCourseEntryDto deleteCourseEntryDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R824deleteJourneyEntryWSClient, DOME_BUS_EAI_R824deleteJourneyEntryWS, Service_References.R824.domeResponseDto>
                ((client) => { return client.deleteCourseEntry(deleteCourseEntryDto); });
        }

        public addNewAGGIRResponseDto AddNewAggir(addNewAGGIRDto addNewAggirDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R830aAddNewAGGIRWSClient, DOME_BUS_EAI_R830aAddNewAGGIRWS, addNewAGGIRResponseDto>
                ((client) => { return client.addNewAGGIR(addNewAggirDto); });
        }

        public getListAGGIRResponseDto GetListAggir(getListAGGIRDto getListAggirDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R831aGetListAGGIRWSClient, DOME_BUS_EAI_R831aGetListAGGIRWS, getListAGGIRResponseDto>
                ((client) => { return client.getListAGGIR(getListAggirDto); });
        }

        public Service_References.R833a.domeResponseDto AlterAggir(alterAGGIRDto alterAggirDto)
        {
            return DomeClientSoapCallHelper.Call<DOME_BUS_EAI_R833aSetDetailAGGIRWSClient, DOME_BUS_EAI_R833aSetDetailAGGIRWS, Service_References.R833a.domeResponseDto>
                ((client) => { return client.alterAggir(alterAggirDto); });
        }

    }
}

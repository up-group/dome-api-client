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

namespace Dome
{
    public class DomeCallSoap
    {
        public DomeCallSoap()
        {
            if (AuthentificationHelper.Instance.auth == null)
            {
                AuthentificationHelper.Instance.connect();
            }
        }


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
        ///543b <see cref="updateReferent"/>
        ///590 <see cref="uploadFileWs"/>
        ///820 <see cref="addCourseEntry"/>
        ///821 <see cref="getListCourseEntry"/>
        ///822 <see cref="getDetailsCourseEntry"/>
        ///823 <see cref="alterCourseEntry"/>
        ///824 <see cref="deleteCourseEntry"/>
        ///830a <see cref="addNewAGGIR"/>
        ///831a <see cref="getListAGGIR"/>
        ///833a <see cref="alterAggir"/>


        public createContactResponseDto createContact(createContactDto createContactDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R101contactCreateWSClient, DOME_BUS_EAI_R101contactCreateWS, createContactResponseDto>
                ((client) => { return client.createContact(createContactDto); });
        }

        public createEventResponseDto createEvent(createEventDto createEventDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R201eventCreateWSClient, DOME_BUS_EAI_R201eventCreateWS, createEventResponseDto>
                ((client) => { return client.createEvent(createEventDto); });
        }

        public eventGetNotificationStructureResponseDto getNotifications(eventGetNotificationStructureDto eventGetNotificationStructureDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R213beventGetNotificationStructureWSClient, DOME_BUS_EAI_R213beventGetNotificationStructureWS, eventGetNotificationStructureResponseDto>
                ((client) => { return client.getNotifications(eventGetNotificationStructureDto); });
        }


        public R221.domeResponseDto updateEvent(eventUpdateDto eventUpdateDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R221eventUpdateWSClient, DOME_BUS_EAI_R221eventUpdateWS, R221.domeResponseDto>
                ((client) => { return client.updateEvent(eventUpdateDto); });
        }

        public eventUpdateStateResponseDto updateEventState(eventUpdateStateDto eventUpdateStateDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R221eventUpdateStateWSClient, DOME_BUS_EAI_R221eventUpdateStateWS, eventUpdateStateResponseDto>
                ((client) => { return client.updateEventState(eventUpdateStateDto); });
        }


        public R231.domeResponseDto deleteEvent(deleteEventDto deleteEventDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R231eventDeleteWSClient, DOME_BUS_EAI_R231eventDeleteWS, R231.domeResponseDto>
                ((client) => { return client.deleteEvent(deleteEventDto); });
        }

        public addDocumentResponseDto addDocument(addDocumentInputDto addDocumentInputDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R401aDocProvisionningAcquisitionWSClient, DOME_BUS_EAI_R401aDocProvisionningAcquisitionWS, addDocumentResponseDto>
                ((client) => { return client.addDocument(addDocumentInputDto); });
        }

        public CreatePersonResponseDto createPerson(R511.CreatePersonDto CreatePersonDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R511createPersonWSClient, DOME_BUS_EAI_R511createPersonWS, CreatePersonResponseDto>
                 ((client) => { return client.createPerson(CreatePersonDto); });
        }

        public createProfileResponseDto createProfile(createProfileDto createProfileDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R521createProfileWSClient, DOME_BUS_EAI_R521createProfileWS, createProfileResponseDto>
                ((client) => { return client.createProfile(createProfileDto); });
        }

        public subscriptionStructureResponseDto subscriptionPersonStructure(subscriptionStructureDto subscriptionStructureDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R523benefSubscriptionWSClient, DOME_BUS_EAI_R523benefSubscriptionWS, subscriptionStructureResponseDto>
                ((client) => { return client.subscriptionPersonStructure(subscriptionStructureDto); });
        }

        public linkIntervenantToBenefResponseDto linkIntervenantToBenef(linkIntervenantToBenefDto linkIntervenantToBenefDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R525linkIntervenantToBenefWSClient, DOME_BUS_EAI_R525linkIntervenantToBenefWS, linkIntervenantToBenefResponseDto>
                ((client) => { return client.linkIntervenantToBenef(linkIntervenantToBenefDto); });
        }

        public selectProfileResponseDto selectProfile(selectProfileDto selectProfileDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R532selectProfileWSClient, DOME_BUS_EAI_R532selectProfileWS, selectProfileResponseDto>
                ((client) => { return client.selectProfile(selectProfileDto); });
        }

        public profileDetailResponseDto profileDetails(int profileid)
        {
            var profileDetailDto = new R541c.profileDetailDto()
            {
                profileId = profileid,
                profileIdSpecified = true,
                DOME_header = new R541c.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            };

            return DomeCallHelper.call2<DOME_BUS_EAI_R541cGetProfileDetailWSClient, DOME_BUS_EAI_R541cGetProfileDetailWS, profileDetailResponseDto>
                ((client) => { return client.profileDetails(profileDetailDto); });
        }

        public authentificationResponseDto GetProfileList(int accountId)
        {
            var authentificationInputDto = new authentificationInputDto()
            {
                accountIdSpecified = true,
                accountId = accountId,
                DOME_header = new R541b.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            };

            return DomeCallHelper.call2<DOME_BUS_EAI_R541bGetProfileListWSClient, DOME_BUS_EAI_R541bGetProfileListWS, authentificationResponseDto>
                 ((client) => { return client.getProfileListWS(authentificationInputDto); });
        }

        public UpdatePersonResponseDto updatePerson(UpdatePersonDto UpdatePersonDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R542aUpdatePersonWSClient, DOME_BUS_EAI_R542aUpdatePersonWS, UpdatePersonResponseDto>
                ((client) => { return client.updatePerson(UpdatePersonDto); });
        }

        public R543b.domeResponseDto updateReferent(updateReferentDto updateReferentDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R543bSwitchReferentWSClient, DOME_BUS_EAI_R543bSwitchReferentWS, R543b.domeResponseDto>
                ((client) => { return client.updatereferent(updateReferentDto); });
        }

        public createdMediaResponseDto uploadFileWs(uploadFileWSDto uploadFileWSDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R590getMultimediaFileClient, DOME_BUS_EAI_R590getMultimediaFile, createdMediaResponseDto>
                ((client) => { return client.uploadFileWs(uploadFileWSDto); });
        }

        public addCourseEntryResponseDto addCourseEntry(R820.addCourseEntryDto addCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R820addNewJourneyEntryWSClient, DOME_BUS_EAI_R820addNewJourneyEntryWS, addCourseEntryResponseDto>
                ((client) => { return client.addCourseEntry(addCourseEntryDto); });
        }

        public getListCourseEntryResponseDto getListCourseEntry(getListCourseEntryDto getListCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R821getListJourneyEntryWSClient, DOME_BUS_EAI_R821getListJourneyEntryWS, getListCourseEntryResponseDto>
                ((client) => { return client.getListCourseEntry(getListCourseEntryDto); });
        }

        public getCourseEntryDetailsResponseDto getDetailsCourseEntry(getCourseEntryDetailsDto getCourseEntryDetailsDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R822getDetailJourneyEntryWSClient, DOME_BUS_EAI_R822getDetailJourneyEntryWS, getCourseEntryDetailsResponseDto>
                ((client) => { return client.getDetailsCourseEntry(getCourseEntryDetailsDto); });
        }

        public R823.domeResponseDto alterCourseEntry(alterCourseEntryDto alterCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R823setDetailJourneyEntryWSClient, DOME_BUS_EAI_R823setDetailJourneyEntryWS, R823.domeResponseDto>
                ((client) => { return client.alterCourseEntry(alterCourseEntryDto); });
        }

        public R824.domeResponseDto deleteCourseEntry(deleteCourseEntryDto deleteCourseEntryDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R824deleteJourneyEntryWSClient, DOME_BUS_EAI_R824deleteJourneyEntryWS, R824.domeResponseDto>
                ((client) => { return client.deleteCourseEntry(deleteCourseEntryDto); });
        }

        public addNewAGGIRResponseDto addNewAGGIR(addNewAGGIRDto addNewAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R830aAddNewAGGIRWSClient, DOME_BUS_EAI_R830aAddNewAGGIRWS, addNewAGGIRResponseDto>
                ((client) => { return client.addNewAGGIR(addNewAGGIRDto); });
        }

        public getListAGGIRResponseDto getListAGGIR(getListAGGIRDto getListAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R831aGetListAGGIRWSClient, DOME_BUS_EAI_R831aGetListAGGIRWS, getListAGGIRResponseDto>
                ((client) => { return client.getListAGGIR(getListAGGIRDto); });
        }

        public R833a.domeResponseDto alterAggir(alterAGGIRDto alterAGGIRDto)
        {
            return DomeCallHelper.call2<DOME_BUS_EAI_R833aSetDetailAGGIRWSClient, DOME_BUS_EAI_R833aSetDetailAGGIRWS, R833a.domeResponseDto>
                ((client) => { return client.alterAggir(alterAGGIRDto); });
        }

    }
}

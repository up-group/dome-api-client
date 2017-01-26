using System;
using Dome.Client.dto;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.createPerson.basic;
using Dome.Client.dto.createPerson.result;
using Dome.Client.dto.updatePerson;
using Dome.Client.interfaces;
using Dome.DomeProxy;
using Dome.DomeProxy.soap;
using Dome.Enum;
using Dome.Service_References.R511;
using Dome.Service_References.R521;
using Dome.Service_References.R523;
using Dome.Service_References.R525;
using Dome.Service_References.R532;
using Dome.Service_References.R541b;
using Dome.Service_References.R541c;
using Dome.Service_References.R542a;
using Dome.Service_References.R830a;
using Dome.Service_References.R833a;
using addNewAggirInnerDto = Dome.Service_References.R830a.addNewAggirInnerDto;
using CreatePersonInnerDto = Dome.Service_References.R511.CreatePersonInnerDto;
using domeHeaderDto = Dome.Service_References.R511.domeHeaderDto;

namespace Dome.Client
{
    public class DomeClient : IDomeClient
    {
        private DeviceType DeviceType { get; set; }

        private DomeClientSoap DomeCallSoap { get; set; }

        public DomeClient()
        {
            DomeCallSoap = new DomeClientSoap();
            DeviceType = DeviceType.LogicielMétier;

        }

        private ActionResult<CreatePersonResponseDto> _CreatePerson(CreatePerson createPerson)
        {
            var createPersonDto = new CreatePersonDto()
            {
                DOME_createPerson = new CreatePersonInnerDto()
                {
                    personBirthDateSpecified = true,
                    personCivilityIdSpecified = true,

                    personAddressComp1 = createPerson.PersonAddressComp1,
                    personAddressComp2 = createPerson.PersonAddressComp2,
                    personBirthDate = createPerson.PersonBirthDate,
                    personBirthName = createPerson.PersonBirthName,
                    personCedex = createPerson.PersonCedex,
                    personCityName = createPerson.PersonCityName,
                    personCityZipCode = createPerson.PersonCityZipCode,
                    personCivilityId = (int)createPerson.PersonCivility,
                    personComment = createPerson.PersonComment,
                    personEmail1 = createPerson.PersonEmail1,
                    personEmail2 = createPerson.PersonEmail2,
                    personFirstName = createPerson.PersonFirstName,
                    personINSA = createPerson.PersonInsa,
                    personINSC = createPerson.PersonInsc,
                    personJob = createPerson.PersonJob,
                    personLastName = createPerson.PersonLastName,
                    personLieuDit = createPerson.PersonLieuDit,
                    personMobilePhoneNumber = createPerson.PersonMobilePhoneNumber,
                    personNIR = createPerson.PersonNir,
                    personPhoneNumber = createPerson.PersonPhoneNumber,
                    personPostBox = createPerson.PersonPostBox,
                    personRoadName = createPerson.PersonRoadName,
                    personRoadNumber = createPerson.PersonRoadNumber,
                    personRoadType = createPerson.PersonRoadType,
                    personRPPS = createPerson.PersonRpps,
                    specialCriteria = createPerson.SpecialCriteria,
                },
                DOME_header = new domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                }
            };

            var createPersonDomeResult = DomeCallSoap.CreatePerson(createPersonDto);

            if (createPersonDomeResult.statusId == 0)
            {
                return new ActionResult<CreatePersonResponseDto>(true, createPersonDomeResult);
            }
            return new ActionResult<CreatePersonResponseDto>(false, createPersonDomeResult, new Message(MessageType.Error, createPersonDomeResult.statusErrorMessage));
        }

        private ActionResult<createProfileResponseDto> _CreateProfile(CreateProfile createProfil)
        {
            var createProfileDto = new createProfileDto()
            {
                DOME_header = new Service_References.R521.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },

                accountId = createProfil.AccountId.Value,
                accountIdSpecified = true,

                personIdMetier = createProfil.PersonIdMetier,

                profileCibleType = (int)Profile.Beneficiaire,
                profileCibleTypeSpecified = true,

                personSocietyRole = (int)createProfil.PersonSocietyRole,
                personSocietyRoleSpecified = false,

                profileParentId = createProfil.ProfileParentId,
                profileParentIdSpecified = false,

                profileAvatar = createProfil.ProfileAvatar,
                profileAvatarSpecified = true,

                prestationListId = createProfil.PrestationListId,

                profileSectoring = createProfil.ProfileSectoring,

                profileSpecialCriteria = createProfil.ProfileSpecialCriteria
            };


            var createProfileDomeResult = DomeCallSoap.CreateProfile(createProfileDto);

            if (createProfileDomeResult.statusId == 0)
            {
                return new ActionResult<createProfileResponseDto>(true, createProfileDomeResult);
            }
            return new ActionResult<createProfileResponseDto>(false, createProfileDomeResult, new Message(MessageType.Error, createProfileDomeResult.statusErrorMessage));
        }

        private ActionResult<CreatePersonProfilResult> _CreatePersonAndProfil(CreateEntity createEntity)
        {
            var createPerson = new CreatePerson(createEntity);
            var createProfile = new CreateProfile(createEntity);


            var createPersonProfilResult = new CreatePersonProfilResult();
            if (createProfile.AccountId.HasValue == false)
            {
                var person = _CreatePerson(createPerson);
                createPersonProfilResult.SetFromPersonResult(person.Entity);
                if (person.Succeeded == false || person.Entity.accountId == 0)
                {
                    return new ActionResult<CreatePersonProfilResult>(false, createPersonProfilResult, person.Messages);
                }
                createProfile.AccountId = person.Entity.accountId;
            }

            var profile = _CreateProfile(createProfile);
            createPersonProfilResult.SetFromProfilResult(profile.Entity);
            return new ActionResult<CreatePersonProfilResult>(profile.Succeeded, createPersonProfilResult, profile.Messages);
        }

        internal ActionResult _SelectProfil(int profileId)
        {
            var data = DomeCallSoap.SelectProfile(new selectProfileDto()
            {
                DOME_header = new Service_References.R532.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },
                profileId = profileId,
                profileIdSpecified = true
            });


            if (data.statusId == 0)
            {
                return new ActionResult(true);
            }
            return new ActionResult(false, new Message(MessageType.Error, data.statusErrorMessage));


        }

        internal ActionResult<authentificationResponseDto> GetAccount(int accountId)
        {

            var data = DomeCallSoap.GetProfileList(new authentificationInputDto()
            {
                accountIdSpecified = true,
                accountId = accountId,
                DOME_header = new Service_References.R541b.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<authentificationResponseDto>(true, data);
            }
            return new ActionResult<authentificationResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));

        }

        internal ActionResult<profileDetailResponseDto> GetProfile(int profileId)
        {
            var data = DomeCallSoap.ProfileDetails(new profileDetailDto()
            {
                profileId = profileId,
                profileIdSpecified = true,
                DOME_header = new Service_References.R541c.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<profileDetailResponseDto>(true, data);
            }
            return new ActionResult<profileDetailResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));

        }







        public ActionResult<CreatePersonProfilResult> CreatePatient(CreatePatient createPatient)
        {
            return _CreatePersonAndProfil(createPatient);
        }

        public ActionResult<CreatePersonProfilResult> CreateEntourage(CreateEntourage createEntourage)
        {
            return _CreatePersonAndProfil(createEntourage);

        }

        public ActionResult<CreatePersonProfilResult> CreateSalarie(CreateSalarie createSalarie)
        {
            return _CreatePersonAndProfil(createSalarie);
        }

        public ActionResult<CreatePersonProfilResult> CreateStructure(CreateStructure createStructure)
        {
            return _CreatePersonAndProfil(createStructure);

        }

        public ActionResult<CreatePersonProfilResult> CreateIntervenant(CreateIntervenant createIntervenant)
        {
            return _CreatePersonAndProfil(createIntervenant);
        }


        public ActionResult<UpdatePersonResponseDto> UpdatePerson(int accountId, UpdatePerson updatePerson)
        {
            var updatePersonDto = new UpdatePersonDto()
            {
                DOME_header = new Service_References.R542a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },
                accountId = accountId,
                accountIdSpecified = true,
                DOME_createPerson = new Service_References.R542a.CreatePersonInnerDto()
                {
                    personAddressComp1 = updatePerson.PersonAddressComp1,
                    personAddressComp2 = updatePerson.PersonAddressComp2,
                    personBirthDate = updatePerson.PersonBirthDate,
                    //personBirthDateSpecified = createPerson.personBirthDateSpecified,
                    personBirthName = updatePerson.PersonBirthName,
                    personCedex = updatePerson.PersonCedex,
                    personCityName = updatePerson.PersonCityName,
                    personCityZipCode = updatePerson.PersonCityZipCode,
                    personCivilityId = (int)updatePerson.PersonCivilityId,
                    //personCivilityIdSpecified = createPerson.personCivilityIdSpecified,
                    personComment = updatePerson.PersonComment,
                    personEmail1 = updatePerson.PersonEmail1,
                    personEmail2 = updatePerson.PersonEmail2,
                    personFirstName = updatePerson.PersonFirstName,
                    personINSA = updatePerson.PersonInsa,
                    personINSC = updatePerson.PersonInsc,
                    personJob = updatePerson.PersonJob,
                    personLastName = updatePerson.PersonLastName,
                    personLieuDit = updatePerson.PersonLieuDit,
                    personMobilePhoneNumber = updatePerson.PersonMobilePhoneNumber,
                    personNIR = updatePerson.PersonNir,
                    personPhoneNumber = updatePerson.PersonPhoneNumber,
                    personPostBox = updatePerson.PersonPostBox,
                    personRoadName = updatePerson.PersonRoadName,
                    personRoadNumber = updatePerson.PersonRoadNumber,
                    personRoadType = updatePerson.PersonRoadType,
                    personRPPS = updatePerson.PersonRpps,
                    specialCriteria = updatePerson.SpecialCriteria,


                }

            };
            var data = DomeCallSoap.UpdatePerson(updatePersonDto);

            //var aaa = testREs<ActionResult<UpdatePersonResultDTO>>(data, new UpdatePersonResultDTO(data));

            if (data.statusId == 0)
            {
                return new ActionResult<UpdatePersonResponseDto>(true, data);
            }
            return new ActionResult<UpdatePersonResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));

        }


        public ActionResult LinkIntervenantToBenef(int patientProfileId, int intervenantProfileId)
        {
            var data = DomeCallSoap.LinkIntervenantToBenef(new linkIntervenantToBenefDto()
            {
                DOME_header = new Service_References.R525.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },

                benefProfileId = patientProfileId,
                benefProfileIdSpecified = true,
                intervenantProfileId = intervenantProfileId,
                intervenantProfileIdSpecified = true
            });

            if (data.statusId == 0)
            {
                return new ActionResult(true);
            }
            return new ActionResult(false, new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult SubscriptionPersonStructure(int patientProfileId, int structureProfileId)
        {
            var data = DomeCallSoap.SubscriptionPersonStructure(new subscriptionStructureDto()
            {
                DOME_header = new Service_References.R523.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },

                profileStructureId = structureProfileId,
                profileStructureIdSpecified = true,

                profileBenefId = patientProfileId,
                profileBenefIdSpecified = true
            });


            if (data.statusId == 0)
            {
                return new ActionResult(true);
            }
            return new ActionResult(false, new Message(MessageType.Error, data.statusErrorMessage));

        }




        public ActionResult<int> CreateAggir(int beneficiareProfileId, CreateAggirDto createAggirDto)
        {
            var data = DomeCallSoap.AddNewAggir(new addNewAGGIRDto()
            {

                DOME_header = new Service_References.R830a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },

                benefProfileId = beneficiareProfileId,
                benefProfileIdSpecified = true,
                DOME_medAGGIR = new addNewAggirInnerDto()
                {
                    AGGIRAchats = createAggirDto.AggirAchats,
                    AGGIRAlerter = createAggirDto.AggirAlerter,
                    //AGGIRAchatsSpecified =createAggirDto.AGGIRAchatsSpecified,
                    //AGGIRAlerterSpecified =createAggirDto.AGGIRAlerterSpecified,
                    AGGIRAlimentation = createAggirDto.AggirAlimentation,
                    //AGGIRAlimentationSpecified =createAggirDto.AGGIRAlimentationSpecified,
                    AGGIRCode = createAggirDto.AggirCode,
                    //AGGIRCodeSpecified =createAggirDto.AGGIRCodeSpecified,
                    AGGIRCoherence = createAggirDto.AggirCoherence,
                    //AGGIRCoherenceSpecified =createAggirDto.AGGIRCoherenceSpecified,
                    AGGIRComment = createAggirDto.AggirComment,
                    AGGIRCreationDate = createAggirDto.AggirCreationDate,
                    //AGGIRCreationDateSpecified =createAggirDto.AGGIRCreationDateSpecified,
                    AGGIRCreationProfileId = createAggirDto.AggirCreationProfileId,
                    //AGGIRCreationProfileIdSpecified =createAggirDto.AGGIRCreationProfileIdSpecified,
                    AGGIRCreatorEntityName = createAggirDto.AggirCreatorEntityName,
                    AGGIRCreatorName = createAggirDto.AggirCreatorName,
                    AGGIRCuisine = createAggirDto.AggirCuisine,
                    //AGGIRCuisineSpecified =createAggirDto.AGGIRCuisineSpecified,
                    AGGIRDeplacExt = createAggirDto.AggirDeplacExt,
                    //AGGIRDeplacExtSpecified =createAggirDto.AGGIRDeplacExtSpecified,
                    AGGIRDeplacInt = createAggirDto.AggirDeplacInt,
                    //AGGIRDeplacIntSpecified =createAggirDto.AGGIRDeplacIntSpecified,
                    AGGIRElimination = createAggirDto.AggirElimination,
                    //AGGIREliminationSpecified =createAggirDto.AGGIREliminationSpecified,
                    AGGIREvaluationDate = createAggirDto.AggirEvaluationDate,
                    //AGGIREvaluationDateSpecified =createAggirDto.AGGIREvaluationDateSpecified,
                    AGGIREvaluatorName = createAggirDto.AggirEvaluatorName,
                    AGGIRGestion = createAggirDto.AggirGestion,
                    //AGGIRGestionSpecified =createAggirDto.AGGIRGestionSpecified,
                    AGGIRHabillage = createAggirDto.AggirHabillage,
                    //AGGIRHabillageSpecified =createAggirDto.AGGIRHabillageSpecified,
                    AGGIRMenage = createAggirDto.AggirMenage,
                    //AGGIRMenageSpecified =createAggirDto.AGGIRMenageSpecified,
                    AGGIROrientation = createAggirDto.AggirOrientation,
                    //AGGIROrientationSpecified =createAggirDto.AGGIROrientationSpecified,
                    AGGIRSuiviTraitement = createAggirDto.AggirSuiviTraitement,
                    //AGGIRSuiviTraitementSpecified =createAggirDto.AGGIRSuiviTraitementSpecified,
                    AGGIRTempsLibre = createAggirDto.AggirTempsLibre,
                    //AGGIRTempsLibreSpecified =createAggirDto.AGGIRTempsLibreSpecified,
                    AGGIRToilette = createAggirDto.AggirToilette,
                    //AGGIRToiletteSpecified = createAggirDto.AGGIRToiletteSpecified,
                    AGGIRTransferts = createAggirDto.AggirTransferts,
                    //AGGIRTransfertsSpecified = createAggirDto.AGGIRTransfertsSpecified,
                    AGGIRTransport = createAggirDto.AggirTransport,
                    //AGGIRTransportSpecified = createAggirDto.AGGIRTransportSpecified,
                    structureProfileId = createAggirDto.StructureProfileId,
                    //structureProfileIdSpecified = createAggirDto.structureProfileIdSpecified,

                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<int>(true, data.AGGIRGridId);
            }
            return new ActionResult<int>(false, 0, new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult UpdateAggir(int AGGIRGridId, CreateAggirDto alterAggir)
        {
            var data = DomeCallSoap.AlterAggir(new alterAGGIRDto()
            {

                DOME_header = new Service_References.R833a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.Auth.DomeHeader.Date,
                    version = AuthentificationHelper.Instance.Auth.DomeHeader.Version,
                },
                AGGIRGridId = AGGIRGridId,
                AGGIRGridIdSpecified = true,
                DOME_medAGGIRdetail = new alterAGGIRInnerDto()
                {
                    AGGIRAchats = alterAggir.AggirAchats,
                    AGGIRAlerter = alterAggir.AggirAlerter,
                    //AGGIRAchatsSpecified =alterAggir.AGGIRAchatsSpecified,
                    //AGGIRAlerterSpecified =alterAggir.AGGIRAlerterSpecified,
                    AGGIRAlimentation = alterAggir.AggirAlimentation,
                    //AGGIRAlimentationSpecified =alterAggir.AGGIRAlimentationSpecified,
                    AGGIRCode = alterAggir.AggirCode,
                    //AGGIRCodeSpecified =alterAggir.AGGIRCodeSpecified,
                    AGGIRCoherence = alterAggir.AggirCoherence,
                    //AGGIRCoherenceSpecified =alterAggir.AGGIRCoherenceSpecified,
                    AGGIRComment = alterAggir.AggirComment,
                    AGGIRCreationDate = alterAggir.AggirCreationDate,
                    //AGGIRCreationDateSpecified =alterAggir.AGGIRCreationDateSpecified,
                    AGGIRCreationProfileId = alterAggir.AggirCreationProfileId,
                    //AGGIRCreationProfileIdSpecified =alterAggir.AGGIRCreationProfileIdSpecified,
                    AGGIRCreatorEntityName = alterAggir.AggirCreatorEntityName,
                    AGGIRCreatorName = alterAggir.AggirCreatorName,
                    AGGIRCuisine = alterAggir.AggirCuisine,
                    //AGGIRCuisineSpecified =alterAggir.AGGIRCuisineSpecified,
                    AGGIRDeplacExt = alterAggir.AggirDeplacExt,
                    //AGGIRDeplacExtSpecified =alterAggir.AGGIRDeplacExtSpecified,
                    AGGIRDeplacInt = alterAggir.AggirDeplacInt,
                    //AGGIRDeplacIntSpecified =alterAggir.AGGIRDeplacIntSpecified,
                    AGGIRElimination = alterAggir.AggirElimination,
                    //AGGIREliminationSpecified =alterAggir.AGGIREliminationSpecified,
                    AGGIREvaluationDate = alterAggir.AggirEvaluationDate,
                    //AGGIREvaluationDateSpecified =alterAggir.AGGIREvaluationDateSpecified,
                    AGGIREvaluatorName = alterAggir.AggirEvaluatorName,
                    AGGIRGestion = alterAggir.AggirGestion,
                    //AGGIRGestionSpecified =alterAggir.AGGIRGestionSpecified,
                    AGGIRHabillage = alterAggir.AggirHabillage,
                    //AGGIRHabillageSpecified =alterAggir.AGGIRHabillageSpecified,
                    AGGIRMenage = alterAggir.AggirMenage,
                    //AGGIRMenageSpecified =alterAggir.AGGIRMenageSpecified,
                    AGGIROrientation = alterAggir.AggirOrientation,
                    //AGGIROrientationSpecified =alterAggir.AGGIROrientationSpecified,
                    AGGIRSuiviTraitement = alterAggir.AggirSuiviTraitement,
                    //AGGIRSuiviTraitementSpecified =alterAggir.AGGIRSuiviTraitementSpecified,
                    AGGIRTempsLibre = alterAggir.AggirTempsLibre,
                    //AGGIRTempsLibreSpecified =alterAggir.AGGIRTempsLibreSpecified,
                    AGGIRToilette = alterAggir.AggirToilette,
                    //AGGIRToiletteSpecified = alterAggir.AGGIRToiletteSpecified,
                    AGGIRTransferts = alterAggir.AggirTransferts,
                    //AGGIRTransfertsSpecified = alterAggir.AGGIRTransfertsSpecified,
                    AGGIRTransport = alterAggir.AggirTransport,
                    //AGGIRTransportSpecified = alterAggir.AGGIRTransportSpecified,
                    structureProfileId = alterAggir.StructureProfileId,
                    //structureProfileIdSpecified = alterAggir.structureProfileIdSpecified,

                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult(true);
            }
            return new ActionResult(false, new Message(MessageType.Error, data.statusErrorMessage));

        }



    }
}

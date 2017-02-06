using System;
using Dome.Client.dto.aggir;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.createPerson.basic;
using Dome.Client.dto.createPerson.result;
using Dome.Client.dto.updatePerson;
using Dome.Client.interfaces;
using Dome.DomeProxy;
using Dome.DomeProxy.soap;
using Dome.Enum;
using Dome.infrastructure;
using Dome.Service_References.R511;
using Dome.Service_References.R521;
using Dome.Service_References.R523;
using Dome.Service_References.R525;
using Dome.Service_References.R532;
using Dome.Service_References.R541b;
using Dome.Service_References.R541c;
using Dome.Service_References.R542a;
using Dome.Service_References.R830a;
using Dome.Service_References.R831a;
using Dome.Service_References.R833a;
using addNewAggirInnerDto = Dome.Service_References.R830a.addNewAggirInnerDto;
using CreatePersonInnerDto = Dome.Service_References.R511.CreatePersonInnerDto;
using domeHeaderDto = Dome.Service_References.R511.domeHeaderDto;

namespace Dome.Client
{
    public class DomeClient : IDomeClient
    {

        private DeviceType DeviceType
        {
            get { return DeviceType.LogicielMétier; }
        }

        private DomeClientSoap DomeCallSoap { get; set; }


        public int AccountId => AuthentificationHelper.OperateurProfilId;

        public int StructureProfilId => AuthentificationHelper.StructureProfilId;

        public DomeClient()
        {
            if (AuthentificationHelper.IsConnected == false)
            {
                AuthentificationHelper.Connect(Settings.Username, Settings.Password, Settings.Urlbase);
            }

            DomeCallSoap = new DomeClientSoap();
        }
        public DomeClient(string username, string password, string urlbase)
        {
            if (AuthentificationHelper.IsConnected == false)
            {
                AuthentificationHelper.Connect(username, password, urlbase);
            }

            DomeCallSoap = new DomeClientSoap();
        }

        public void Reconnect(string username, string password, string urlbase)
        {
            AuthentificationHelper.Connect(username, password, urlbase);
        }

        private ActionResult<CreatePersonResponseDto> _CreatePerson(CreatePerson createPerson)
        {
            var createPersonDto = new CreatePersonDto()
            {
                DOME_createPerson = new CreatePersonInnerDto()
                {
                    personCivilityId = (int?)createPerson.PersonCivility ?? -1,
                    personCivilityIdSpecified = createPerson.PersonCivility.HasValue,

                    personBirthDate = (DateTime?)createPerson.PersonBirthDate ?? DateTime.MinValue.Date,
                    personBirthDateSpecified = createPerson.PersonBirthDate.HasValue,

                    personAddressComp1 = createPerson.PersonAddressComp1,
                    personAddressComp2 = createPerson.PersonAddressComp2,
                    personBirthName = createPerson.PersonBirthName,
                    personCedex = createPerson.PersonCedex,
                    personCityName = createPerson.PersonCityName,
                    personCityZipCode = createPerson.PersonCityZipCode,
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
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
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
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },

                accountId = createProfil.AccountId ?? -1,
                accountIdSpecified = createProfil.AccountId.HasValue,

                personIdMetier = createProfil.PersonIdMetier,

                profileCibleType = ((int?)createProfil.ProfileCibleType) ?? -1,
                profileCibleTypeSpecified = createProfil.ProfileCibleType.HasValue,

                personSocietyRole = ((int?)createProfil.PersonSocietyRole) ?? -1,
                personSocietyRoleSpecified = createProfil.PersonSocietyRole.HasValue,

                profileParentId = createProfil.ProfileParentId ?? -1,
                profileParentIdSpecified = createProfil.ProfileParentId.HasValue,

                profileAvatar = createProfil.ProfileAvatar ?? -1,
                profileAvatarSpecified = createProfil.ProfileAvatar.HasValue,

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


            if (profile.Succeeded == false)
            {
                return new ActionResult<CreatePersonProfilResult>(profile.Succeeded, createPersonProfilResult, profile.Messages);
            }



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
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
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

        public ActionResult<authentificationResponseDto> GetAccount(int accountId)
        {

            var data = DomeCallSoap.GetProfileList(new authentificationInputDto()
            {
                accountIdSpecified = true,
                accountId = accountId,
                DOME_header = new Service_References.R541b.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<authentificationResponseDto>(true, data);
            }
            return new ActionResult<authentificationResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult<profileDetailResponseDto> GetProfile(int profileId)
        {
            var data = DomeCallSoap.ProfileDetails(new profileDetailDto()
            {
                profileId = profileId,
                profileIdSpecified = true,
                DOME_header = new Service_References.R541c.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<profileDetailResponseDto>(true, data);
            }
            return new ActionResult<profileDetailResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));

        }



        public ActionResult<CreatePersonProfilResult> CreateBeneficiaire(CreateBeneficiaire createBeneficiaire)
        {
            var beneficiaire = _CreatePersonAndProfil(createBeneficiaire);

            if (beneficiaire.Succeeded == false)
            {
                return beneficiaire;
            }

            var link = SubscriptionBeneficiaireStructure(beneficiaire.Entity.ProfileId, createBeneficiaire.ProfileStructureId);

            if (link.Succeeded == false)
            {
                return new ActionResult<CreatePersonProfilResult>(link.Succeeded, beneficiaire.Entity, link.Messages);
            }

            return beneficiaire;
        }

        public ActionResult<CreatePersonProfilResult> CreateEntourage(CreateEntourage createEntourage)
        {
            return _CreatePersonAndProfil(createEntourage);

        }

        public ActionResult<CreatePersonProfilResult> CreateIntervenantInterne(CreateIntervenantInterne createIntervenantInterne)
        {
            return _CreatePersonAndProfil(createIntervenantInterne);
        }

        public ActionResult<CreatePersonProfilResult> CreateStructure(CreateStructure createStructure)
        {
            return _CreatePersonAndProfil(createStructure);
        }

        public ActionResult<CreatePersonProfilResult> CreateIntervenantExterne(CreateIntervenantExterne createIntervenant)
        {
            return _CreatePersonAndProfil(createIntervenant);
        }

        public ActionResult<UpdatePersonResult> UpdatePerson(int accountId, UpdatePerson updatePerson)
        {
            var updatePersonDto = new UpdatePersonDto()
            {
                DOME_header = new Service_References.R542a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },
                accountId = accountId,
                accountIdSpecified = true,
                DOME_createPerson = new Service_References.R542a.CreatePersonInnerDto()
                {

                    personCivilityId = (int?)updatePerson.PersonCivility ?? -1,
                    personCivilityIdSpecified = updatePerson.PersonCivility.HasValue,

                    personBirthDate = (DateTime?)updatePerson.PersonBirthDate ?? DateTime.MinValue.Date,
                    personBirthDateSpecified = updatePerson.PersonBirthDate.HasValue,

                    personAddressComp1 = updatePerson.PersonAddressComp1,
                    personAddressComp2 = updatePerson.PersonAddressComp2,
                    personBirthName = updatePerson.PersonBirthName,
                    personCedex = updatePerson.PersonCedex,
                    personCityName = updatePerson.PersonCityName,
                    personCityZipCode = updatePerson.PersonCityZipCode,
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

            if (data.statusId == 0)
            {
                return new ActionResult<UpdatePersonResult>(true, new UpdatePersonResult(data));
            }
            return new ActionResult<UpdatePersonResult>(false, new UpdatePersonResult(data), new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult LinkIntervenantToBenef(int beneficiaireProfileId, int intervenantProfileId)
        {
            var data = DomeCallSoap.LinkIntervenantToBenef(new linkIntervenantToBenefDto()
            {
                DOME_header = new Service_References.R525.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },

                benefProfileId = beneficiaireProfileId,
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

        public ActionResult SubscriptionBeneficiaireStructure(int beneficiaireProfileId, int structureProfileId)
        {
            var data = DomeCallSoap.SubscriptionPersonStructure(new subscriptionStructureDto()
            {
                DOME_header = new Service_References.R523.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },

                profileStructureId = structureProfileId,
                profileStructureIdSpecified = true,

                profileBenefId = beneficiaireProfileId,
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
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },

                benefProfileId = beneficiareProfileId,
                benefProfileIdSpecified = true,
                DOME_medAGGIR = new addNewAggirInnerDto()
                {
                    AGGIRAchats = createAggirDto.AggirAchats ?? -1,
                    AGGIRAchatsSpecified = createAggirDto.AggirAchats.HasValue,

                    AGGIRAlerter = createAggirDto.AggirAlerter ?? -1,
                    AGGIRAlerterSpecified = createAggirDto.AggirAlerter.HasValue,

                    AGGIRAlimentation = createAggirDto.AggirAlimentation ?? -1,
                    AGGIRAlimentationSpecified = createAggirDto.AggirAlimentation.HasValue,

                    AGGIRCode = createAggirDto.AggirCode ?? -1,
                    AGGIRCodeSpecified = createAggirDto.AggirCode.HasValue,

                    AGGIRCoherence = createAggirDto.AggirCoherence ?? -1,
                    AGGIRCoherenceSpecified = createAggirDto.AggirCoherence.HasValue,

                    AGGIRComment = createAggirDto.AggirComment,

                    AGGIRCreationDate = createAggirDto.AggirCreationDate ?? DateTime.MinValue.Date,
                    AGGIRCreationDateSpecified = createAggirDto.AggirCreationDate.HasValue,

                    AGGIRCreationProfileId = createAggirDto.AggirCreationProfileId ?? -1,
                    AGGIRCreationProfileIdSpecified = createAggirDto.AggirCreationProfileId.HasValue,

                    AGGIRCreatorEntityName = createAggirDto.AggirCreatorEntityName,

                    AGGIRCreatorName = createAggirDto.AggirCreatorName,

                    AGGIRCuisine = createAggirDto.AggirCuisine ?? -1,
                    AGGIRCuisineSpecified = createAggirDto.AggirCuisine.HasValue,

                    AGGIRDeplacExt = createAggirDto.AggirDeplacExt ?? -1,
                    AGGIRDeplacExtSpecified = createAggirDto.AggirDeplacExt.HasValue,

                    AGGIRDeplacInt = createAggirDto.AggirDeplacInt ?? -1,
                    AGGIRDeplacIntSpecified = createAggirDto.AggirDeplacInt.HasValue,

                    AGGIRElimination = createAggirDto.AggirElimination ?? -1,
                    AGGIREliminationSpecified = createAggirDto.AggirElimination.HasValue,

                    AGGIREvaluationDate = createAggirDto.AggirEvaluationDate ?? DateTime.MinValue.Date,
                    AGGIREvaluationDateSpecified = createAggirDto.AggirEvaluationDate.HasValue,

                    AGGIREvaluatorName = createAggirDto.AggirEvaluatorName,

                    AGGIRGestion = createAggirDto.AggirGestion ?? -1,
                    AGGIRGestionSpecified = createAggirDto.AggirGestion.HasValue,

                    AGGIRHabillage = createAggirDto.AggirHabillage ?? -1,
                    AGGIRHabillageSpecified = createAggirDto.AggirHabillage.HasValue,

                    AGGIRMenage = createAggirDto.AggirMenage ?? -1,
                    AGGIRMenageSpecified = createAggirDto.AggirMenage.HasValue,

                    AGGIROrientation = createAggirDto.AggirOrientation ?? -1,
                    AGGIROrientationSpecified = createAggirDto.AggirOrientation.HasValue,

                    AGGIRSuiviTraitement = createAggirDto.AggirSuiviTraitement ?? -1,
                    AGGIRSuiviTraitementSpecified = createAggirDto.AggirSuiviTraitement.HasValue,

                    AGGIRTempsLibre = createAggirDto.AggirTempsLibre ?? -1,
                    AGGIRTempsLibreSpecified = createAggirDto.AggirTempsLibre.HasValue,

                    AGGIRToilette = createAggirDto.AggirToilette ?? -1,
                    AGGIRToiletteSpecified = createAggirDto.AggirToilette.HasValue,

                    AGGIRTransferts = createAggirDto.AggirTransferts ?? -1,
                    AGGIRTransfertsSpecified = createAggirDto.AggirTransferts.HasValue,

                    AGGIRTransport = createAggirDto.AggirTransport ?? -1,
                    AGGIRTransportSpecified = createAggirDto.AggirTransport.HasValue,

                    structureProfileId = createAggirDto.StructureProfileId ?? -1,
                    structureProfileIdSpecified = createAggirDto.StructureProfileId.HasValue,

                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<int>(true, data.AGGIRGridId);
            }
            return new ActionResult<int>(false, 0, new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult UpdateAggir(int AGGIRGridId, UpdateAggirDto alterAggir)
        {
            var data = DomeCallSoap.AlterAggir(new alterAGGIRDto()
            {

                DOME_header = new Service_References.R833a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },
                AGGIRGridId = AGGIRGridId,
                AGGIRGridIdSpecified = true,
                DOME_medAGGIRdetail = new alterAGGIRInnerDto()
                {
                    AGGIRAchats = alterAggir.AggirAchats ?? -1,
                    AGGIRAchatsSpecified = alterAggir.AggirAchats.HasValue,

                    AGGIRAlerter = alterAggir.AggirAlerter ?? -1,
                    AGGIRAlerterSpecified = alterAggir.AggirAlerter.HasValue,

                    AGGIRAlimentation = alterAggir.AggirAlimentation ?? -1,
                    AGGIRAlimentationSpecified = alterAggir.AggirAlimentation.HasValue,

                    AGGIRCode = alterAggir.AggirCode ?? -1,
                    AGGIRCodeSpecified = alterAggir.AggirCode.HasValue,

                    AGGIRCoherence = alterAggir.AggirCoherence ?? -1,
                    AGGIRCoherenceSpecified = alterAggir.AggirCoherence.HasValue,

                    AGGIRComment = alterAggir.AggirComment,

                    AGGIRCreationDate = alterAggir.AggirCreationDate ?? DateTime.MinValue.Date,
                    AGGIRCreationDateSpecified = alterAggir.AggirCreationDate.HasValue,

                    AGGIRCreationProfileId = alterAggir.AggirCreationProfileId ?? -1,
                    AGGIRCreationProfileIdSpecified = alterAggir.AggirCreationProfileId.HasValue,

                    AGGIRCreatorEntityName = alterAggir.AggirCreatorEntityName,

                    AGGIRCreatorName = alterAggir.AggirCreatorName,

                    AGGIRCuisine = alterAggir.AggirCuisine ?? -1,
                    AGGIRCuisineSpecified = alterAggir.AggirCuisine.HasValue,

                    AGGIRDeplacExt = alterAggir.AggirDeplacExt ?? -1,
                    AGGIRDeplacExtSpecified = alterAggir.AggirDeplacExt.HasValue,

                    AGGIRDeplacInt = alterAggir.AggirDeplacInt ?? -1,
                    AGGIRDeplacIntSpecified = alterAggir.AggirDeplacInt.HasValue,

                    AGGIRElimination = alterAggir.AggirElimination ?? -1,
                    AGGIREliminationSpecified = alterAggir.AggirElimination.HasValue,

                    AGGIREvaluationDate = alterAggir.AggirEvaluationDate ?? DateTime.MinValue.Date,
                    AGGIREvaluationDateSpecified = alterAggir.AggirEvaluationDate.HasValue,

                    AGGIREvaluatorName = alterAggir.AggirEvaluatorName,

                    AGGIRGestion = alterAggir.AggirGestion ?? -1,
                    AGGIRGestionSpecified = alterAggir.AggirGestion.HasValue,

                    AGGIRHabillage = alterAggir.AggirHabillage ?? -1,
                    AGGIRHabillageSpecified = alterAggir.AggirHabillage.HasValue,

                    AGGIRMenage = alterAggir.AggirMenage ?? -1,
                    AGGIRMenageSpecified = alterAggir.AggirMenage.HasValue,

                    AGGIROrientation = alterAggir.AggirOrientation ?? -1,
                    AGGIROrientationSpecified = alterAggir.AggirOrientation.HasValue,

                    AGGIRSuiviTraitement = alterAggir.AggirSuiviTraitement ?? -1,
                    AGGIRSuiviTraitementSpecified = alterAggir.AggirSuiviTraitement.HasValue,

                    AGGIRTempsLibre = alterAggir.AggirTempsLibre ?? -1,
                    AGGIRTempsLibreSpecified = alterAggir.AggirTempsLibre.HasValue,

                    AGGIRToilette = alterAggir.AggirToilette ?? -1,
                    AGGIRToiletteSpecified = alterAggir.AggirToilette.HasValue,

                    AGGIRTransferts = alterAggir.AggirTransferts ?? -1,
                    AGGIRTransfertsSpecified = alterAggir.AggirTransferts.HasValue,

                    AGGIRTransport = alterAggir.AggirTransport ?? -1,
                    AGGIRTransportSpecified = alterAggir.AggirTransport.HasValue,

                    structureProfileId = alterAggir.StructureProfileId ?? -1,
                    structureProfileIdSpecified = alterAggir.StructureProfileId.HasValue,

                    AGGIRArchivedDate = alterAggir.AggirArchivedDate ?? DateTime.MinValue.Date,
                    AGGIRArchivedDateSpecified = alterAggir.AggirArchivedDate.HasValue,

                    AGGIRArchivedName = alterAggir.AggirArchivedName,

                    AGGIRArchivedProfileId = alterAggir.AggirArchivedProfileId ?? -1,
                    AGGIRArchivedProfileIdSpecified = alterAggir.AggirArchivedProfileId.HasValue,


                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult(true);
            }
            return new ActionResult(false, new Message(MessageType.Error, data.statusErrorMessage));

        }


        public ActionResult<GetListAggirResult> GetListAggir(int benefProfileId)
        {
            var data = DomeCallSoap.GetListAggir(new getListAGGIRDto()
            {
                DOME_header = new Service_References.R831a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType,
                    dateSpecified = true,
                    date = AuthentificationHelper.date,
                    version = AuthentificationHelper.version,
                },
                benefProfileId = benefProfileId,
                benefProfileIdSpecified = true,
                nbHistoric = 0,
                nbHistoricSpecified = true
            });

            if (data.statusId == 0)
            {
                return new ActionResult<GetListAggirResult>(true, new GetListAggirResult(data));
            }
            return new ActionResult<GetListAggirResult>(false, new GetListAggirResult(data), new Message(MessageType.Error, data.statusErrorMessage));

        }

    }
}

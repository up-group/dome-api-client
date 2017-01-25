using Dome.Enum;
using System;
using Dome.R511;
using Dome.R521;
using Dome;
using Dome.R541b;
using Dome.R541c;

namespace Dome
{
    public class DomeCall : IDomeInterface
    {


        private DomeCallSoap DomeCallSoap { get; set; }
        public DomeCall()
        {
            DomeCallSoap = new DomeCallSoap();
        }





        public ActionResult<CreatePersonResultDTO> CreatePerson(CreatePerson createPerson)
        {
            var CreatePersonDto = new CreatePersonDto()
            {
                DOME_createPerson = new R511.CreatePersonInnerDto()
                {
                    personBirthDateSpecified = true,
                    personCivilityIdSpecified = true,

                    personAddressComp1 = createPerson.personAddressComp1,
                    personAddressComp2 = createPerson.personAddressComp2,
                    personBirthDate = createPerson.personBirthDate,
                    personBirthName = createPerson.personBirthName,
                    personCedex = createPerson.personCedex,
                    personCityName = createPerson.personCityName,
                    personCityZipCode = createPerson.personCityZipCode,
                    personCivilityId = (int)createPerson.personCivility,
                    personComment = createPerson.personComment,
                    personEmail1 = createPerson.personEmail1,
                    personEmail2 = createPerson.personEmail2,
                    personFirstName = createPerson.personFirstName,
                    personINSA = createPerson.personINSA,
                    personINSC = createPerson.personINSC,
                    personJob = createPerson.personJob,
                    personLastName = createPerson.personLastName,
                    personLieuDit = createPerson.personLieuDit,
                    personMobilePhoneNumber = createPerson.personMobilePhoneNumber,
                    personNIR = createPerson.personNIR,
                    personPhoneNumber = createPerson.personPhoneNumber,
                    personPostBox = createPerson.personPostBox,
                    personRoadName = createPerson.personRoadName,
                    personRoadNumber = createPerson.personRoadNumber,
                    personRoadType = createPerson.personRoadType,
                    personRPPS = createPerson.personRPPS,
                    specialCriteria = createPerson.specialCriteria,
                },
                DOME_header = new R511.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            };

            var createPersonDomeResult = DomeCallSoap.createPerson(CreatePersonDto);

            if (createPersonDomeResult.statusId == 0)
            {
                return new ActionResult<CreatePersonResultDTO>(true, new CreatePersonResultDTO(createPersonDomeResult));
            }
            return new ActionResult<CreatePersonResultDTO>(false, new CreatePersonResultDTO(createPersonDomeResult), new Message(MessageType.Error, createPersonDomeResult.statusErrorMessage));
        }

        public ActionResult<CreateProfileResultDTO> CreateProfile(CreateProfile createProfil)
        {
            var createProfileDto = new createProfileDto()
            {
                DOME_header = new R521.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                },

                accountId = createProfil.accountId.Value,
                accountIdSpecified = true,

                personIdMetier = createProfil.personIdMetier,

                profileCibleType = (int)Profile.Beneficiaire,
                profileCibleTypeSpecified = true,

                personSocietyRole = (int)createProfil.personSocietyRole,
                personSocietyRoleSpecified = false,


                profileParentId = createProfil.profileParentId,
                profileParentIdSpecified = false,


                profileAvatar = createProfil.profileAvatar,
                profileAvatarSpecified = true,


                prestationListId = createProfil.prestationListId,


                profileSectoring = createProfil.profileSectoring,

                profileSpecialCriteria = createProfil.profileSpecialCriteria
            };


            var createProfileDomeResult = DomeCallSoap.createProfile(createProfileDto);

            if (createProfileDomeResult.statusId == 0)
            {
                return new ActionResult<CreateProfileResultDTO>(true, new CreateProfileResultDTO(createProfileDomeResult));
            }
            return new ActionResult<CreateProfileResultDTO>(false, new CreateProfileResultDTO(createProfileDomeResult), new Message(MessageType.Error, createProfileDomeResult.statusErrorMessage));
        }






        private ActionResult<CreateProfileResultDTO> _CreatePersonAndProfil(CreatePerson createPerson, CreateProfile createPatient)
        {
            if (createPatient.accountId.HasValue == false)
            {
                var person = this.CreatePerson(createPerson);
                if (person.Succeeded == false)
                {
                    return new ActionResult<CreateProfileResultDTO>(false, null, person.Messages);
                }
                createPatient.accountId = person.Entity.accountId;
            }
            return CreateProfile(createPatient);
        }





        public ActionResult<CreateProfileResultDTO> CreatePatient(CreatePerson createPerson, CreatePatient createPatient)
        {
            return _CreatePersonAndProfil(createPerson, createPatient);
        }

        public ActionResult<CreateProfileResultDTO> CreateEntouge(CreatePerson createPerson, CreateEntourage createEntourage)
        {
            return _CreatePersonAndProfil(createPerson, createEntourage);

        }

        public ActionResult<CreateProfileResultDTO> CreateSalarie(CreatePerson createPerson, CreateSalarie createSalarie)
        {
            return _CreatePersonAndProfil(createPerson, createSalarie);
        }

        public ActionResult<CreateProfileResultDTO> CreateStructure(CreatePerson createPerson, CreateStructure createStructure)
        {
            return _CreatePersonAndProfil(createPerson, createStructure);

        }

        public ActionResult<CreateProfileResultDTO> CreateIntervenant(CreatePerson createPerson, CreateIntervenant createIntervenant)
        {
            return _CreatePersonAndProfil(createPerson, createIntervenant);
        }











        public ActionResult<CreateProfileResultDTO> CreatePatient(CreatePatient createPatient)
        {
            return CreateProfile(createPatient);
        }

        public ActionResult<CreateProfileResultDTO> CreateEntouge(CreateEntourage createEntourage)
        {
            return CreateProfile(createEntourage);
        }

        public ActionResult<CreateProfileResultDTO> CreateSalarie(CreateSalarie createSalarie)
        {
            return CreateProfile(createSalarie);
        }

        public ActionResult<CreateProfileResultDTO> CreateStructure(CreateStructure createStructure)
        {
            return CreateProfile(createStructure);
        }

        public ActionResult<CreateProfileResultDTO> CreateIntervenant(CreateIntervenant createIntervenant)
        {
            return CreateProfile(createIntervenant);
        }





        public ActionResult<UpdatePersonResultDTO> UpdatePerson(int accountId, CreatePerson createPerson)
        {
            var UpdatePersonDto = new R542a.UpdatePersonDto()
            {
                DOME_header = new R542a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                },


                accountId = accountId,
                accountIdSpecified = true,
                DOME_createPerson = new R542a.CreatePersonInnerDto()
                {
                    personAddressComp1 = createPerson.personAddressComp1,
                    personAddressComp2 = createPerson.personAddressComp2,
                    personBirthDate = createPerson.personBirthDate,
                    //personBirthDateSpecified = createPerson.personBirthDateSpecified,
                    personBirthName = createPerson.personBirthName,
                    personCedex = createPerson.personCedex,
                    personCityName = createPerson.personCityName,
                    personCityZipCode = createPerson.personCityZipCode,
                    personCivilityId = (int)createPerson.personCivility,
                    //personCivilityIdSpecified = createPerson.personCivilityIdSpecified,
                    personComment = createPerson.personComment,
                    personEmail1 = createPerson.personEmail1,
                    personEmail2 = createPerson.personEmail2,
                    personFirstName = createPerson.personFirstName,
                    personINSA = createPerson.personINSA,
                    personINSC = createPerson.personINSC,
                    personJob = createPerson.personJob,
                    personLastName = createPerson.personLastName,
                    personLieuDit = createPerson.personLieuDit,
                    personMobilePhoneNumber = createPerson.personMobilePhoneNumber,
                    personNIR = createPerson.personNIR,
                    personPhoneNumber = createPerson.personPhoneNumber,
                    personPostBox = createPerson.personPostBox,
                    personRoadName = createPerson.personRoadName,
                    personRoadNumber = createPerson.personRoadNumber,
                    personRoadType = createPerson.personRoadType,
                    personRPPS = createPerson.personRPPS,
                    specialCriteria = createPerson.specialCriteria,


                }

            };
            var data = DomeCallSoap.updatePerson(UpdatePersonDto);

            //var aaa = testREs<ActionResult<UpdatePersonResultDTO>>(data, new UpdatePersonResultDTO(data));

            if (data.statusId == 0)
            {
                return new ActionResult<UpdatePersonResultDTO>(true, new UpdatePersonResultDTO(data));
            }
            return new ActionResult<UpdatePersonResultDTO>(false, new UpdatePersonResultDTO(data), new Message(MessageType.Error, data.statusErrorMessage));

        }


        //public T testREs<T>(returnData data , object d)
        //{

        //    return null;
        //}

        public interface returnData
        {
            int statusId { get; }
            string statusErrorMessage { get; }

        }

        public ActionResult LinkIntervenantToBenef(int patientProfileId, int intervenantProfileId)
        {
            var data = DomeCallSoap.linkIntervenantToBenef(new R525.linkIntervenantToBenefDto()
            {
                DOME_header = new R525.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
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
            var data = DomeCallSoap.subscriptionPersonStructure(new R523.subscriptionStructureDto()
            {
                DOME_header = new R523.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
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





        public ActionResult<int?> CreateAggir(int beneficiareProfileId, CreateAggirDto createAggirDto)
        {
            var data = DomeCallSoap.addNewAGGIR(new R830a.addNewAGGIRDto()
            {

                DOME_header = new R830a.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                },

                benefProfileId = beneficiareProfileId,
                benefProfileIdSpecified = true,
                DOME_medAGGIR = new R830a.addNewAggirInnerDto()
                {
                    AGGIRAchats = createAggirDto.AGGIRAchats,
                    AGGIRAlerter = createAggirDto.AGGIRAlerter,
                    //AGGIRAchatsSpecified =createAggirDto.AGGIRAchatsSpecified,
                    //AGGIRAlerterSpecified =createAggirDto.AGGIRAlerterSpecified,
                    AGGIRAlimentation = createAggirDto.AGGIRAlimentation,
                    //AGGIRAlimentationSpecified =createAggirDto.AGGIRAlimentationSpecified,
                    AGGIRCode = createAggirDto.AGGIRCode,
                    //AGGIRCodeSpecified =createAggirDto.AGGIRCodeSpecified,
                    AGGIRCoherence = createAggirDto.AGGIRCoherence,
                    //AGGIRCoherenceSpecified =createAggirDto.AGGIRCoherenceSpecified,
                    AGGIRComment = createAggirDto.AGGIRComment,
                    AGGIRCreationDate = createAggirDto.AGGIRCreationDate,
                    //AGGIRCreationDateSpecified =createAggirDto.AGGIRCreationDateSpecified,
                    AGGIRCreationProfileId = createAggirDto.AGGIRCreationProfileId,
                    //AGGIRCreationProfileIdSpecified =createAggirDto.AGGIRCreationProfileIdSpecified,
                    AGGIRCreatorEntityName = createAggirDto.AGGIRCreatorEntityName,
                    AGGIRCreatorName = createAggirDto.AGGIRCreatorName,
                    AGGIRCuisine = createAggirDto.AGGIRCuisine,
                    //AGGIRCuisineSpecified =createAggirDto.AGGIRCuisineSpecified,
                    AGGIRDeplacExt = createAggirDto.AGGIRDeplacExt,
                    //AGGIRDeplacExtSpecified =createAggirDto.AGGIRDeplacExtSpecified,
                    AGGIRDeplacInt = createAggirDto.AGGIRDeplacInt,
                    //AGGIRDeplacIntSpecified =createAggirDto.AGGIRDeplacIntSpecified,
                    AGGIRElimination = createAggirDto.AGGIRElimination,
                    //AGGIREliminationSpecified =createAggirDto.AGGIREliminationSpecified,
                    AGGIREvaluationDate = createAggirDto.AGGIREvaluationDate,
                    //AGGIREvaluationDateSpecified =createAggirDto.AGGIREvaluationDateSpecified,
                    AGGIREvaluatorName = createAggirDto.AGGIREvaluatorName,
                    AGGIRGestion = createAggirDto.AGGIRGestion,
                    //AGGIRGestionSpecified =createAggirDto.AGGIRGestionSpecified,
                    AGGIRHabillage = createAggirDto.AGGIRHabillage,
                    //AGGIRHabillageSpecified =createAggirDto.AGGIRHabillageSpecified,
                    AGGIRMenage = createAggirDto.AGGIRMenage,
                    //AGGIRMenageSpecified =createAggirDto.AGGIRMenageSpecified,
                    AGGIROrientation = createAggirDto.AGGIROrientation,
                    //AGGIROrientationSpecified =createAggirDto.AGGIROrientationSpecified,
                    AGGIRSuiviTraitement = createAggirDto.AGGIRSuiviTraitement,
                    //AGGIRSuiviTraitementSpecified =createAggirDto.AGGIRSuiviTraitementSpecified,
                    AGGIRTempsLibre = createAggirDto.AGGIRTempsLibre,
                    //AGGIRTempsLibreSpecified =createAggirDto.AGGIRTempsLibreSpecified,
                    AGGIRToilette = createAggirDto.AGGIRToilette,
                    //AGGIRToiletteSpecified = createAggirDto.AGGIRToiletteSpecified,
                    AGGIRTransferts = createAggirDto.AGGIRTransferts,
                    //AGGIRTransfertsSpecified = createAggirDto.AGGIRTransfertsSpecified,
                    AGGIRTransport = createAggirDto.AGGIRTransport,
                    //AGGIRTransportSpecified = createAggirDto.AGGIRTransportSpecified,
                    structureProfileId = createAggirDto.structureProfileId,
                    //structureProfileIdSpecified = createAggirDto.structureProfileIdSpecified,

                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<int?>(true, data.AGGIRGridId);
            }
            return new ActionResult<int?>(false, null, new Message(MessageType.Error, data.statusErrorMessage));

        }

        public ActionResult UpdateAggir(CreateAggirDto createPatientDto)
        {
            throw new NotImplementedException();
        }

        public ActionResult<profileDetailResponseDto> GetProfile(int profileId)
        {
            var data = DomeCallSoap.profileDetails(new profileDetailDto()
            {
                profileId = profileId,
                profileIdSpecified = true,
                DOME_header = new R541c.domeHeaderDto()
                {
                    deviceTypeSpecified = true,
                    deviceType = 5,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
                }
            });

            if (data.statusId == 0)
            {
                return new ActionResult<profileDetailResponseDto>(true, data);
            }
            return new ActionResult<profileDetailResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));


        }

        public ActionResult<authentificationResponseDto> GetAccount(int accountId)
        {

            var data = DomeCallSoap.GetProfileList(new authentificationInputDto()
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
            });

            if (data.statusId == 0)
            {
                return new ActionResult<authentificationResponseDto>(true, data);
            }
            return new ActionResult<authentificationResponseDto>(false, data, new Message(MessageType.Error, data.statusErrorMessage));



        }

        public ActionResult SelectProfil(int profileId)
        {
            var data = DomeCallSoap.selectProfile(new Dome.R532.selectProfileDto()
            {
                DOME_header = new Dome.R532.domeHeaderDto()
                {
                    langue = "fr",
                    deviceTypeSpecified = true,
                    deviceType = (int)DeviceType.LogicielMétier,
                    dateSpecified = true,
                    date = AuthentificationHelper.Instance.auth.DOME_header.date.Value,
                    version = AuthentificationHelper.Instance.auth.DOME_header.version,
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
    }
}

using Dome.Enum;
using System;
using Dome.R511;
using Dome.R521;

namespace Dome
{
    public class DomeCall : IDomeInterface
    {


        private DomeCallSoap DomeCallSoap { get; set; }
        public DomeCall()
        {
            DomeCallSoap = new DomeCallSoap();
        }

        public CreatePersonResultDTO CreatePerson(ICreatePerson createPerson)
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

            return new CreatePersonResultDTO(createPersonDomeResult);
        }

        public CreateProfileResultDTO CreateProfile(ICreateProfile createProfil)
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

            return new CreateProfileResultDTO(createProfileDomeResult);


        }






        private CreateProfileResultDTO _CreatePersonAndProfil(CreatePerson createPerson, ICreateProfile createPatient)
        {
            if (createPatient.accountId.HasValue == false)
            {
                var person = this.CreatePerson(createPerson);
                createPatient.accountId = person.accountId;
            }

            var profile = this.CreateProfile(createPatient);
            return profile;

        }





        public CreateProfileResultDTO CreatePatient(CreatePerson createPerson, CreatePatient createPatient)
        {
            return _CreatePersonAndProfil(createPerson, createPatient);
        }

        public CreateProfileResultDTO CreateEntouge(CreatePerson createPerson, CreateEntourage createEntourage)
        {
            return _CreatePersonAndProfil(createPerson, createEntourage);

        }

        public CreateProfileResultDTO CreateSalarie(CreatePerson createPerson, CreateSalarie createSalarie)
        {
            return _CreatePersonAndProfil(createPerson, createSalarie);
        }

        public CreateProfileResultDTO CreateStructure(CreatePerson createPerson, CreateStructure createStructure)
        {
            return _CreatePersonAndProfil(createPerson, createStructure);

        }

        public CreateProfileResultDTO CreateIntervenant(CreatePerson createPerson, CreateIntervenant createIntervenant)
        {
            return _CreatePersonAndProfil(createPerson, createIntervenant);
        }











        public CreateProfileResultDTO CreatePatient(CreatePatient createPatient)
        {
            return CreateProfile(createPatient);
        }

        public CreateProfileResultDTO CreateEntouge(CreateEntourage createEntourage)
        {
            return CreateProfile(createEntourage);
        }

        public CreateProfileResultDTO CreateSalarie(CreateSalarie createSalarie)
        {
            return CreateProfile(createSalarie);
        }

        public CreateProfileResultDTO CreateStructure(CreateStructure createStructure)
        {
            return CreateProfile(createStructure);
        }

        public CreateProfileResultDTO CreateIntervenant(CreateIntervenant createIntervenant)
        {
            return CreateProfile(createIntervenant);
        }













        public UpdatePersonResult UpdatePatient(UpdatePersonn createPerson)
        {
            throw new NotImplementedException();
        }

        public UpdatePersonResult UpdateEntourage(UpdatePersonn createPerson)
        {
            throw new NotImplementedException();
        }

        public UpdatePersonResult UpdateSalarie(UpdatePersonn createPerson)
        {
            throw new NotImplementedException();
        }

        public UpdatePersonResult UpdateStructure(UpdatePersonn createPerson)
        {
            throw new NotImplementedException();
        }

        public UpdatePersonResult UpdateIntervenant(UpdatePersonn createPerson)
        {
            throw new NotImplementedException();
        }

        public int? CreateAggir(CreateAggirDto createPatientDto)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAggir(CreateAggirDto createPatientDto)
        {
            throw new NotImplementedException();
        }

    }
}

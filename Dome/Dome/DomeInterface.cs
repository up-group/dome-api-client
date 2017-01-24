using Dome.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dome.R511;
using Dome.R521;
using Dome.R542a;

namespace Dome
{


    public interface ICreatePerson
    {
        Civilite personCivility { get; set; }

        string personLastName { get; set; }

        string personFirstName { get; set; }

        string personPhoneNumber { get; set; }

        string personMobilePhoneNumber { get; set; }

        string personEmail1 { get; set; }

        string personEmail2 { get; set; }

        DateTime personBirthDate { get; set; }

        string personRoadType { get; set; }

        string personRoadName { get; set; }

        string personRoadNumber { get; set; }

        string personPostBox { get; set; }

        string personLieuDit { get; set; }

        string personAddressComp1 { get; set; }

        string personAddressComp2 { get; set; }

        string personCedex { get; set; }

        string personCityZipCode { get; set; }

        string personCityName { get; set; }

        string personBirthName { get; set; }

        string personINSC { get; set; }

        string personINSA { get; set; }

        string personRPPS { get; set; }

        string personNIR { get; set; }

        string personJob { get; set; }

        string specialCriteria { get; set; }

        string personComment { get; set; }

    }

    public interface ICreatePersonResultDTO
    {
        int personId { get; set; }
        string login { get; set; }
        int accountId { get; set; }
        string password { get; set; }
        int profileId { get; set; }
        duplicatePersonDto[] DOME_createPersonList { get; set; }
    }

    public interface ICreateProfile
    {
        int? accountId { get; set; }

        bool accountIdFieldSpecified { get; set; }

        Profile profileCibleType { get; set; }

        bool profileCibleTypeFieldSpecified { get; set; }

        int profileParentId { get; set; }

        bool profileParentIdFieldSpecified { get; set; }

        int profileAvatar { get; set; }

        bool profileAvatarFieldSpecified { get; set; }

        SocietyRole personSocietyRole { get; set; }

        bool personSocietyRoleFieldSpecified { get; set; }

        string personIdMetier { get; set; }

        string prestationListId { get; set; }

        string profileSpecialCriteria { get; set; }

        string profileSectoring { get; set; }
    }

    public interface ICreateProfileResultDTO
    {
        int profileId { get; set; }
    }





    public class CreatePersonResultDTO : ICreatePersonResultDTO
    {
        public CreatePersonResultDTO(CreatePersonResponseDto createPersonDomeResult)
        {
            this.personId = createPersonDomeResult.personId;
            this.login = createPersonDomeResult.login;
            this.password = createPersonDomeResult.password;
            this.accountId = createPersonDomeResult.accountId;
            this.DOME_createPersonList = createPersonDomeResult.DOME_createPersonList.Select(x => new duplicatePersonDto(x)).ToArray();

        }

        public int personId { get; set; }
        public string login { get; set; }
        public int accountId { get; set; }
        public string password { get; set; }
        public int profileId { get; set; }
        public duplicatePersonDto[] DOME_createPersonList { get; set; }

    }


    public class duplicatePersonDto
    {
        public duplicatePersonDto(R542a.duplicatePersonDto duplicatePersonDto)
        {
            this.accountId = duplicatePersonDto.accountId;
            this.accountIdSpecified = duplicatePersonDto.accountIdSpecified;
            this.personFirstName = duplicatePersonDto.personLastName;
            this.personLastName = duplicatePersonDto.personLastName;
            this.personEmail = duplicatePersonDto.personEmail;
            this.login = duplicatePersonDto.login;
            this.password = duplicatePersonDto.password;
        }

        public duplicatePersonDto(R511.duplicatePersonDto x)
        {
            this.accountId = x.accountId;
            this.accountIdSpecified = x.accountIdSpecified;
            this.personFirstName = x.personLastName;
            this.personLastName = x.personLastName;
            this.personEmail = x.personEmail;
            this.login = x.login;
            this.password = x.password;
        }

        public int accountId;
        public bool accountIdSpecified;
        public string personFirstName;
        public string personLastName;
        public string personEmail;
        public string login;
        public string password;
        private R511.duplicatePersonDto x;
    }

    public class UpdatePersonResultDTO
    {

        public UpdatePersonResultDTO(UpdatePersonResponseDto updatePersonResponseDto)
        {
            this.DOME_createPersonListField = updatePersonResponseDto.DOME_createPersonList.Select(x => new duplicatePersonDto(x)).ToArray();
        }

        public duplicatePersonDto[] DOME_createPersonListField;

    }




    public class CreateProfileResultDTO : ICreateProfileResultDTO
    {

        public CreateProfileResultDTO(createProfileResponseDto createProfileDomeResult)
        {
            this.profileId = createProfileDomeResult.profileId;
            //this.profileId = createProfileDomeResult.;
        }

        public int profileId { get; set; }
    }





    public class CreatePerson : ICreatePerson
    {


        public Civilite personCivility { get; set; }

        public string personLastName { get; set; }

        public string personFirstName { get; set; }

        public string personPhoneNumber { get; set; }

        public string personMobilePhoneNumber { get; set; }

        public string personEmail1 { get; set; }

        public string personEmail2 { get; set; }

        public DateTime personBirthDate { get; set; }

        public string personRoadType { get; set; }

        public string personRoadName { get; set; }

        public string personRoadNumber { get; set; }

        public string personPostBox { get; set; }

        public string personLieuDit { get; set; }

        public string personAddressComp1 { get; set; }

        public string personAddressComp2 { get; set; }

        public string personCedex { get; set; }

        public string personCityZipCode { get; set; }

        public string personCityName { get; set; }

        public string personBirthName { get; set; }

        public string personINSC { get; set; }

        public string personINSA { get; set; }

        public string personRPPS { get; set; }

        public string personNIR { get; set; }

        public string personJob { get; set; }

        public string specialCriteria { get; set; }

        public string personComment { get; set; }


    }

    public class CreateProfile : ICreateProfile
    {
        public CreateProfile(Profile profileCibleType)
        {
            this.profileCibleType = profileCibleType;
        }


        public int? accountId { get; set; }

        public bool accountIdFieldSpecified { get; set; }

        public virtual Profile profileCibleType { get; set; }

        public bool profileCibleTypeFieldSpecified { get; set; }

        public int profileParentId { get; set; }

        public bool profileParentIdFieldSpecified { get; set; }

        public int profileAvatar { get; set; }

        public bool profileAvatarFieldSpecified { get; set; }

        public virtual SocietyRole personSocietyRole { get; set; }

        public bool personSocietyRoleFieldSpecified { get; set; }

        public string personIdMetier { get; set; }

        public string prestationListId { get; set; }

        public string profileSpecialCriteria { get; set; }

        public string profileSectoring { get; set; }
    }



    public class CreatePatient : CreateProfile
    {
        public CreatePatient(Profile profileCibleType) : base(profileCibleType)
        {
        }

        public override Profile profileCibleType { get { return Profile.Beneficiaire; } }
    }

    public class CreateEntourage : CreateProfile
    {
        public CreateEntourage(Profile profileCibleType) : base(profileCibleType)
        {
        }

        public override Profile profileCibleType { get { return Profile.Proche; } }
    }



    public class CreateStructure : CreateProfile
    {
        public CreateStructure(Profile profileCibleType) : base(profileCibleType)
        {
        }

        public override Profile profileCibleType { get { return Profile.StructureMedicale; } }
    }

    public class CreateSalarie : CreateProfile
    {
        public CreateSalarie(Profile profileCibleType) : base(profileCibleType)
        {
            if (profileCibleType != Profile.PersonnelMedical &&
                profileCibleType != Profile.PersonnelNonMedical &&
                profileCibleType != Profile.PersonnelParaMedical)
            {
                throw new Exception();
            }


        }

        public override SocietyRole personSocietyRole { get { return SocietyRole.IntervenantInterne; } }
    }

    public class CreateIntervenant : CreateProfile
    {

        public CreateIntervenant(Profile profileCibleType) : base(profileCibleType)
        {
            if (profileCibleType != Profile.PersonnelMedical &&
                profileCibleType != Profile.PersonnelNonMedical &&
                profileCibleType != Profile.PersonnelParaMedical)
            {
                throw new Exception();
            }
        }

        public override SocietyRole personSocietyRole { get { return SocietyRole.IntervenantExterne; } }
    }



    public class UpdatePersonn
    {
        public int accountId { get; set; }


        public int personCivilityId { get; set; }

        public string personLastName { get; set; }
        public string personFirstName { get; set; }

        public string personPhoneNumber { get; set; }

        public string personMobilePhoneNumber { get; set; }

        public string personEmail1 { get; set; }

        public string personEmail2 { get; set; }

        public System.DateTime personBirthDate { get; set; }

        public string personRoadType { get; set; }

        public string personRoadName { get; set; }

        public string personRoadNumber { get; set; }

        public string personPostBox { get; set; }

        public string personLieuDit { get; set; }

        public string personAddressComp1 { get; set; }

        public string personAddressComp2 { get; set; }

        public string personCedex { get; set; }

        public string personCityZipCode { get; set; }

        public string personCityName { get; set; }

        public string personBirthName { get; set; }

        public string personINSC { get; set; }

        public string personINSA { get; set; }

        public string personRPPS { get; set; }

        public string personNIR { get; set; }

        public string personJob { get; set; }

        public string specialCriteria { get; set; }

        public string personComment { get; set; }
    }

    public class UpdatePersonResult
    {

        public duplicatePersonDto[] dOME_createPersonList { get; set; }
    }


    public class CreateAggirDto
    {

        public int structureProfileId { get; set; }

        public DateTime AGGIREvaluationDate { get; set; }

        public int AGGIRCreationProfileId { get; set; }

        public string AGGIRCreatorName { get; set; }

        public DateTime AGGIRCreationDate { get; set; }

        public string AGGIRCreatorEntityName { get; set; }

        public string AGGIREvaluatorName { get; set; }

        public int AGGIRCode { get; set; }

        public int AGGIRCoherence { get; set; }

        public int AGGIROrientation { get; set; }

        public int AGGIRToilette { get; set; }

        public int AGGIRHabillage { get; set; }

        public int AGGIRAlimentation { get; set; }

        public int AGGIRElimination { get; set; }

        public int AGGIRTransferts { get; set; }

        public int AGGIRDeplacInt { get; set; }

        public int AGGIRDeplacExt { get; set; }

        public int AGGIRAlerter { get; set; }

        public int AGGIRGestion { get; set; }

        public int AGGIRCuisine { get; set; }

        public int AGGIRMenage { get; set; }

        public int AGGIRTransport { get; set; }

        public int AGGIRSuiviTraitement { get; set; }

        public int AGGIRTempsLibre { get; set; }

        public int AGGIRAchats { get; set; }

        public string AGGIRComment { get; set; }

    }

    public class UpdateAggirDto
    {
        int aGGIRGridIdField;
        int aGGIRArchivedProfileIdField;


        string aGGIRArchivedNameField;

        System.DateTime aGGIRArchivedDateField;




        int structureProfileIdField;

        System.DateTime aGGIREvaluationDateField;

        int aGGIRCreationProfileIdField;

        string aGGIRCreatorNameField;

        System.DateTime aGGIRCreationDateField;

        string aGGIRCreatorEntityNameField;

        string aGGIREvaluatorNameField;

        int aGGIRCodeField;


        int aGGIRCoherenceField;


        int aGGIROrientationField;


        int aGGIRToiletteField;


        int aGGIRHabillageField;


        int aGGIRAlimentationField;


        int aGGIREliminationField;


        int aGGIRTransfertsField;


        int aGGIRDeplacIntField;


        int aGGIRDeplacExtField;


        int aGGIRAlerterField;


        int aGGIRGestionField;


        int aGGIRCuisineField;


        int aGGIRMenageField;


        int aGGIRTransportField;


        int aGGIRSuiviTraitementField;


        int aGGIRTempsLibreField;


        int aGGIRAchatsField;


        string aGGIRCommentField;

    }

    public interface IDomeInterface
    {
        ActionResult<CreatePersonResultDTO> CreatePerson(ICreatePerson createPerson);
        ActionResult<CreateProfileResultDTO> CreateProfile(ICreateProfile createProfil);


        ActionResult<CreateProfileResultDTO> CreatePatient(CreatePerson createPerson, CreatePatient createPatient);
        ActionResult<CreateProfileResultDTO> CreateEntouge(CreatePerson createPerson, CreateEntourage createEntourage);
        ActionResult<CreateProfileResultDTO> CreateSalarie(CreatePerson createPerson, CreateSalarie createSalarie);
        ActionResult<CreateProfileResultDTO> CreateStructure(CreatePerson createPerson, CreateStructure createStructure);
        ActionResult<CreateProfileResultDTO> CreateIntervenant(CreatePerson createPerson, CreateIntervenant createIntervenant);


        ActionResult<CreateProfileResultDTO> CreatePatient(CreatePatient createPatient);
        ActionResult<CreateProfileResultDTO> CreateEntouge(CreateEntourage createEntourage);
        ActionResult<CreateProfileResultDTO> CreateSalarie(CreateSalarie createSalarie);
        ActionResult<CreateProfileResultDTO> CreateStructure(CreateStructure createStructure);
        ActionResult<CreateProfileResultDTO> CreateIntervenant(CreateIntervenant createIntervenant);

        ActionResult<UpdatePersonResultDTO> UpdatePerson(int accountId, CreatePerson createPerson);

        ActionResult LinkIntervenantToBenef(int patientProfileId, int intervenantProfileId);
        ActionResult SubscriptionPersonStructure(int patientProfileId, int structureProfileId);


        ActionResult<int?> CreateAggir(int ProfileId, CreateAggirDto createAggirDto);
        ActionResult UpdateAggir(CreateAggirDto createAggirDto);


    }

}

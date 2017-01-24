using Dome.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dome.R511;
using Dome.R521;

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
            //this.DOME_createPersonList = createPersonDomeResult.DOME_createPersonList;

        }

        public int personId { get; set; }
        public string login { get; set; }
        public int accountId { get; set; }
        public string password { get; set; }
        public int profileId { get; set; }
        public duplicatePersonDto[] DOME_createPersonList { get; set; }

    }

    public partial class duplicatePersonDto
    {

        public int accountId { get; set; }

        public string personFirstName { get; set; }

        public string personLastName { get; set; }

        public string personEmail { get; set; }

        public string login { get; set; }

        public string password { get; set; }
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

        public int benefProfileId { get; set; }

        public int structureProfileId { get; set; }

        public System.DateTime aGGIREvaluationDate { get; set; }

        public int aGGIRCreationProfileId { get; set; }

        public string aGGIRCreatorName { get; set; }

        public System.DateTime aGGIRCreationDate { get; set; }

        public string aGGIRCreatorEntityName { get; set; }

        public string aGGIREvaluatorName { get; set; }

        public int aGGIRCode { get; set; }

        public int aGGIRCoherence { get; set; }

        public int aGGIROrientation { get; set; }

        public int aGGIRToilette { get; set; }

        public int aGGIRHabillage { get; set; }

        public int aGGIRAlimentation { get; set; }

        public int aGGIRElimination { get; set; }

        public int aGGIRTransferts { get; set; }

        public int aGGIRDeplacInt { get; set; }

        public int aGGIRDeplacExt { get; set; }

        public int aGGIRAlerter { get; set; }

        public int aGGIRGestion { get; set; }

        public int aGGIRCuisine { get; set; }

        public int aGGIRMenage { get; set; }

        public int aGGIRTransport { get; set; }

        public int aGGIRSuiviTraitement { get; set; }

        public int aGGIRTempsLibre { get; set; }

        public int aGGIRAchats { get; set; }

        public string aGGIRComment { get; set; }

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
        CreatePersonResultDTO CreatePerson(ICreatePerson createPerson);
        CreateProfileResultDTO CreateProfile(ICreateProfile createProfil);


        CreateProfileResultDTO CreatePatient(CreatePerson createPerson, CreatePatient createPatient);
        CreateProfileResultDTO CreateEntouge(CreatePerson createPerson, CreateEntourage createEntourage);
        CreateProfileResultDTO CreateSalarie(CreatePerson createPerson, CreateSalarie createSalarie);
        CreateProfileResultDTO CreateStructure(CreatePerson createPerson, CreateStructure createStructure);
        CreateProfileResultDTO CreateIntervenant(CreatePerson createPerson, CreateIntervenant createIntervenant);


        CreateProfileResultDTO CreatePatient(CreatePatient createPatient);
        CreateProfileResultDTO CreateEntouge(CreateEntourage createEntourage);
        CreateProfileResultDTO CreateSalarie(CreateSalarie createSalarie);
        CreateProfileResultDTO CreateStructure(CreateStructure createStructure);
        CreateProfileResultDTO CreateIntervenant(CreateIntervenant createIntervenant);


        UpdatePersonResult UpdatePatient(UpdatePersonn createPerson);
        UpdatePersonResult UpdateEntourage(UpdatePersonn createPerson);
        UpdatePersonResult UpdateSalarie(UpdatePersonn createPerson);
        UpdatePersonResult UpdateStructure(UpdatePersonn createPerson);
        UpdatePersonResult UpdateIntervenant(UpdatePersonn createPerson);




        int? CreateAggir(CreateAggirDto createPatientDto);
        bool UpdateAggir(CreateAggirDto createPatientDto);


    }

}

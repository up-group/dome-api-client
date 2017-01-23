using Dome.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome
{

    public class createPersonResultDTO
    {
        private int personIdField;

        private string loginField;

        private int accountIdField;
        private string passwordField;
        private int profileIdField;
        private duplicatePersonDto[] dOME_createPersonListField;

    }

    public partial class duplicatePersonDto
    {

        private int accountIdField;

        private string personFirstNameField;

        private string personLastNameField;

        private string personEmailField;

        private string loginField;

        private string passwordField;
    }


    public class createPerson
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








        int accountId { get; set; }


        //Profile profileCibleType { get; set; }

        //Profile? profileParentId { get; set; }

        int? profileAvatar { get; set; }

        int? personSocietyRole { get; set; }

        string personIdMetier { get; set; }

        string prestationListId { get; set; }

        string profileSpecialCriteria { get; set; }

        string profileSectoring { get; set; }



    }

    public class UpdatePersonn
    {
        int accountIdField;


        int personCivilityIdField;

        string personLastNameField;

        string personFirstNameField;

        string personPhoneNumberField;

        string personMobilePhoneNumberField;

        string personEmail1Field;

        string personEmail2Field;

        System.DateTime personBirthDateField;

        string personRoadTypeField;

        string personRoadNameField;

        string personRoadNumberField;

        string personPostBoxField;

        string personLieuDitField;

        string personAddressComp1Field;

        string personAddressComp2Field;

        string personCedexField;

        string personCityZipCodeField;

        string personCityNameField;

        string personBirthNameField;

        string personINSCField;

        string personINSAField;

        string personRPPSField;

        string personNIRField;

        string personJobField;

        string specialCriteriaField;

        string personCommentField;
    }

    public class UpdatePersonResult
    {

        private duplicatePersonDto[] dOME_createPersonListField;
    }


    public class CreateAggirDto
    {

        int benefProfileIdField;

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

    public interface DomeInterface
    {
        createPersonResultDTO CreatePatient(createPerson createPerson);
        UpdatePersonResult UpdatePatient(UpdatePersonn createPerson);

        createPersonResultDTO CreateEntouge(createPerson createPerson);
        UpdatePersonResult UpdateEntourage(UpdatePersonn createPerson);

        createPersonResultDTO CreateSalarie(createPerson createPerson);
        UpdatePersonResult UpdateSalarie(UpdatePersonn createPerson);


        createPersonResultDTO CreateStructure(createPerson createPerson);
        UpdatePersonResult UpdateStructure(UpdatePersonn createPerson);

        createPersonResultDTO CreateIntervenant(createPerson createPerson);
        UpdatePersonResult UpdateIntervenant(UpdatePersonn createPerson);

        int? CreateAggir(CreateAggirDto createPatientDto);
        bool UpdateAggir(CreateAggirDto createPatientDto);


    }
}

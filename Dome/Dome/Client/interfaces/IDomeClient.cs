using Dome.Client.dto.aggir;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.createPerson.result;
using Dome.Client.dto.updatePerson;
using Dome.infrastructure;
using Dome.Service_References.R542a;

namespace Dome.Client.interfaces
{
    public interface IDomeClient
    {

        ActionResult<CreatePersonProfilResult> CreatePatient(CreatePatient createPatient);
        ActionResult<CreatePersonProfilResult> CreateEntourage(CreateEntourage createEntourage);
        ActionResult<CreatePersonProfilResult> CreateSalarie(CreateSalarie createSalarie);
        ActionResult<CreatePersonProfilResult> CreateStructure(CreateStructure createStructure);
        ActionResult<CreatePersonProfilResult> CreateIntervenant(CreateIntervenant createIntervenant);


        ActionResult<UpdatePersonResponseDto> UpdatePerson(int accountId, UpdatePerson createPerson);

        ActionResult LinkIntervenantToBenef(int patientProfileId, int intervenantProfileId);
        ActionResult SubscriptionPatientStructure(int patientProfileId, int structureProfileId);



        ActionResult<int> CreateAggir(int profileId, CreateAggirDto createAggirDto);
        ActionResult UpdateAggir(int AGGIRGridId, UpdateAggirDto alterAggir);





    }
}

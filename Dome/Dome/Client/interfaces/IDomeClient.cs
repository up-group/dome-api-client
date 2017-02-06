using Dome.Client.dto.aggir;
using Dome.Client.dto.createPerson;
using Dome.Client.dto.createPerson.result;
using Dome.Client.dto.updatePerson;
using Dome.infrastructure;

namespace Dome.Client.interfaces
{
    public interface IDomeClient
    {

        ActionResult<CreatePersonProfilResult> CreateBeneficiaire(CreateBeneficiaire createBeneficiaire);
        ActionResult<CreatePersonProfilResult> CreateEntourage(CreateEntourage createEntourage);
        ActionResult<CreatePersonProfilResult> CreateIntervenantInterne(CreateIntervenantInterne createIntervenantInterne);
        ActionResult<CreatePersonProfilResult> CreateStructure(CreateStructure createStructure);
        ActionResult<CreatePersonProfilResult> CreateIntervenantExterne(CreateIntervenantExterne createIntervenant);


        ActionResult<UpdatePersonResult> UpdatePerson(int accountId, UpdatePerson createPerson);

        ActionResult LinkIntervenantToBenef(int beneficiaireProfileId, int intervenantProfileId);
        ActionResult SubscriptionBeneficiaireStructure(int beneficiaireProfileId, int structureProfileId);



        ActionResult<int> CreateAggir(int profileId, CreateAggirDto createAggirDto);
        ActionResult UpdateAggir(int AGGIRGridId, UpdateAggirDto alterAggir);
        ActionResult<GetListAggirResult> GetListAggir(int benefProfileId);




    }
}

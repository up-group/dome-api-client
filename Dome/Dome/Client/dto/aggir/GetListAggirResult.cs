using System;
using System.Linq;
using Dome.Service_References.R831a;

namespace Dome.Client.dto.aggir
{
    public class GetListAggirResult
    {

        public GetListAggirResult(getListAGGIRResponseDto data)
        {
            this.dOME_medAGGIRField = data.DOME_medAGGIR?.Select(x => new aggirListItemDto(x)).ToArray();

        }

        public aggirListItemDto[] dOME_medAGGIRField { get; set; }

        public class aggirListItemDto
        {
            private Service_References.R831a.aggirListItemDto x;

            public aggirListItemDto(Service_References.R831a.aggirListItemDto x)
            {
                this.x = x;
            }

            public int AGGIRGridId => x.AGGIRGridId;

            public int structureProfileId => x.structureProfileId;

            public string structureProfileStructureName => x.structureProfileStructureName;

            public DateTime AGGIREvaluationDate => x.AGGIREvaluationDate;

            public int AGGIRCreationProfileId => x.AGGIRCreationProfileId;

            public string AGGIRCreatorName => x.AGGIRCreatorName;

            public DateTime AGGIRCreationDate => x.AGGIRCreationDate;

            public string AGGIRCreatorEntityName => x.AGGIRCreatorEntityName;

            public string AGGIREvaluatorName => x.AGGIREvaluatorName;

            public int AGGIRCode => x.AGGIRCode;

            public int AGGIRCoherence => x.AGGIRCoherence;

            public int AGGIROrientation => x.AGGIROrientation;

            public int AGGIRToilette => x.AGGIRToilette;

            public int AGGIRHabillage => x.AGGIRToilette;

            public int AGGIRAlimentation => x.AGGIRAlimentation;

            public int AGGIRElimination => x.AGGIRElimination;

            public int AGGIRTransferts => x.AGGIRTransferts;

            public int AGGIRDeplacInt => x.AGGIRDeplacInt;

            public int AGGIRDeplacExt => x.AGGIRDeplacExt;

            public int AGGIRAlerter => x.AGGIRAlerter;

            public int AGGIRGestion => x.AGGIRGestion;

            public int AGGIRCuisine => x.AGGIRCuisine;

            public int AGGIRMenage => x.AGGIRMenage;

            public int AGGIRTransport => x.AGGIRTransport;

            public int AGGIRSuiviTraitement => x.AGGIRSuiviTraitement;

            public int AGGIRTempsLibre => x.AGGIRTempsLibre;

            public int AGGIRAchats => x.AGGIRAchats;

            public string AGGIRComment => x.AGGIRComment;
        }
    }
}
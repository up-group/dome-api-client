using System;

namespace Dome.Client.dto
{
    public class CreateAggirDto
    {

        public int StructureProfileId { get; set; }

        public DateTime AggirEvaluationDate { get; set; }

        public int AggirCreationProfileId { get; set; }

        public string AggirCreatorName { get; set; }

        public DateTime AggirCreationDate { get; set; }

        public string AggirCreatorEntityName { get; set; }

        public string AggirEvaluatorName { get; set; }

        public int AggirCode { get; set; }

        public int AggirCoherence { get; set; }

        public int AggirOrientation { get; set; }

        public int AggirToilette { get; set; }

        public int AggirHabillage { get; set; }

        public int AggirAlimentation { get; set; }

        public int AggirElimination { get; set; }

        public int AggirTransferts { get; set; }

        public int AggirDeplacInt { get; set; }

        public int AggirDeplacExt { get; set; }

        public int AggirAlerter { get; set; }

        public int AggirGestion { get; set; }

        public int AggirCuisine { get; set; }

        public int AggirMenage { get; set; }

        public int AggirTransport { get; set; }

        public int AggirSuiviTraitement { get; set; }

        public int AggirTempsLibre { get; set; }

        public int AggirAchats { get; set; }

        public string AggirComment { get; set; }

    }

    public class UpdateAggirDto
    {
        public int AGgirGridId { get; set; }
        public int AGgirArchivedProfileId { get; set; }
        public string AGgirArchivedName { get; set; }
        public DateTime AGgirArchivedDate { get; set; }
        public int StructureProfileId { get; set; }
        public DateTime AGgirEvaluationDate { get; set; }
        public int AGgirCreationProfileId { get; set; }
        public string AGgirCreatorName { get; set; }
        public DateTime AGgirCreationDate { get; set; }
        public string AGgirCreatorEntityName { get; set; }
        public string AGgirEvaluatorName { get; set; }
        public int AGgirCode { get; set; }
        public int AGgirCoherence { get; set; }
        public int AGgirOrientation { get; set; }
        public int AGgirToilette { get; set; }
        public int AGgirHabillage { get; set; }
        public int AGgirAlimentation { get; set; }
        public int AGgirElimination { get; set; }
        public int AGgirTransferts { get; set; }
        public int AGgirDeplacInt { get; set; }
        public int AGgirDeplacExt { get; set; }
        public int AGgirAlerter { get; set; }
        public int AGgirGestion { get; set; }
        public int AGgirCuisine { get; set; }
        public int AGgirMenage { get; set; }
        public int AGgirTransport { get; set; }
        public int AGgirSuiviTraitement { get; set; }
        public int AGgirTempsLibre { get; set; }
        public int AGgirAchats { get; set; }
        public string AGgirComment { get; set; }
    }
}

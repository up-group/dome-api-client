using System;

namespace Dome.Client.dto.aggir
{
    public class CreateAggirDto
    {

        public int? StructureProfileId { get; set; }

        public DateTime? AggirEvaluationDate { get; set; }

        public int? AggirCreationProfileId { get; set; }

        public string AggirCreatorName { get; set; }

        public DateTime? AggirCreationDate { get; set; }

        public string AggirCreatorEntityName { get; set; }

        public string AggirEvaluatorName { get; set; }

        public int? AggirCode { get; set; }

        public int? AggirCoherence { get; set; }

        public int? AggirOrientation { get; set; }

        public int? AggirToilette { get; set; }

        public int? AggirHabillage { get; set; }

        public int? AggirAlimentation { get; set; }

        public int? AggirElimination { get; set; }

        public int? AggirTransferts { get; set; }

        public int? AggirDeplacInt { get; set; }

        public int? AggirDeplacExt { get; set; }

        public int? AggirAlerter { get; set; }

        public int? AggirGestion { get; set; }

        public int? AggirCuisine { get; set; }

        public int? AggirMenage { get; set; }

        public int? AggirTransport { get; set; }

        public int? AggirSuiviTraitement { get; set; }

        public int? AggirTempsLibre { get; set; }

        public int? AggirAchats { get; set; }

        public string AggirComment { get; set; }

    }
}
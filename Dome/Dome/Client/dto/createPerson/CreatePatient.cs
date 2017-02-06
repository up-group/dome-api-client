using Dome.Client.dto.createPerson.basic;
using Dome.Enum;

namespace Dome.Client.dto.createPerson
{
    public class CreateBeneficiaire : CreateEntity
    {
        /// <summary>
        ///
        /// <see cref="ProfileStructureId"/> est obligatoire
        /// </summary>
        public CreateBeneficiaire() : base(Profile.Beneficiaire)
        {
        }

        public int ProfileStructureId { get; set; }

    }
}

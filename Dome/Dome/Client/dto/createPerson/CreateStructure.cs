using Dome.Client.dto.createPerson.basic;
using Dome.Enum;

namespace Dome.Client.dto.createPerson
{
    public class CreateStructure : CreateEntity
    {
        public CreateStructure() : base(Profile.StructureAidePersonne)
        {
        }

    }
}
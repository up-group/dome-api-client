using Dome.Client.dto.createPerson.basic;
using Dome.Enum;

namespace Dome.Client.dto.createPerson
{
    public class CreateEntourage : CreateEntity
    {
        public CreateEntourage() : base(Profile.Proche)
        {
        }

    }
}
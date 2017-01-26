using Dome.Client.dto.createPerson.basic;
using Dome.Enum;

namespace Dome.Client.dto.createPerson
{
    public class CreatePatient : CreateEntity
    {
        public CreatePatient() : base(Profile.Beneficiaire)
        {
        }

    }
}
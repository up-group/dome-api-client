using System;
using Dome.Client.dto.createPerson.basic;
using Dome.Enum;

namespace Dome.Client.dto.createPerson
{
    public class CreateIntervenantExterne : CreateEntity
    {

        public CreateIntervenantExterne(Profile profileCibleType) : base(profileCibleType)
        {
            if (profileCibleType != Profile.PersonnelMedical &&
                profileCibleType != Profile.PersonnelNonMedical &&
                profileCibleType != Profile.PersonnelParaMedical)
            {
                throw new Exception();
            }
        }

        public override SocietyRole? PersonSocietyRole { get { return SocietyRole.IntervenantExterne; } }
    }
}
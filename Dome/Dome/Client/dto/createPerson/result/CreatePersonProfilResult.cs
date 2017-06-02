using System.Linq;
using Dome.R511;
using Dome.R521;

namespace Dome.Client.dto.createPerson.result
{
    public class CreatePersonProfilResult
    {

        public void SetFromPersonResult(CreatePersonResponseDto person)
        {
            PersonId = person.accountId;
            Login = person.login;
            AccountId = person.accountId;
            Password = person.password;
            if (person.DOME_createPersonList != null)
            {
                DOmeCreatePersonList = person.DOME_createPersonList.Select(x => new DuplicatePersonDto(x)).ToArray();
            }
        }

        public void SetFromProfilResult(createProfileResponseDto profile)
        {
            ProfileId = profile.profileId;
        }

        //profil
        public int ProfileId { get; private set; }

        //Person
        public int PersonId { get; private set; }
        public string Login { get; private set; }
        public int AccountId { get; private set; }
        public string Password { get; private set; }
        public DuplicatePersonDto[] DOmeCreatePersonList { get; private set; }

        public class DuplicatePersonDto
        {

            public DuplicatePersonDto(duplicatePersonDto x)
            {
                AccountId = x.accountId;
                PersonFirstName = x.personFirstName;
                PersonLastName = x.personLastName;
                PersonEmail = x.personEmail;
                Login = x.login;
                Password = x.password;
            }

            public int AccountId { get; private set; }
            public string PersonFirstName { get; private set; }
            public string PersonLastName { get; private set; }
            public string PersonEmail { get; private set; }
            public string Login { get; private set; }
            public string Password { get; private set; }
        }

    }
}
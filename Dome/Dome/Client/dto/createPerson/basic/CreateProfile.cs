using Dome.Client.interfaces;
using Dome.Enum;

namespace Dome.Client.dto.createPerson.basic
{
    public class CreateProfile : ICreateProfile
    {
        public CreateProfile(CreateEntity createEntity)
        {
            AccountId = createEntity.AccountId;
            ProfileCibleType = createEntity.ProfileCibleType;
            ProfileParentId = createEntity.ProfileParentId;
            ProfileAvatar = createEntity.ProfileAvatar;
            PersonSocietyRole = createEntity.PersonSocietyRole;
            PersonIdMetier = createEntity.PersonIdMetier;
            PrestationListId = createEntity.PrestationListId;
            ProfileSpecialCriteria = createEntity.ProfileSpecialCriteria;
            ProfileSectoring = createEntity.ProfileSectoring;
        }

        public int? AccountId { get; set; }
        public Profile ProfileCibleType { get; set; }
        public int? ProfileParentId { get; set; }
        public int? ProfileAvatar { get; set; }
        public SocietyRole? PersonSocietyRole { get; set; }
        public string PersonIdMetier { get; set; }
        public string PrestationListId { get; set; }
        public string ProfileSpecialCriteria { get; set; }
        public string ProfileSectoring { get; set; }
    }
}
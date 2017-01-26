using Dome.Client.interfaces;
using Dome.Enum;

namespace Dome.Client.dto.createPerson.basic
{
    public class CreateProfile : ICreateProfile
    {
        public CreateProfile(CreateEntity createEntity)
        {

            AccountId = createEntity.AccountId;
            AccountIdFieldSpecified = createEntity.AccountIdFieldSpecified;
            ProfileCibleType = createEntity.ProfileCibleType;
            ProfileCibleTypeFieldSpecified = createEntity.ProfileCibleTypeFieldSpecified;
            ProfileParentId = createEntity.ProfileParentId;
            ProfileParentIdFieldSpecified = createEntity.ProfileParentIdFieldSpecified;
            ProfileAvatar = createEntity.ProfileAvatar;
            ProfileAvatarFieldSpecified = createEntity.ProfileAvatarFieldSpecified;
            PersonSocietyRole = createEntity.PersonSocietyRole;
            PersonSocietyRoleFieldSpecified = createEntity.PersonSocietyRoleFieldSpecified;
            PersonIdMetier = createEntity.PersonIdMetier;
            PrestationListId = createEntity.PrestationListId;
            ProfileSpecialCriteria = createEntity.ProfileSpecialCriteria;
            ProfileSectoring = createEntity.ProfileSectoring;
        }

        public int? AccountId { get; set; }
        public bool AccountIdFieldSpecified { get; set; }
        public Profile ProfileCibleType { get; set; }
        public bool ProfileCibleTypeFieldSpecified { get; set; }
        public int ProfileParentId { get; set; }
        public bool ProfileParentIdFieldSpecified { get; set; }
        public int ProfileAvatar { get; set; }
        public bool ProfileAvatarFieldSpecified { get; set; }
        public SocietyRole PersonSocietyRole { get; set; }
        public bool PersonSocietyRoleFieldSpecified { get; set; }
        public string PersonIdMetier { get; set; }
        public string PrestationListId { get; set; }
        public string ProfileSpecialCriteria { get; set; }
        public string ProfileSectoring { get; set; }
    }
}
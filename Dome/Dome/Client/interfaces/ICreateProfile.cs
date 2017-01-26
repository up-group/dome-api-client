using Dome.Enum;

namespace Dome.Client.interfaces
{
    public interface ICreateProfile
    {
        int? AccountId { get; set; }

        bool AccountIdFieldSpecified { get; set; }

        Profile ProfileCibleType { get; set; }

        bool ProfileCibleTypeFieldSpecified { get; set; }

        int ProfileParentId { get; set; }

        bool ProfileParentIdFieldSpecified { get; set; }

        int ProfileAvatar { get; set; }

        bool ProfileAvatarFieldSpecified { get; set; }

        SocietyRole PersonSocietyRole { get; set; }

        bool PersonSocietyRoleFieldSpecified { get; set; }

        string PersonIdMetier { get; set; }

        string PrestationListId { get; set; }

        string ProfileSpecialCriteria { get; set; }

        string ProfileSectoring { get; set; }
    }
}
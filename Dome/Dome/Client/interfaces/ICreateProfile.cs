using Dome.Enum;

namespace Dome.Client.interfaces
{
    public interface ICreateProfile
    {
        int? AccountId { get; set; }

        Profile ProfileCibleType { get; set; }

        int? ProfileParentId { get; set; }

        int? ProfileAvatar { get; set; }

        SocietyRole? PersonSocietyRole { get; set; }

        string PersonIdMetier { get; set; }

        string PrestationListId { get; set; }

        string ProfileSpecialCriteria { get; set; }

        string ProfileSectoring { get; set; }
    }
}
using System;
using Dome.Client.interfaces;
using Dome.Enum;

namespace Dome.Client.dto.createPerson.basic
{
    public abstract class CreateEntity : ICreatePerson, ICreateProfile
    {

       protected CreateEntity(Profile profileCibleType)
        {
            ProfileCibleType = profileCibleType;
        }

        #region Person

        public Civilite? PersonCivility { get; set; }

        public string PersonLastName { get; set; }

        public string PersonFirstName { get; set; }

        public string PersonPhoneNumber { get; set; }

        public string PersonMobilePhoneNumber { get; set; }

        public string PersonEmail1 { get; set; }

        public string PersonEmail2 { get; set; }

        public DateTime? PersonBirthDate { get; set; }

        public string PersonRoadType { get; set; }

        public string PersonRoadName { get; set; }

        public string PersonRoadNumber { get; set; }

        public string PersonPostBox { get; set; }

        public string PersonLieuDit { get; set; }

        public string PersonAddressComp1 { get; set; }

        public string PersonAddressComp2 { get; set; }

        public string PersonCedex { get; set; }

        public string PersonCityZipCode { get; set; }

        public string PersonCityName { get; set; }

        public string PersonBirthName { get; set; }

        public string PersonInsc { get; set; }

        public string PersonInsa { get; set; }

        public string PersonRpps { get; set; }

        public string PersonNir { get; set; }

        public string PersonJob { get; set; }

        public string SpecialCriteria { get; set; }

        public string PersonComment { get; set; }

        #endregion

        #region  Profile
        public int? AccountId { get; set; }

        public Profile? ProfileCibleType { get; set; }

        public int? ProfileParentId { get; set; }

        public int? ProfileAvatar { get; set; }

        public virtual SocietyRole? PersonSocietyRole { get; set; }

        public string PersonIdMetier { get; set; }

        public string PrestationListId { get; set; }

        public string ProfileSpecialCriteria { get; set; }

        public string ProfileSectoring { get; set; }
        #endregion


    }
}

using System;
using Dome.Enum;

namespace Dome.Client.interfaces
{
    internal interface ICreatePerson
    {
        Civilite? PersonCivility { get; set; }

        string PersonLastName { get; set; }

        string PersonFirstName { get; set; }

        string PersonPhoneNumber { get; set; }

        string PersonMobilePhoneNumber { get; set; }

        string PersonEmail1 { get; set; }

        string PersonEmail2 { get; set; }

        DateTime? PersonBirthDate { get; set; }

        string PersonRoadType { get; set; }

        string PersonRoadName { get; set; }

        string PersonRoadNumber { get; set; }

        string PersonPostBox { get; set; }

        string PersonLieuDit { get; set; }

        string PersonAddressComp1 { get; set; }

        string PersonAddressComp2 { get; set; }

        string PersonCedex { get; set; }

        string PersonCityZipCode { get; set; }

        string PersonCityName { get; set; }

        string PersonBirthName { get; set; }

        string PersonInsc { get; set; }

        string PersonInsa { get; set; }

        string PersonRpps { get; set; }

        string PersonNir { get; set; }

        string PersonJob { get; set; }

        string SpecialCriteria { get; set; }

        string PersonComment { get; set; }

    }
}
using System;
using System.Linq;
using Dome.Client.interfaces;
using Dome.Enum;
using Dome.Service_References.R542a;

namespace Dome.Client.dto.updatePerson
{
    public class UpdatePerson : IUpdatePerson
    {

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

    }


    public class UpdatePersonResult
    {
        public UpdatePersonResult(UpdatePersonResponseDto data)
        {
            this.dOME_createPersonListField = data.DOME_createPersonList?.Select(x => new duplicatePersonDto()
            {
                accountIdField = x.accountId,
                loginField = x.login,
                passwordField = x.password,
                personEmailField = x.personEmail,
                personFirstNameField = x.personFirstName,
                personLastNameField = x.personLastName

            }).ToArray();
        }

        public duplicatePersonDto[] dOME_createPersonListField { get; set; }

        public class duplicatePersonDto
        {

            public int accountIdField { get; set; }

            public string personFirstNameField { get; set; }

            public string personLastNameField { get; set; }

            public string personEmailField { get; set; }

            public string loginField { get; set; }

            public string passwordField { get; set; }
        }

    }


}




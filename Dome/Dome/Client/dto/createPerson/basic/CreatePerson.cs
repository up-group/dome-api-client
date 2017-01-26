using System;
using Dome.Client.interfaces;
using Dome.Enum;

namespace Dome.Client.dto.createPerson.basic
{
    public class CreatePerson : ICreatePerson
    {

        public CreatePerson(CreateEntity createEntity)
        {
            PersonCivility = createEntity.PersonCivility;

            PersonLastName = createEntity.PersonLastName;

            PersonFirstName = createEntity.PersonFirstName;

            PersonPhoneNumber = createEntity.PersonPhoneNumber;

            PersonMobilePhoneNumber = createEntity.PersonMobilePhoneNumber;

            PersonEmail1 = createEntity.PersonEmail1;

            PersonEmail2 = createEntity.PersonEmail2;

            PersonBirthDate = createEntity.PersonBirthDate;

            PersonRoadType = createEntity.PersonRoadType;

            PersonRoadName = createEntity.PersonRoadName;

            PersonRoadNumber = createEntity.PersonRoadNumber;

            PersonPostBox = createEntity.PersonPostBox;

            PersonLieuDit = createEntity.PersonLieuDit;

            PersonAddressComp1 = createEntity.PersonAddressComp1;

            PersonAddressComp2 = createEntity.PersonAddressComp2;

            PersonCedex = createEntity.PersonCedex;

            PersonCityZipCode = createEntity.PersonCityZipCode;

            PersonCityName = createEntity.PersonCityName;

            PersonBirthName = createEntity.PersonBirthName;

            PersonInsc = createEntity.PersonInsc;

            PersonInsa = createEntity.PersonInsa;

            PersonRpps = createEntity.PersonRpps;

            PersonNir = createEntity.PersonNir;

            PersonJob = createEntity.PersonJob;

            SpecialCriteria = createEntity.SpecialCriteria;

            PersonComment = createEntity.PersonComment;
        }


        public Civilite PersonCivility { get; set; }

        public string PersonLastName { get; set; }

        public string PersonFirstName { get; set; }

        public string PersonPhoneNumber { get; set; }

        public string PersonMobilePhoneNumber { get; set; }

        public string PersonEmail1 { get; set; }

        public string PersonEmail2 { get; set; }

        public DateTime PersonBirthDate { get; set; }

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
}
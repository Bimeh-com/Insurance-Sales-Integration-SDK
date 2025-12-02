using Bimehcom.Core.Models.Base.RequiredFiles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.ExtraInsured
{
    public class ExtraInsuredDetails
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public string IdNumber { get; set; }
        public DateTime? BirthDate { get; set; }

        public List<RequiredFile> RequiredFiles { get; set; }


        public string UniqueValue { get; set; }
        public int? BirthCityId { get; set; }
        public int? BirthProvinceId { get; set; }
        public string FatherName { get; set; }
        public int? RoleId { get; set; }
        public string FamilyRelationship { get; set; }
        public int? FamilyRelationshipId { get; set; }
        public int? MaritalStatusId { get; set; }
        public short? DependentStatusId { get; set; }
        public string BasicInsuranceNumber { get; set; }
        public int? BasicInsuranceId { get; set; }
        public short? GenderId { get; set; }
    }
}

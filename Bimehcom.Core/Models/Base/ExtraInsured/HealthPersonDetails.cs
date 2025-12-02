using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.ExtraInsured
{
    public class HealthPersonDetails
    {
        public string NationalCode { get; set; }
        public int? RelationshipId { get; set; }
        public Guid? Id { get; set; }
        /// <summary>
        /// اطلاعات مازاد
        /// </summary>
        public string? IdNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FatherName { get; set; }
        public short? MaritalStatusId { get; set; }
        public string? BasicInsuranceNumber { get; set; }
        public short? GenderId { get; set; }
    }
}

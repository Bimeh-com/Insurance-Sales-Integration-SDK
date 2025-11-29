using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class ExtraPersonInformation
    {
        public int? ChildrenCount { get; set; }

        public short? MaritalStatusId { get; set; }
        public string MaritalStatus { get; set; }

        public DateTime? EmployeementDate { get; set; }

        public string MedicalSystemNumber { get; set; }

        public int? WorkCityId { get; set; }
        public string WorkCityName { get; set; }
        public int? WorkProvinceId { get; set; }
        public string WorkProvinceName { get; set; }

        public short? DependentStatusId { get; set; }

        public int? BankId { get; set; }
        public string Bank { get; set; }

        public string BasicInsuranceNumber { get; set; }

        public string IBAN { get; set; }
        public string AccountNumber { get; set; }
    }
}

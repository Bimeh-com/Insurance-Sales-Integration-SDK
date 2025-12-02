using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;
using System;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public class HealthInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        /// <summary>
        /// کد ملی
        /// </summary>
        public string IdNumber { get; set; }
        public HealthExtraPersonInfo ExtraPersonInfo { get; set; }
    }

    public class HealthExtraPersonInfo
    {
        public short? ChildrenCount { get; set; }
        public short? MaritalStatus { get; set; }
        public DateTime? EmployeementDate { get; set; }
        public string MedicalSystemNumber { get; set; }
        public int? WorkCityId { get; set; }
        public short? DependentStatus { get; set; }
        public int? BankId { get; set; }
        public string IBAN { get; set; }
        public string BankAccountNumber { get; set; }
        public string BasicInsuranceNumber { get; set; }

    }
}
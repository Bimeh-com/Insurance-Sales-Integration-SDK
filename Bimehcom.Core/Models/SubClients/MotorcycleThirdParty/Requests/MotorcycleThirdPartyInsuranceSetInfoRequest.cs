using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;
using System;

namespace Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests
{
    public class MotorcycleThirdPartyInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        public bool? PolicyOwnerIsCarOwner { get; set; }
        public string CarOwnerFirstName { get; set; }
        public string CarOwnerLastName { get; set; }
        public string CarOwnerNationalCode { get; set; }
        public DateTime? CarOwnerBirthDate { get; set; }
        public string CarOwnerMobileNumber { get; set; }
        public string CarOwnerPhone { get; set; }
    }
}
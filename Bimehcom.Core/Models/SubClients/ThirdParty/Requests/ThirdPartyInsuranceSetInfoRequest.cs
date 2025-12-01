using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;
using System;

namespace Bimehcom.Core.Models.SubClients.ThirdParty.Requests
{
    public class ThirdPartyInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        public bool? PolicyOwnerIsCarOwner { get; set; }

        public string CarOwnerFirstName { get; set; }

        public string CarOwnerLastName { get; set; }

        public string CarOwnerNationalCode { get; set; }

        public DateTime? CarOwnerBirthDate { get; set; }

        public string CarOwnerMobileNumber { get; set; }

        public string CarOwnerPhone { get; set; }

        
        public override long? AddressId { get => base.AddressId; set => base.AddressId = value; }

        public override DateTime? BirthDate { get => base.BirthDate; set => base.BirthDate = value; }
    }
}
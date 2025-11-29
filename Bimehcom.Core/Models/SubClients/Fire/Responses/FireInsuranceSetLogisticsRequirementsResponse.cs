using Bimehcom.Core.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceSetLogisticsRequirementsResponse : IBimehcomApiResponse
    {
        public dynamic InsuranceRequestId { get; set; }

        public dynamic AdditionalInfo { get; set; }
    }
}

using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.ExtraInsured;
using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Health.Requests
{
    public class HealthInsuranceSetExtraInsuredInfoRequest : IBimehcomApiRequest
    {
        public List<HealthPersonDetails> ExtraInsureds { get; set; }
    }
}

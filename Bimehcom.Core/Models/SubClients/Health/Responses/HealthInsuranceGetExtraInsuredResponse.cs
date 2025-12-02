using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.ExtraInsured;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Health.Responses
{
    public class HealthInsuranceGetExtraInsuredResponse : IBimehcomApiResponse
    {
        public List<ExtraInsuredDetails> ExtraInsureds { get; set; }
        public int? InformationCompletingMethod { get; set; }
    }
}

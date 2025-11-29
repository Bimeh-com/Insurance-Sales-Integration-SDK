using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceSetLogisticsRequirementsResponse : IBimehcomApiResponse
    {
        public dynamic InsuranceRequestId { get; set; }

        public dynamic AdditionalInfo { get; set; }
    }
}

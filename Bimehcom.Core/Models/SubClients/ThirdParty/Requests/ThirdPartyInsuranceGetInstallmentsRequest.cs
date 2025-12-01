using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.ThirdParty.Requests
{
    public class ThirdPartyInsuranceGetInstallmentsRequest : IBimehcomApiRequest
    {
        public string UniqueId { get; set; }
    }
}

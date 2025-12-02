using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.CarThirdParty.Requests
{
    public class CarThirdPartyInsuranceGetInstallmentsRequest : IBimehcomApiRequest
    {
        public string UniqueId { get; set; }
    }
}

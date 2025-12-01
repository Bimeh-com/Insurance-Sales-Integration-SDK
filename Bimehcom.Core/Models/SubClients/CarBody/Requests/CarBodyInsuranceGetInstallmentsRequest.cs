using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.CarBody.Requests
{
    public class CarBodyInsuranceGetInstallmentsRequest : IBimehcomApiRequest
    {
        public string UniqueId { get; set; }
    }
}

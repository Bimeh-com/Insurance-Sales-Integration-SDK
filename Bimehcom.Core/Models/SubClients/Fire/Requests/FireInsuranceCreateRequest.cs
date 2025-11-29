using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.Fire.Requests
{
    public class FireInsuranceCreateRequest : IBimehcomApiRequest
    {
        public string UniqueId { get; set; }
    }
}

using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Gateway.Get;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceGetGatewayOptionsResponse : IBimehcomApiResponse
    {
        public List<Gateway> Gateways{ get; set; }
    }
}

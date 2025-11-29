using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.DeliveryAddress;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserAddressesResponse : IBimehcomApiResponse
    {
        public List<UserAddressVM> Addresses { get; set; }
    }
}

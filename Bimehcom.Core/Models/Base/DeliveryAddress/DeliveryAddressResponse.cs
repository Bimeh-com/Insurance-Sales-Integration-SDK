using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.DeliveryAddress
{
    public class DeliveryAddressResponse
    {
        public List<UserAddressVM> Addresses { get; set; }
        public long SelectedId { get; set; }
    }
}

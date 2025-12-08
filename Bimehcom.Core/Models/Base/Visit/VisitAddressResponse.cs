using Bimehcom.Core.Models.Base.DeliveryAddress;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Visit
{
    public class VisitAddressResponse
    {
        public List<UserAddressVM> Addresses { get; set; }
        public long SelectedId { get; set; }
    }
}

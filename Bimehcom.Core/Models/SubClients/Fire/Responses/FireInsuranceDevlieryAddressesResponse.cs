using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.DeliveryAddress;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceDevlieryAddressesResponse : IBimehcomApiResponse
    {
        public List<UserAddressVM> Addresses { get; set; }
        public long SelectedId { get; set; }
    }
}

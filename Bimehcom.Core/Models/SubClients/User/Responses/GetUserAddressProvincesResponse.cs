using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserAddressProvincesResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Provinces { get; set; }
    }
}

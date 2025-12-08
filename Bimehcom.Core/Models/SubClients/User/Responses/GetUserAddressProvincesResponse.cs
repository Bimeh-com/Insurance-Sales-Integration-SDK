using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserAddressProvincesResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Provinces { get; set; }
    }
}

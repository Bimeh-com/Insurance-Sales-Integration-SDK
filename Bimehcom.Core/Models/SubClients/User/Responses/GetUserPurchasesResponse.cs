using Bimehcom.Core.Models.Base.User.InsuranceRequests;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserPurchasesResponse
    {
        public List<RequestListItem> Purchases { get; set; }
    }
}

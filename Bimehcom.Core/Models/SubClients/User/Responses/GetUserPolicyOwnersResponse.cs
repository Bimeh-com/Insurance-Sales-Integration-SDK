using Bimehcom.Core.Models.Base.User;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserPolicyOwnersResponse
    {
        public List<PolicyOwner> PolicyOwners { get; set; }
    }
}

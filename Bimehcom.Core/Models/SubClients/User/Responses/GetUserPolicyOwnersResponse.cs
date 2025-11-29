using Bimehcom.Core.Models.Base.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserPolicyOwnersResponse
    {
        public List<PolicyOwner> PolicyOwners { get; set; }
    }
}

using Bimehcom.Core.Models.Base.User.Plaques;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetUserPlaquesResponse
    {
        public List<MyPlaque> Plaques { get; set; }
    }
}

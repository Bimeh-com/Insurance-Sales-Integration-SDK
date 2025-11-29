using Bimehcom.Core.Models.SubClients.User.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IUserClient
    {
        Task<GetUserAddressesResponse> GetAddressesAsync();
        Task<GetUserPolicyOwnersResponse> GetPolicyOwnersAsync();
    }
}

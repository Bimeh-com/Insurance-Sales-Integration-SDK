using Bimehcom.Core.Models.SubClients.User.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IUserClient
    {
        Task<GetUserAddressesResponse> GetAddressesAsync(CancellationToken cancellationToken = default);
        Task<GetUserPolicyOwnersResponse> GetPolicyOwnersAsync(CancellationToken cancellationToken = default);
    }
}

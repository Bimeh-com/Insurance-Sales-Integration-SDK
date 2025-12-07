using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.User.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class UserClient : IUserClient
    {
        private readonly IHttpService _httpService;

        public UserClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetUserAddressesResponse> GetAddressesAsync(CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<GetUserAddressesResponse>(ApiRoutes.GetUserAddresses(), cancellationToken);
        }

        public async Task<GetUserPolicyOwnersResponse> GetPolicyOwnersAsync(CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<GetUserPolicyOwnersResponse>(ApiRoutes.GetUserPolicyOwners(), cancellationToken);
        }
    }
}
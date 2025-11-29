using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.User.Responses;
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

        public async Task<GetUserAddressesResponse> GetAddresses()
        {
            return await _httpService.GetAsync<GetUserAddressesResponse>(ApiRoutes.GetUserAddresses());
        }

        public async Task<GetUserPolicyOwnersResponse> GetPolicyOwners()
        {
            return await _httpService.GetAsync<GetUserPolicyOwnersResponse>(ApiRoutes.GetUserPolicyOwners());
        }
    }
}
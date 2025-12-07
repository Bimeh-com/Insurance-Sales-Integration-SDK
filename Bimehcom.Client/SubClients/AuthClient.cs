using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Core.Models.SubClients.Auth.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class AuthClient : IAuthClient
    {
        private readonly IHttpService _httpService;

        public AuthClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<AuthLocalLoginResponse> LocalLoginAsync(AuthLocalLoginRequest request, CancellationToken cancellationToken = default)
        {
            var loginResponse = await _httpService.PostAsync<AuthLocalLoginRequest, AuthLocalLoginResponse>(ApiRoutes.LocalLogin(), request, cancellationToken);

            if (!string.IsNullOrEmpty(loginResponse.JWT))
                _httpService.AddGlobalHeader("Authorization", $"Bearer {loginResponse.JWT}");

            return loginResponse;
        }
    }
}

using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Client.SubClients
{
    internal class AuthClient : IAuthClient
    {
        private readonly IHttpService _httpService;

        public AuthClient(IHttpService httpService)
        {
            _httpService = httpService;
        }
    }
}

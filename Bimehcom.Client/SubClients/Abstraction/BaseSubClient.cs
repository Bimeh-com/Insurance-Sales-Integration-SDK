using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal class BaseSubClient : IBaseSubClient
    {
        private readonly IHttpService _httpService;

        public BaseSubClient(IHttpService httpService)
        {
            _httpService = httpService;
        }
    }
}
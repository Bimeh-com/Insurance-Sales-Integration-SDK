using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Client.SubClients
{
    internal class FireInsuranceClient : BaseSubClient, IFireInsuranceClient
    {
        private readonly IHttpService _httpService;

        public FireInsuranceClient(IHttpService httpService) 
            : base(httpService)
        {
            _httpService = httpService;
        }
    }
}
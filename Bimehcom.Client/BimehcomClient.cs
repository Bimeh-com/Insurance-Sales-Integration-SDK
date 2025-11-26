using Bimehcom.Core;
using Bimehcom.Core.Interfaces;

namespace Bimehcom.Client
{
    internal class BimehcomClient : IBimehcomClient
    {
        private readonly IHttpService _httpService;

        public BimehcomClient(IHttpService httpService)
        {
            _httpService = httpService;
        }
    }
}
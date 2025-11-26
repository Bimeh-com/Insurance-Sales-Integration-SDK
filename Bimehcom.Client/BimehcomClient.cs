using Bimehcom.Client.SubClients;
using Bimehcom.Core;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Client
{
    internal class BimehcomClient : IBimehcomClient
    {
        private readonly IHttpService _httpService;
        private readonly object _lock = new object();
        public BimehcomClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        #region Sub Clients

        private IFireInsuranceClient? _fire;
        public IFireInsuranceClient Fire
        {
            get
            {
                if (_fire == null)
                    lock (_lock)
                        _fire = new FireInsuranceClient(_httpService);
                return _fire;
            }
        }

        #endregion
    }
}
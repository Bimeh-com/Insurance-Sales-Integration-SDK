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

        private IAuthClient? _auth;
        public IAuthClient Auth
        {
            get
            {
                if (_auth == null)
                    lock (_lock)
                        _auth = new AuthClient(_httpService);
                return _auth;
            }
        }

        private IUserClient? _user;
        public IUserClient User
        {
            get
            {
                if (_user == null)
                    lock (_lock)
                        _user = new UserClient(_httpService);
                return _user;
            }
        }

        private IThirdPartyInsuranceClient? _thirdParty;
        public IThirdPartyInsuranceClient ThirdParty
        {
            get
            {
                if (_thirdParty == null)
                    lock (_lock)
                        _thirdParty = new ThirdPartyInsuranceClient(_httpService);
                return _thirdParty;
            }
        }

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
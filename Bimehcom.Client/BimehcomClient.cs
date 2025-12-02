using Bimehcom.Client.SubClients;
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

        private ICarThirdPartyInsuranceClient? _carThirdParty;
        public ICarThirdPartyInsuranceClient CarThirdParty
        {
            get
            {
                if (_carThirdParty == null)
                    lock (_lock)
                        _carThirdParty = new CarThirdPartyInsuranceClient(_httpService);
                return _carThirdParty;
            }
        }

        private ICarBodyInsuranceClient? _carBody;
        public ICarBodyInsuranceClient CarBody
        {
            get
            {
                if (_carBody == null)
                    lock (_lock)
                        _carBody = new CarBodyInsuranceClient(_httpService);
                return _carBody;
            }
        }

        private IMotorcycleThirdPartyInsuranceClient? _motorcycleThirdParty;
        public IMotorcycleThirdPartyInsuranceClient MotorcycleThirdParty
        {
            get
            {
                if (_motorcycleThirdParty == null)
                    lock (_lock)
                        _motorcycleThirdParty = new MotorcycleThirdPartyInsuranceClient(_httpService);
                return _motorcycleThirdParty;
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

        private IHealthInsuranceClient? _health;
        public IHealthInsuranceClient Health
        {
            get
            {
                if (_health == null)
                    lock (_lock)
                        _health = new HealthInsuranceClient(_httpService);
                return _health;
            }
        }


        #endregion
    }
}
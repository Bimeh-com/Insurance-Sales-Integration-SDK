using Bimehcom.Client.Services;
using Bimehcom.Core;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Options;
using System;

namespace Bimehcom.Client
{
    public class BimehcomClientBuilder
    {
        private BimehcomClientOptions _options;
        private IHttpService _httpService;

        public BimehcomClientBuilder(Action<BimehcomClientOptions> options)
        {
            _options = new BimehcomClientOptions();
            options(_options);
            _options.Validate();

            _httpService = new HttpService(_options);
        }

        public IBimehcomClient Build()
        {
            return new BimehcomClient(_httpService);
        }
    }
}
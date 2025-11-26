using Bimehcom.Core;
using Bimehcom.Core.Options;
using System;

namespace Bimehcom.Client
{
    public class BimehcomClientBuilder
    {
        private BimehcomClientOptions _options;

        public BimehcomClientBuilder(Action<BimehcomClientOptions> options)
        {
            _options = new BimehcomClientOptions();
            options(_options);
            _options.Validate();
        }

        public IBimehcomClient Build()
        {
            return new BimehcomClient();
        }
    }
}

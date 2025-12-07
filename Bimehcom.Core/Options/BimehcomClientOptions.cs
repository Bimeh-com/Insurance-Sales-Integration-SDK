using System;
using Bimehcom.Core.Exceptions;

namespace Bimehcom.Core.Options
{
    public class BimehcomClientOptions
    {
        private const string DefaultApiVersion = "v1";
        private static readonly Uri DefaultBaseUrl = new Uri("https://coreapi.bimeh.com");

        public string ApiKey { get; set; }
        public Uri BaseApiUrl { get; set; }
        public string ApiVersion { get; set; }
        public string PublicKey { get; set; }

        public void EnsureValid()
        {
            if (BaseApiUrl == null)
            {
                BaseApiUrl = DefaultBaseUrl;
            }

            if (string.IsNullOrWhiteSpace(ApiVersion))
            {
                ApiVersion = DefaultApiVersion;
            }

            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                throw new BimehcomException("ApiKey must be provided in BimehcomClientOptions.");
            }
            if (string.IsNullOrWhiteSpace(PublicKey))
            {
                throw new BimehcomException("PublicKey must be provided in BimehcomClientOptions.");
            }

            if (!BaseApiUrl.IsAbsoluteUri)
            {
                throw new BimehcomException("BaseApiUrl must be an absolute URI.");
            }

            if (!ApiVersion.StartsWith("v", StringComparison.OrdinalIgnoreCase))
            {
                throw new BimehcomException("ApiVersion must start with 'v', e.g., 'v1'.");
            }
        }
    }
}

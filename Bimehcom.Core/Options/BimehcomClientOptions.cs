using System;

namespace Bimehcom.Core.Options
{
    public class BimehcomClientOptions
    {
        public string ApiKey { get; set; }
        public Uri BaseApiUrl{ get; set; }
        public string ApiVersion { get; set; }

        public void Validate()
        {
            // Todo
            // Add validations and throw the corresponding exceptions after Core Exception logic is implemented
        }
    }
}
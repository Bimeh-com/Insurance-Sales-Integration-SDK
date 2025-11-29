using Bimehcom.Core.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceRedirectToGatewayResponse: IBimehcomApiResponse
    {
        public string Result { get; set; }
    }
}

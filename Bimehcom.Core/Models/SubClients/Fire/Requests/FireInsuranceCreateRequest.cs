using Bimehcom.Core.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.Fire.Requests
{
    public class FireInsuranceCreateRequest : IBimehcomApiRequest
    {
        public string UniqueId { get; set; }
    }
}

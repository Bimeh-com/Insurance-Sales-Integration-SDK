using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public class DeliveryResponse
    {
        public List<DeliveryDate> Deliveries { get; set; }
        public string Description { get; set; }
    }
}

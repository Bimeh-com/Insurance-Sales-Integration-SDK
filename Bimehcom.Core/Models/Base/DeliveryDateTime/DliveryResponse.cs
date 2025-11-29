using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public class DeliveryResponse
    {
        public List<DeliveryDate> Deliveries { get; set; }
        public string Description { get; set; }
    }
}

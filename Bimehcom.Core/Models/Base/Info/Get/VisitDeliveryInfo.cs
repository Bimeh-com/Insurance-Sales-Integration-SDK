using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class VisitDeliveryInfo
    {
        public long? AddressId { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public string Time { get; set; }
    }
}

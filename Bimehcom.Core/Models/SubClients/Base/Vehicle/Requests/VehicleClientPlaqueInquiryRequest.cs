using Bimehcom.Core.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests
{
    public class VehicleClientPlaqueInquiryRequest : IBimehcomApiRequest
    {
        public int LeftSide { get; set; }
        public short RightSide { get; set; }
        public int LetterId { get; set; }
        public int IranCode { get; set; }
        public string MobileNumber { get; set; }
        public string NationalCode { get; set; }

        public override string ToString()
        {
            return $"{LeftSide}-{LetterId}-{RightSide}-{IranCode}-{NationalCode}";
        }
    }
}

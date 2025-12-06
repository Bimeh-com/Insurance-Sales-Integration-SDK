using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;

namespace Bimehcom.Core.Models.SubClients.Pilgrimage.Requests
{
    public class PilgrimageInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        public DateTime? BirthDate { get; set; }

        public DateTime? TravelStartDate { get; set; }
    }
}
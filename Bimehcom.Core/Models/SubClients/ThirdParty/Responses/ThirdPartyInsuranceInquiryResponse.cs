
using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.ThirdParty.Responses
{
    public class ThirdPartyInsuranceInquiryResponse : InquiryResponse, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست پوشش ها
        /// </summary>
        public List<Coverage> Coverages { get; set; }
    }
}

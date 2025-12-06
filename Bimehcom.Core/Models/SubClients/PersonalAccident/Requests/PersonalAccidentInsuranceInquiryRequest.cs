using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;

namespace Bimehcom.Core.Models.SubClients.PersonalAccident.Requests
{
    public class PersonalAccidentInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// شغل
        /// </summary>
        public int? CareerId { get; set; }
    }
}
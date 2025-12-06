using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;

namespace Bimehcom.Core.Models.SubClients.TravelPlus.Requests
{
    public class TravelPlusInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// شناسه کشور مقصد
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// مدت سفر
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? DurationId { get; set; }

        /// <summary>
        /// نوع ویزا
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public EnInsVisaType? VisaTypeId { get; set; }

        /// <summary>
        /// شناسه طرح
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? PlanId { get; set; }
    }
}
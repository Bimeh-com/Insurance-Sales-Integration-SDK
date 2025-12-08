using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Health.Requests
{
    public class HealthInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// تاریخ تولد بیمه گذار اصلی
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// شناسه بیمه گر بیمه گذار اصلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public long? BasicInsuranceId { get; set; }

        /// <summary>
        /// لیست اعضای خانواده
        /// </summary>
        public List<HealthInqueryItem> FamilyMembers { get; set; }

        /// <summary>
        /// اتباع خارجی
        /// </summary>
        public bool? IsForeigner { get; set; }
    }

    public class HealthInqueryItem
    {
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// شناسه بیمه گر بیمه گذار
        /// </summary>
        public long? BasicInsuranceId { get; set; }

        public List<HealthInqueryItem> FamilyMembers { get; set; }
        /// <summary>
        /// اتباع خارجی
        /// </summary>
        public bool? IsForeigner { get; set; }
    }
}
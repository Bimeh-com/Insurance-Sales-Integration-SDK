using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class InquiryRequest
    {
        /// <summary>
        /// شناسه بیمه نامه قبلی جهت تمدید بیمه نامه
        /// </summary>
        public virtual long? PreviousInsuranceRequestId { get; set; }
        /// <summary>
        /// جهت اعمال کد تخفیف در زمان استعلام و مشاهده مقدار تخفیف
        /// </summary>
        public string? VoucherCode { get; set; }
        /// <summary>
        /// شرکت های بیمه
        /// </summary>
        public int[]? CompanyIds { get; set; }
        public string InquiryUrl { get; set; }
    }
}

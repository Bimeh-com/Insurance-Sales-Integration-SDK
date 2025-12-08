using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.User.InsuranceRequests
{
    public class RequestListItem : BaseRequestListItem
    {
        /// <summary>
        /// آیا فایل دارد؟
        /// </summary>
        public bool HasPolicyFile {get; set; }
        /// <summary>
        /// هدایای دریافتی
        /// </summary>
        public List<Gifts> Gifts { get; set; }
        public decimal PaymentAmount { get; set; }
        public int? DurationTotalDays { get; set; }
        public bool RepurchasePossibility { get; set; }
        public bool Expiring { get; set; }
        public bool NeedVisitationInformation { get; set; }
        public string Description { get; set; }
        public int? VisitMethodId { get; set; }
        public string BranchTitle { get; set; }
        public string BranchLatinTitle { get; set; }
        public dynamic InsuranceRequestId { get; set; }
        public string TrackingCode { get; set; }
    }
}

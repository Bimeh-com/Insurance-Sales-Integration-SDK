using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class InquiryResponseItem : FinancialDetails
    {
        /// <summary>
        /// آیدی شرکت
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// عنوان (طرح)
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات بیشتر
        /// </summary>
        public string SubTitle { get; set; }
        /// <summary>
        /// شناسه یکتا قیمت بیمه نامه
        /// </summary>
        public string UniqueId { get; set; }
        public int? PlanOrder { get; set; }

        public UniqueIdOfInsuranceBranch UniqueIdObject { get; set; }

        public decimal? AgreementDiscountPercent { get; set; }
        public decimal? AgreementDiscountAmount { get; set; }
        public decimal? SiteDiscountPercent { get; set; }
        public decimal? SiteDiscountAmount { get; set; }
        public decimal? CompanyDiscountPercent { get; set; }
        public decimal? CompanyDiscountAmount { get; set; }
        public decimal? BranchDiscountPercent { get; set; }
        public decimal? BranchDiscountAmount { get; set; }

        /// <summary>
        /// مبلغ تخفیف اقساطی
        /// </summary>
        public decimal InstallmentDiscountAmount { get; set; }

        public int CompanyBranchId { get; set; }
        public CompanyBranch CompanyBranch { get; set; }
        /// <summary>
        /// جزئیات بیشتر
        /// </summary>
        public List<Detail> MoreDetails { get; set; }
        /// <summary>
        /// مدت زمان (روز)
        /// </summary>
        public int? Duration { get; set; }

        /// <summary>
        /// شناسه مدت زمان بیمه نامه
        /// </summary>
        public int? DurationId { get; set; }

        /// <summary>
        /// شناسه تخفیف اتوماتیک
        /// </summary>
        public int? VoucherId { get; set; }

        public long? PreviousInsuranceRequestId { get; set; }

        public bool? Pinned { get; set; }
        public bool? Offer { get; set; }
        public int? SaleRank { get; set; }
        public bool? IsLocked { get; set; }
    }
}

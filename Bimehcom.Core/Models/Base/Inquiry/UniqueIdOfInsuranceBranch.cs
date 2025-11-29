using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class UniqueIdOfInsuranceBranch
    {
        public int CompanyId { get; set; }
        public Price ChashPrice { get; set; }
        public Price InstallmentPrice { get; set; }
        public InquiryRequest InquiryRequest { get; set; }
        public int? InstallmentId { get; set; }
        public int? DurationId { get; set; }
        public int? VoucherId { get; set; }
        public Price PreviousChashPrice { get; set; }
        public Price OrginalChashPrice { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int? V { get; set; }
        public decimal? AgreementDiscountPercent { get; set; }
        public decimal? AgreementDiscountAmount { get; set; }
        public decimal? SiteDiscountPercent { get; set; }
        public decimal? SiteDiscountAmount { get; set; }
        public decimal? CompanyDiscountPercent { get; set; }
        public decimal? CompanyDiscountAmount { get; set; }
        public decimal? BranchDiscountPercent { get; set; }
        public decimal? BranchDiscountAmount { get; set; }
        public string RefererData { get; set; }
        public int? RefererBusiness { get; set; }
        public Guid? InquiryId { get; set; }
    }
}

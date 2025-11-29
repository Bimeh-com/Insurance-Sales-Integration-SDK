using System;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class CompanyBranch
    {
        public int InsCompanyBranchID { get; set; }
        public int EmpCompanyId { get; set; }
        public int InsInsuranceBranchId { get; set; }
        public int? InsTravelInsuranceParentCorporateId { get; set; }
        public bool Enabled { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Vat { get; set; }
        public decimal? DeliveryCost { get; set; }
        public bool? HasPermissionForOnlineIssue { get; set; }
        public bool HasPenalty { get; set; }
        public bool HasInstallmentPayment { get; set; }
        public decimal? InstallmentPrePeyment { get; set; }
        public string InstallmentDetails { get; set; }
        public short Priority { get; set; }
        public short CompanyPriority { get; set; }
        public string PrivateConditions { get; set; }
        public bool AgentIsSelecatble { get; set; }
        public bool? HasOnlineInquiry { get; set; }
        public decimal? InstallmentPrePeymentAddedCost { get; set; }
        public double? InstallmentAddPercent { get; set; }
        public double? AgreementDiscount { get; set; }
        public double? CarBodyMainDiscountPercentMax { get; set; }
        public double? CarBodyAdditionDiscountPercentMax { get; set; }
        public double? IssuanceWagePercent { get; set; }
        public double? IssuanceContractWagePercent { get; set; }
        public double? RevenueWagePercent { get; set; }
        public string FastDelivery { get; set; }
        public string Tag { get; set; }
        public string Notice { get; set; }
        public string FastDeliveryCostTitle { get; set; }
        public string GeneralConditions { get; set; }
        public int? CompensationBranchCount { get; set; }
        public bool ForgivePenaltyIfExtended { get; set; }
        public bool NoDiscountForShortTerm { get; set; }
        public bool HideDiscountHint { get; set; }
        public bool NonAcceptanceOfDamages { get; set; }
        public int? DefaultUserCompanyAgentId { get; set; }
        public int? CreatorUserId { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public int? BusinessId { get; set; }
        public string Title { get; set; }
        public bool? MobileCompensation { get; set; }
        public decimal? CompanyDiscount { get; set; }
        public decimal? RepurchaseDiscount { get; set; }

        public string CompanyResponseTime { get; set; }

        public int? CompanySatisfiedRating { get; set; }
        public bool? Pinned { get; set; }
        public bool? Offer { get; set; }
        public int? SaleRank { get; set; }
        public bool? IsLocked { get; set; }
        public bool? AllowLegalPolicyOwner { get; set; }
        public decimal? MaxDiscount { get; set; }
        public decimal? MaxDiscountForPromoter { get; set; }
    }
}

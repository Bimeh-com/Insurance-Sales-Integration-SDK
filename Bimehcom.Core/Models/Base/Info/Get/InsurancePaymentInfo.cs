namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class InsurancePaymentInfo : PaymentInfo
    {
        /// <summary>
        /// مبلغ قابل پرداخت
        /// </summary>
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// مبلغ اولیه
        /// </summary>
        public decimal FirstAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده با کد تخفیف
        /// </summary>
        public decimal VocherDeductedAmount { get; set; }
        public decimal VoucherDeductedAmount { get { return VocherDeductedAmount; } }

        /// <summary>
        /// مبلغ کسر شده با کیف پول
        /// </summary>
        public decimal WalletDeductedAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده با هپی کارت
        /// </summary>
        public decimal HappyCardDeductedAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده با درگاه های بانکی
        /// </summary>
        public decimal GatewayDeductedAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده دیگر
        /// </summary>
        public decimal OtherDeductedAmount { get; set; }

        /// <summary>
        /// اقساطی
        /// </summary>
        public bool IsInstallment { get; set; }
        /// <summary>
        /// هزینه ارسال
        /// </summary>
        public decimal DeliveryCostAmount { get; set; }
        /// <summary>
        /// تخفیف سایت
        /// </summary>
        public decimal SiteDiscountAmount { get; set; }
        /// <summary>
        /// تخفیف توافقی
        /// </summary>
        public decimal AgreementDiscountAmount { get; set; }
        /// <summary>
        /// تخفیف عدم ارسال
        /// </summary>
        public decimal DeliveryDiscount { get; set; }
        /// <summary>
        /// تخفیف عدم بازدید
        /// </summary>
        public decimal NoVisitDiscount { get; set; }

        /// <summary>
        /// کل مبغ قابل عودت
        /// </summary>
        public long SumReturnableAmount { get; set; }

        /// <summary>
        /// هزینه ارسال
        /// </summary>
        public decimal InstallmentPromissoryNoteCost { get; set; }
        public decimal InstallmentVerificationCost { get; set; }
        public decimal InstallmentWageAmount { get; set; }
        public decimal VisitCostAmount { get; set; }
    }
}

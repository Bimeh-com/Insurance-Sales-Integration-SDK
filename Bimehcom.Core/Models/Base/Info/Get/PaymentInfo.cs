namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class PaymentInfo
    {
        /// <summary>
        /// مبلغ قابل پرداخت
        /// </summary>
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// مبلغ قایل پرداخت کل
        /// </summary>
        public decimal FirstAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده
        /// </summary>
        public decimal VocherDeductedAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده
        /// </summary>
        public decimal WalletDeductedAmount { get; set; }

        /// <summary>
        /// مبلغ کسر شده
        /// </summary>
        public decimal HappyCardDeductedAmount { get; set; }
    }
}

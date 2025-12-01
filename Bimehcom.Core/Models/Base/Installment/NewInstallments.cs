using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Installment
{
    public class NewInstallments
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// شناسه یکتا
        /// </summary>
        public string UniqueId { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// مبلغ نهایی
        /// </summary>
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// پیش پرداخت
        /// </summary>
        public decimal PrepaymentAmount { get; set; }

        /// <summary>
        /// مبلغ خالص پیش پرداخت
        /// </summary>
        public decimal PurePaymentAmount { get; set; }

        /// <summary>
        /// لیست شرایط اقساط
        /// </summary>
        public List<NewInstallment> Items { get; set; }

        /// <summary>
        /// حداکثر مبلغ مجاز بیمه نامه
        /// </summary>
        public long? MaxAllowedAmount { get; set; }

        public string Details { get; set; }
        public string Warnings { get; set; }

        /// <summary>
        /// کارمزد
        /// </summary>
        public long? WageAmount { get; set; }

        /// <summary>
        /// هزینه اعتبارسنجی
        /// </summary>
        public long? VerificationCost { get; set; }

        /// <summary>
        /// هزینه سفته دیجیتال
        /// </summary>
        public long? PromissoryNoteCost { get; set; }
    }
}
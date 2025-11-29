using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class InstallmentResponse
    {
        /// <summary>
        /// درصد قسط
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// تعداد روز
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// شناسه کلید پرداخت
        /// </summary>
        public Guid? InstallmentPaymentId { get; set; }

        /// <summary>
        /// پرداخت شده
        /// </summary>
        public bool? Payed { get; set; }
        /// <summary>
        /// تاریخ پرداخت قسط
        /// </summary>
        public DateTime? PaymentDate { get; set; }
        /// <summary>
        /// وضعیت قسط
        /// </summary>
        public string Status { get; set; }
    }
}

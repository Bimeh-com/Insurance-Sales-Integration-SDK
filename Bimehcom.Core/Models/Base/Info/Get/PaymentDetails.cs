using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class PaymentDetails
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// تاریخ پرداخت
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// مبلغ پرداخت
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// کد پیگیری
        /// </summary>
        public string TrackingCode { get; set; }

        /// <summary>
        /// نحوه پرداخت
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// عنوان درگاه
        /// </summary>
        public string GatewayTitle { get; set; }

        /// <summary>
        /// لوگو درگاه
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// وضعیت پرداخت
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// وضعیت پرداخت
        /// </summary>
        public short PaymentStatusId { get; set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public DateTime? LastModificationTime { get; set; }
    }
}

using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class CostDetails
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// مبلغ پرداخت
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// نوع
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// شناسه نوع
        /// </summary>
        public short TypeId { get; set; }

        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// تاریخ ارجاع به مالی
        /// </summary>
        public DateTime? SettlementCreationTime { get; set; }

        /// <summary>
        /// تاریخ پرداخت
        /// </summary>
        public DateTime? SettlementPaymentDate { get; set; }
    }
}

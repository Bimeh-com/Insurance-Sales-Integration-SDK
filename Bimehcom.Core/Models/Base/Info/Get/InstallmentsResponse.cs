using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class InstallmentsResponse
    {
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
        /// لیست شرایط اقساط
        /// </summary>
        public List<InstallmentResponse> Items { get; set; }

        public string Details { get; set; }
        public string Warnings { get; set; }
        public int SettlementReferenceId { get; set; }

        public string ConfirmDescription { get; set; }
    }
}

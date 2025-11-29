using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class CompanyFinancialDetails
    {
        /// <summary>
        /// مالیات بر ارزش افزوده
        /// </summary>
        public decimal Vat { get; set; }
        /// <summary>
        /// آیا پرداخت اقساط دارد؟
        /// </summary>
        public bool HasInstallmentPayment { get; set; }
        /// <summary>
        /// تخفیف
        /// </summary>
        public decimal Discount { get; set; }
        /// <summary>
        /// هزینه ارسال
        /// </summary>
        public decimal DeliveryCost { get; set; }
    }
}

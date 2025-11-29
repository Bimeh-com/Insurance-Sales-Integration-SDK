using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class Price
    {
        /// <summary>
        /// مبلغ اولیه
        /// </summary>
        public decimal FirstAmount { get; set; }

        /// <summary>
        /// مبلغ قابل پرداخت
        /// </summary>
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// عنوان نمایشی (در صورت موجود بودن نمایش داده می شود)
        /// </summary>
        public string Hint { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class FinancialDetails
    {
        public Price CashPrice { get; set; }
        public Price InstallmentPrice { get; set; }

        public Price PreviousCashPrice { get; set; }
        public Price OrginalCashPrice { get; set; }

        public bool? HasInstallments { get; set; }

        /// <summary>
        /// اقساطی اعتباری دارد
        /// </summary>
        public bool? HasCreditInstallments { get; set; }

        /// <summary>
        /// تخفیف شرکت بیمه
        /// </summary>
        public string Hint { get; set; }
    }
}

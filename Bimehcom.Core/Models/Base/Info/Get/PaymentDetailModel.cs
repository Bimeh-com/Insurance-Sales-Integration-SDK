using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class PaymentDetailModel
    {
        /// <summary>
        /// هزینه ها
        /// </summary>
        public List<CostDetails> Costs { get; set; }

        /// <summary>
        /// جزئیات پرداخت
        /// </summary>
        public List<PaymentDetails> Payments { get; set; }

        /// <summary>
        /// جزئیات اقساط
        /// </summary>
        public InstallmentsResponse Installments { get; set; }

        /// <summary>
        /// جزئیات قبل از پرداخت
        /// </summary>
        public InsurancePaymentInfo Payment { get; set; }
    }
}

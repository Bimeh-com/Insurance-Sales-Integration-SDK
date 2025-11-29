using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Gateway.Redirect
{
    /// <summary>
    /// مدل درخواست لینک پرداخت
    /// </summary>
    public class RedirectToPaymentRequest
    {
        /// <summary>
        /// شناسه درگاه
        /// </summary>
        public string GatewayId { get; set; }

        /// <summary>
        /// لینک بازگشت بعد از پرداخت موفق
        /// </summary>
        public string SuccessReturnURL { get; set; }

        /// <summary>
        /// لینک بازگشت بعد از پرداخت ناموفق
        /// </summary>
        public string FaildReturnURL { get; set; }
    }
}

using Bimehcom.Core.Models.Base.Info.Get;
using System;

namespace Bimehcom.Core.Models.Base.Endorsement
{
    public class GetEndorsementInformationModel
    {
        public Guid InsuranceRequestId { get; set; }
        public dynamic Id { get; set; }
        public bool AllowUseVoucherCode { get; set; }
        /// <summary>
        /// جزئیات درخواست
        /// </summary>
        public RequestDetail Info { get; set; }

        /// <summary>
        /// جزئیات پرداخت
        /// </summary>
        public PaymentDetailModel Financial { get; set; }

    }
}

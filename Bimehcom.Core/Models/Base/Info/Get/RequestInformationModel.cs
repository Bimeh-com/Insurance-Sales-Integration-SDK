namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class RequestInformationModel
    {
        public dynamic InsuranceRequestId { get; set; }
        public bool AllowUseVoucherCode { get; set; }
        public bool NeedVisitationInformation { get; set; }
        public bool NeedShahkarValidation { get; set; }
        public bool AllowLegalPolicyOwner { get; set; }

        /// <summary>
        /// جزئیات درخواست
        /// </summary>
        public RequestDetail InsuranceInfo { get; set; }


        /// <summary>
        /// جزئیات تحویل
        /// </summary>
        public DeliveryVisitModel LogisticsRequirement { get; set; }

        /// <summary>
        /// جزئیات پرداخت
        /// </summary>
        public PaymentDetailModel Financial { get; set; }

        /// <summary>
        /// جزئیات بیمه گذار
        /// </summary>
        public InsurerInfo InsurerInfo { get; set; }
    }
}

namespace Bimehcom.Core.Models.SubClients.Base.Payment.Requests
{
    public class SubmitInsuranceRequestPaymentInformationRequest
    {
        public string TrackingCode { get; set; }
        public decimal Amount { get; set; }
        public dynamic InsuranceRequestId { get; set; }
    }
}

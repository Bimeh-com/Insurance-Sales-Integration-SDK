namespace Bimehcom.Core.Models.SubClients.Base.Payment.Requests
{
    public class SubmitEndorsementPaymentInformationRequest
    {
        public string TrackingCode { get; set; }
        public decimal Amount { get; set; }
        public string endorsementId { get; set; }
    }
}

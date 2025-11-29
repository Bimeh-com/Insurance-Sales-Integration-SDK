namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class DeliveryVisitModel
    {
        public VisitDeliveryInfo Delivery { get; set; }

        public VisitInfo Visit { get; set; }

        public string ReceiverFullName { get; set; }

        public string ReceiverMobileNumber { get; set; }

        public string Email { get; set; }

        public string Description { get; set; }
        public string ShippingCode { get; set; }
    }
}

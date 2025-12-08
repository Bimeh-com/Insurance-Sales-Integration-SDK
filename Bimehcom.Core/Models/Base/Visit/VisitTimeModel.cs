using Bimehcom.Core.Models.Base.DeliveryDateTime;

namespace Bimehcom.Core.Models.Base.Visit
{
    public class VisitTimeModel : ITime
    {
        public long Id { get; set; }
        public string UniqueId { get; set; }
        public string Title { get; set; }
        public bool Disabled { get; set; }
        public string Reason { get; set; }
    }
}
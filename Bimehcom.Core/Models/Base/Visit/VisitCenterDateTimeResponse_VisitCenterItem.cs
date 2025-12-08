using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Visit
{
    public class VisitCenterDateTimeResponse_VisitCenterItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long GiftAmount { get; set; }
        public long CostAmount { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Tel { get; set; }
        public List<VisitDate> Dates { get; set; }
    }
}

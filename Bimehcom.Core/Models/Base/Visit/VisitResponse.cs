using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Visit
{
    public class VisitResponse
    {
        public List<VisitDate> Visits { get; set; }
        public long? SelectedId { get; set; }

    }
}

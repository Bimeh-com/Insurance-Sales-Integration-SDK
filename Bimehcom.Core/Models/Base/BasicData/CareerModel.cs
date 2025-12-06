using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.BasicData
{
    public class CareerModel
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public List<int> CareerGroupIds { get; set; }
        public string CareerGroupNames { get; set; }
    }
}

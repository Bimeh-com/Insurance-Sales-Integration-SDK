using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Endorsement
{
    public class EndorsementBasicInfo
    {
        public List<BaseItem> Types { get; set; }
        public List<EndorsementGroupVm> Groups { get; set; }
    }
}

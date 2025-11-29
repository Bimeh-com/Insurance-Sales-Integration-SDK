using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class InsurerInfo
    {
        public InsurerDetailModel Insurer { get; set; }
        public List<ExtraInsuredInfo> ExtraInsured { get; set; }
        public List<PublicModelByName> Details { get; set; }
        public List<ImageModel> Files { get; set; }
    }
}

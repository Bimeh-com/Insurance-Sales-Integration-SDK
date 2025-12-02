using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses
{
    public class VehicleClientCarModelsResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Models { get; set; }
    }
}

using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.ElectronicEquipment.Responses
{
    public class ElectronicEquipmentInsuranceGetModelsResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Models { get; set; }
    }
}

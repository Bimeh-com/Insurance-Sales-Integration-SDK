using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.ElectronicEquipment.Responses
{
    public class ElectronicEquipmentInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست دستگاه
        /// </summary>
        public List<BaseItem> Devices { get; set; }
        /// <summary>
        /// لیست فرانشیز
        /// </summary>
        public List<BaseItem> Franchises { get; set; }
    }
}
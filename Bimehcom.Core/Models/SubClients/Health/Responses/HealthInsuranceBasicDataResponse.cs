using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using Bimehcom.Core.Models.Base.Create;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Health.Responses
{
    public class HealthInsuranceBasicDataResponse : StartInsuranceResponse, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست بیمه گر پایه
        /// </summary>
        public List<BaseItem> BasicInsurers { get; set; }
        /// <summary>
        /// لیست نسبت
        /// </summary>
        public List<BaseItem> Relationships { get; set; }
        /// <summary>
        /// وضعیت تاهل
        /// </summary>
        public List<BaseItem> MaritalStatuses { get; set; }
        /// <summary>
        /// وضعیت تکفل
        /// </summary>
        public List<BaseItem> DependentStatuses { get; set; }
        public List<BaseItem> Banks { get; set; }
    }
}
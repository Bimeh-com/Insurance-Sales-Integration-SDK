using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Sports.Responses
{
    public class SportsInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        public List<CareerModel> Careers { get; set; }
        public int MinAllowedAge { get; set; }
        public int MaxAllowedAge { get; set; }
        public List<BaseItem> Teams { get; set; }
        /// <summary>
        /// لیست دوره های زمانی
        /// </summary>
        public List<BaseItem> Durations { get; set; }
    }
}
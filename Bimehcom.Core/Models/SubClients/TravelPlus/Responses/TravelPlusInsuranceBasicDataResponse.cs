using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.TravelPlus.Responses
{
    public class TravelPlusInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست کشورها
        /// </summary>
        public List<BaseItem> Countries { get; set; }

        /// <summary>
        /// لیست دوره های زمانی
        /// </summary>
        public List<BaseItem> Durations { get; set; }

        /// <summary>
        /// لیست طرح ها
        /// </summary>
        public List<BaseItem> Plans { get; set; }

        /// <summary>
        /// نوع ویزا
        /// </summary>
        public List<BaseItem> VisaTypes { get; set; }
    }
}
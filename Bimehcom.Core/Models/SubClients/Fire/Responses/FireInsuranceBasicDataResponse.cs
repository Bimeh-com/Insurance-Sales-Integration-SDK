using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    /// <summary>
    /// پاسخ درخواست اولیه بیمه آتش سوزی
    /// </summary>
    public class FireInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست قیمت هر متر مربع
        /// </summary>
        public List<BaseItem> AreaUnitPrices { get; set; }

        /// <summary>
        /// لیست پوشش های اضافی
        /// </summary>
        public List<BaseItem> Coverages { get; set; }

        /// <summary>
        /// لیست انواع ملک
        /// </summary>
        public List<EstateType> EstateTypes { get; set; }

        /// <summary>
        /// لیست انواع سازه
        /// </summary>
        public List<BaseItem> StructureTypes { get; set; }

        /// <summary>
        /// لیست نوع مالکیت
        /// </summary>
        public List<BaseItem> OwnershipTypes { get; set; }

        /// <summary>
        /// حداکثر ارزش لوازم منزل
        /// </summary>
        public decimal MaximumValueOfAppliance { get; set; }
    }
}
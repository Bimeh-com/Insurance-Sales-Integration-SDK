using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Fire.Requests
{
    public class FireInsuranceInquiryRequest : InquiryRequest,IBimehcomApiRequest
    {
        /// <summary>
        /// شناسه نوع ملک
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? EstateTypeId { get; set; }

        /// <summary>
        /// تعداد واحد
        /// هنگامی که نوع ملک آپارتمان یا مجتمع باشد ورود این فیلد اجباری است
        /// </summary>
        public short? ApartmentUnitCount { get; set; } = 1;

        /// <summary>
        /// شناسه نوع سازه
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? StructureTypeId { get; set; }

        /// <summary>
        /// متراژ کل محل مورد بیمه
        /// </summary>
        public int? TotalArea { get; set; }

        /// <summary>
        /// ارزش لوازم موجود در محل
        /// این مقدار نباید بیشتر از مقدار حداکثر ارائه شده در سرویس basic-data باشد 
        /// </summary>
        public decimal? AppliancesValue { get; set; }

        /// <summary>
        /// شناسه قیمت هر متر مربع
        /// این مبلغ به صورت پیش فرض یک میلیون تومان است
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? AreaUnitPriceId { get; set; }

        /// <summary>
        /// پوشش های انتخاب شده
        /// شامل یک 
        /// لیست از شناسه پوشش های انتخاب شده
        /// است. شناسه های مورد نظر
        /// از سرویس 
        /// basic-data
        /// دریافت شده
        /// است.
        /// </summary>
        public List<int> CoverageIds { get; set; }
    }
}

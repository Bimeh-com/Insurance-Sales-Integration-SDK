using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base;
using Bimehcom.Core.Models.Base.Inquiry;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.CarBody.Responses
{
    public class CarBodyInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// لیست نوع کاربری خودرو
        /// </summary>
        public List<BaseItem> UsingTypes { get; set; }

        /// <summary>
        /// لیست برند خودروها
        /// </summary>
        public List<BrandItem> Brands { get; set; }

        /// <summary>
        /// لیست شرکت های بیمه
        /// </summary>
        public List<InsuranceCompany> Companies { get; set; }

        /// <summary>
        /// لیست سال های ساخت مجاز
        /// </summary>
        /// <returns></returns>
        public List<ProductionYearList> ProductionYears { get; set; }

        /// <summary>
        /// تعداد سال عدم تخفیف بیمه ثالث
        /// </summary>
        public List<BaseItem> ThirdPartyDiscounts { get; set; }

        /// <summary>
        /// تعداد سال عدم تخفیف بیمه بدنه
        /// </summary>
        public List<BaseItem> CarBodyNoDamageYears { get; set; }

        /// <summary>
        /// لیست تخفیف ها
        /// </summary>
        public List<BaseItem> Discounts { get; set; }

        /// <summary>
        /// لیست پوشش های اضافی
        /// پوشش هایی که گروه بندی دارند (مانند سرقت) امکان انتخاب آیتم های زیر مجموعه وجود دارد
        /// </summary>
        public List<CarBodyCoverage> Coverages { get; set; }

        /// <summary>
        /// لیست بانک ها
        /// </summary>
        public List<BaseItem> Banks { get; set; }

        public List<VehicleCategoriesBaseItem> VehicleCategories { get; set; }
    }

    public class ProductionYearList : BaseItem
    {
        public string PersianYear { get; set; }
    }
    public class BaseItemWithComment : BaseItem
    {
        public string Description { get; set; }
        public int? Priority { get; set; }
    }

    /// <summary>
    /// پوشش های بیمه بدنه (سرقت، آتش سوزی و ...)
    /// </summary>
    public class CarBodyCoverage : BaseItemWithComment
    {
        public string Description { get; set; }
        /// <summary>
        /// آیتم های مختلف برای پوشش
        /// </summary>
        public BaseItemWithComment[] Items { get; set; }
    }
}

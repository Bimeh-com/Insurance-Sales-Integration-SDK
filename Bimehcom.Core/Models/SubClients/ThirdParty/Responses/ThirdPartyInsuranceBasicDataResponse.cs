using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base;
using Bimehcom.Core.Models.Base.Inquiry;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.ThirdParty.Responses
{
    public class ThirdPartyInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {    /// <summary>
         /// لیست پوشش ها
         /// </summary>
        public List<BaseItem> CoverageTypes { get; set; }

        /// <summary>
        /// لیست برند خودرو
        /// </summary>
        public List<BrandItem> Brands { get; set; }

        /// <summary>
        /// لیست تخفیف شخص ثالث
        /// </summary>
        public List<BaseItem> ThirdPartyDiscounts { get; set; }

        /// <summary>
        /// لیست تخفیف حوادث راننده
        /// </summary>
        public List<BaseItem> DriverDiscounts { get; set; }

        /// <summary>
        /// لیست خسارت جانی
        /// </summary>
        public List<BaseItem> LifeLosses { get; set; }

        /// <summary>
        /// لیست خسارت مالی
        /// </summary>
        public List<BaseItem> PropertyLosses { get; set; }

        /// <summary>
        /// لیست خسارت راننده
        /// </summary>
        public List<BaseItem> DriverLosses { get; set; }

        /// <summary>
        /// لیست شرکت های بیمه
        /// </summary>
        public List<InsuranceCompany> Companies { get; set; }

        /// <summary>
        /// لیست سال ساخت خودرو
        /// </summary>
        public List<BaseItem> ProductionYears { get; set; }

        /// <summary>
        /// لیست نوع کاربری خودرو
        /// </summary>
        public List<BaseItem> UsingTypes { get; set; }

        /// <summary>
        /// لیست دوره زمانی بیمه
        /// </summary>
        public List<BaseItem> Durations { get; set; }

        /// <summary>
        /// لیست وضعیت بیمه قبلی خودرو
        /// </summary>
        public List<BaseItem> InsuranceStatuses { get; set; }

        /// <summary>
        /// لیست دسته بندی نوع خودرو
        /// </summary>
        public List<VehicleCategoriesBaseItem> VehicleCategories { get; set; }

        public StaticCoverages StaticCoverages { get; set; }
    }

    public class StaticCoverages
    {
        public string LifeCoverage { get; set; }

        public string DriverCoverage { get; set; }
    }
}

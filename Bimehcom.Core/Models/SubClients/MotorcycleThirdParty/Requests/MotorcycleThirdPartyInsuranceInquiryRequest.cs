using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;

namespace Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests
{
    public class MotorcycleThirdPartyInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// وضعیت بیمه نامه قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public PreviousInsuranceStatus? PreviousInsuranceStatusId { get; set; }

        /// <summary>
        /// شناسه نوع موتور
        /// </summary>
        public long? MotorTypeId { get; set; }

        /// <summary>
        /// شرکت بیمه گر قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? PreviousCompanyId { get; set; }

        /// <summary>
        /// شناسه سال ساخت (میلادی)
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? ProductionYearId { get; set; }

        /// <summary>
        /// تاریخ اتمام بیمه نامه قبلی
        /// </summary>
        public DateTime? PreviousExpirationDate { get; set; }

        /// <summary>
        /// شناسه درصد تخفیف بیمه نامه قبلی 
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? ThirdPartyDiscountId { get; set; }

        /// <summary>
        /// شناسه درصد تخفیف حوادث راننده بیمه نامه قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? DriverDiscountId { get; set; }

        /// <summary>
        /// شناسه مدت زمان بیمه نامه درخواستی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public short? DurationId { get; set; }

        /// <summary>
        /// شناسه تعداد خسارت جانی بیمه نامه قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public short? LifeLossId { get; set; }

        /// <summary>
        /// شناسه تعداد خسارت مالی بیمه نامه قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public short? PropertyLossId { get; set; }

        /// <summary>
        /// شناسه تعداد خسارت حوادث راننده
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public short? DriverLossId { get; set; }

        /// <summary>
        /// شناسه نوع پوشش مالی بیمه نامه درخواستی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? CoverageTypeId { get; set; }

        /// <summary>
        /// شناسه مدت زمان بیمه نامه قبلی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? PreviousDurationId { get; set; }

        /// <summary>
        /// تاریخ شماره گذاری / ترخیص خودروی صفر، فاقد بیمه نامه یا وارداتی
        /// </summary>
        public DateTime? ReleaseDate { get; set; }
    }
}
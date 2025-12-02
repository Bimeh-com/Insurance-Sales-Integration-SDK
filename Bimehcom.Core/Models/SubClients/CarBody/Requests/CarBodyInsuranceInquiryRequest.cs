using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;
using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.CarBody.Requests
{
    public class CarBodyInsuranceInquiryRequest : InquiryRequest,IBimehcomApiRequest
    {
        /// <summary>
        /// عدم خسارت بیمه ثالث
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? ThirdPartyDiscountId { get; set; }
        /// <summary>
        /// تاریخ ساخت خودرو
        /// </summary>
        public DateTime ProductionDate { get; set; }
        /// <summary>
        /// پوشش های اضافی
        /// </summary>
        public List<string> CoverageIds { get; set; } = new List<string>();
        /// <summary>
        /// شرکت بیمه ثالث
        /// </summary>
        public int? ThirdPartyCompanyId { get; set; }

        /// <summary>
        /// لیست تخفیف ها
        /// </summary>
        public List<string> DiscountIds { get; set; }

        /// <summary>
        /// شناسه بانکی که کاربر در آن حساب دارد
        /// </summary>
        public int? BankId { get; set; }



        /// <summary>
        /// نوع استفاده خودرو
        /// </summary>
        public int UsingTypeId { get; set; } = 1;



        /// <summary>
        /// مبلغ جمع ارزش قطعات غیر فابریک
        /// </summary>
        public long? NonFabricatedPartsPrice { get; set; }

        /// <summary>
        /// پلاک رمزنگاری شده
        /// </summary>
        public string EncryptedPlaque { get; set; }
        public DateTime? PreviousExpirationDate { get; set; }
        public int? PreviousCompanyId { get; set; }




        /// <summary>
        /// شناسه مدل خودرو
        /// دریافت شده از سرویس car-model
        /// </summary>
        public int ModelId { get; set; }

        /// <summary>
        /// ارزش خودرو
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// سال عدم خسارت بیمه بدنه
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? CarBodyNoDamageYearId { get; set; }

        /// <summary>
        /// شناسه شرکت بیمه عمر
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? LifeInsuranceCompanyId { get; set; }

        /// <summary>
        /// خودرو وارداتی
        /// </summary>
        public bool Imported { get; set; }
    }
}

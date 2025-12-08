using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;

namespace Bimehcom.Core.Models.SubClients.MedicalLiability.Requests
{
    public class MedicalLiabilityInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// شناسه گروه بندی
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public long? MedicalTypeId { get; set; }

        /// <summary>
        /// شناسه تخصص انتخاب شده
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public long? MedicalExpertiseId { get; set; }

        /// <summary>
        /// آیا رزیدنت است؟
        /// </summary>
        public bool? IsResident { get; set; }

        /// <summary>
        /// آیا دانشجو است؟
        /// </summary>
        public bool? IsStudent { get; set; }

        /// <summary>
        /// شناسه سابقه عدم خسارت
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public long? NoDamageDiscountId { get; set; }
        /// <summary>
        /// پوشش افزایشی ریالی دیه
        /// </summary>
        public bool? CoverIncreasePremium { get; set; }

        /// <summary>
        /// دارای کد نظام پزشکی
        /// </summary>
        public bool? HasMedicalSystemCode { get; set; }
    }
}
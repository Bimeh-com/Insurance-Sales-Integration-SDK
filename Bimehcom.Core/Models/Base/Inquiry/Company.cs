
namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class Company
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// توانگری مالی
        /// </summary>
        public short FinancialStrength { get; set; }

        /// <summary>
        /// صدور آنلاین؟
        /// </summary>
        public bool HasPermissionForOnlineIssue { get; set; }

        /// <summary>
        /// اولویت نمایش 
        /// </summary>
        public short Priority { get; set; }

        /// <summary>
        /// شرایط اختصاصی
        /// </summary>
        public string PrivateConditions { get; set; }

        /// <summary>
        /// جزئیات مالی
        /// </summary>
        public CompanyFinancialDetails FinancialDetails { get; set; }

        /// <summary>
        /// تعداد شعب پرداخت خسارت
        /// </summary>
        public int CompensationBranchCount { get; set; }

        /// <summary>
        /// زمان پاسخگویی
        /// </summary>
        public string CompanyResponseTime { get; set; }

        /// <summary>
        /// رتبه رضایتمندی
        /// </summary>
        public int? CompanySatisfiedRating { get; set; }

        /// <summary>
        /// آدرس آرم
        /// </summary>
        public string LogoURL { get; set; }

        /// <summary>
        /// اجازه صدور آنلاین
        /// </summary>
        public bool HasOnlineIssue { get; set; }

        /// <summary>
        /// آدرس آرم شرکت مادر
        /// </summary>
        public string CorporateLogoURL { get; set; }

        /// <summary>
        /// آدرس آرم شرکت مادر
        /// </summary>
        public string CorporateName { get; set; }

        /// <summary>
        /// امکان تحویل فوری
        /// </summary>
        public string FastDelivery { get; set; }

        /// <summary>
        /// برچسب
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// شرایط خاص (متن کوتاه)
        /// </summary>
        public string Notice { get; set; }

        /// <summary>
        /// ارزیابی خسارت سیار
        /// </summary>
        public bool? MobileCompensation { get; set; }
    }
}

namespace Bimehcom.Core.Models.Base.LogisticRequirements.Set
{
    public class LogisticsRequirementInformationRequest
    {
        /// <summary>
        /// شناسه یکتا
        /// </summary>
        public string UniqueId { get; set; }

        /// <summary>
        /// نام دریافت کننده
        /// </summary>
        public string ReceiverFullName { get; set; }

        /// <summary>
        /// شماره موبایل دریافت کننده
        /// </summary>
        public string ReceiverMobileNumber { get; set; }

        /// <summary>
        /// آدرس ایمیل
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}

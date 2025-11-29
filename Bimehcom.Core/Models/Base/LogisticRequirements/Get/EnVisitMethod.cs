namespace Bimehcom.Core.Models.Base.LogisticRequirements.Get
{
    public enum EnVisitMethod
    {
        /// <summary>
        /// مراجعه کاربر به مراکز بیمه دات کام
        /// </summary>
        VisitCenter = 0,

        /// <summary>
        /// ارسال تصاویر از طریق سایت
        /// </summary>
        UserBySite = 1,

        /// <summary>
        /// بازدید در محل کاربر
        /// </summary>
        UserLocation = 2,

        /// <summary>
        /// بدون نیاز به بازدید
        /// </summary>
        NoVisitRequired = 3,

        /// <summary>
        /// ارسال تصاویر از طریق اپلیکیشن
        /// </summary>
        UserByApplication = 4
    }
}
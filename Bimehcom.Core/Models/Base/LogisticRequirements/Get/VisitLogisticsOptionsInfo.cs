namespace Bimehcom.Core.Models.Base.LogisticRequirements.Get
{
    public class VisitLogisticsOptionsInfo : LogisticsOptionsInfo
    {
        public VisitMethod[] Methods { get; set; }
    }
    public class VisitMethod
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        public Financial Financial { get; set; }
        public EnVisitMethod Type { get; set; }
        public string UniqueId { get; set; }
    }

    public class Financial
    {
        public int Amount { get; set; }
        public EnFinancialType Type { get; set; }
    }

    public class LogisticsOptionsInfo
    {
        /// <summary>
        /// وضعیت های مورد نیاز:
        /// ندارد = Null
        /// اختیاری = Optional
        /// اجباری = Required
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}
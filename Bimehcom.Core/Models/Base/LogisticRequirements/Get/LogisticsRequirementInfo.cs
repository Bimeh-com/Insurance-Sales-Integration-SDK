namespace Bimehcom.Core.Models.Base.LogisticRequirements.Get
{
    public class LogisticsRequirementInfo
    {
        /// <summary>
        /// تحویل حضوری
        /// </summary>
        public DeliveryLogisticsOptionsInfo Delivery { get; set; }
        /// <summary>
        /// بازدید کارشناس
        /// </summary>
        public VisitLogisticsOptionsInfo Visit { get; set; }
        /// <summary>
        /// تحویل آنلاین ( دانلود مستقیم / ارسال به ایمیل )
        /// </summary>
        public LogisticsOptionsInfo Online { get; set; }
    }
}

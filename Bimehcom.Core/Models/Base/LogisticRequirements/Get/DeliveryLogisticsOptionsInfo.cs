namespace Bimehcom.Core.Models.Base.LogisticRequirements.Get
{
    public class DeliveryLogisticsOptionsInfo
    {
        /// <summary>
        /// پیام تخفیف عدم ارسال
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// مبلغ تخفیف عدم ارسال
        /// </summary>
        public int WithoutDeliveryDiscountPrice { get; set; }

        /// <summary>
        ///     هزینه ارسال
        /// </summary>
        public decimal? DeliveryCost { get; set; }

        public bool? DeliveryCostEnabled { get; set; }

        public BaseItem WithoutDeliveryDiscountType { get; set; }
    }
}
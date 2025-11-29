using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Info.Get
{

    public class CarBodyPriceDetails
    {
        public CarBodyPriceDetails()
        {
            Discounts = new List<CarBodyPriceDetails_DiscountItem>();
            AdditionalDiscounts = new List<CarBodyPriceDetails_DiscountItem>();
        }

        //حق بیمه پایه
        public long FirstAmount { get; set; }

        //ضریب کهنگی
        public long OldnessAmount { get; set; }

        //حق بیمه پوشش ها
        public long CoverageAmount { get; set; }

        //کل تخفیف
        public long TotalDiscountAmount { get; set; }

        //جمع مبلغ
        public long TotalPrice { get; set; }

        //جمع مبلغ دوره
        public long TotalPeriodPrice { get; set; }

        //ارزش افزوده
        public long VatPrice { get; set; }

        //تخفیف فروش
        public long SalesDiscount { get; set; }

        //مبلغ قابل پرداخت
        public long PayablePrice { get; set; }

        //تخفیفات اصلی
        public List<CarBodyPriceDetails_DiscountItem> Discounts { get; set; }

        //تخفیفات اضافی
        public List<CarBodyPriceDetails_DiscountItem> AdditionalDiscounts { get; set; }
    }

    public class CarBodyPriceDetails_DiscountItem
    {
        public string Title { get; set; }
        public long Amount { get; set; }
        public double? Percent { get; set; }
        public long TotalAmount { get; set; }
    }
}
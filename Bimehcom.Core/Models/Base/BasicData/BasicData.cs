using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class BasicData
    {
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        public VoucherBannerModel VoucherBanner { get; set; }
        public List<VoucherBannerModel> VoucherBanners { get; set; }

        /// <summary>
        /// لیست جنسیت
        /// </summary>
        public BaseItem[] Genders { get; internal set; }

        /// <summary>
        /// نمایش فیلتر تخفیف
        /// </summary>
        public bool ShowVoucherFilter { get; set; }
        public bool IsAddressRequired { get; set; }
    }
}

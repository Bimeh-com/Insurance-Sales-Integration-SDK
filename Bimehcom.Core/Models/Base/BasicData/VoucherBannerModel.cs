namespace Bimehcom.Core.Models.Base.BasicData
{
    public class VoucherBannerModel
    {
        public int Id { get; set; }
        public string DesktopCaption { get; set; }
        public string MobileCaption { get; set; }
        public string VoucherCode { get; set; }

        public string ValueTypeName { get; set; }
        public decimal? Amount { get; set; }

    }
}

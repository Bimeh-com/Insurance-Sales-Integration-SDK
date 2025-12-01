
namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class Coverage : BaseItem
    {
        /// <summary>
        /// پوشش جانی
        /// </summary>
        public string LifeCoverage { get; set; }

        /// <summary>
        /// پوشش مالی
        /// </summary>
        public string FinancialCoverage { get; set; }
        /// <summary>
        /// پوشش راننده
        /// </summary>
        public string DriverCoverage { get; set; }
        public int Order { get; set; }
    }
}

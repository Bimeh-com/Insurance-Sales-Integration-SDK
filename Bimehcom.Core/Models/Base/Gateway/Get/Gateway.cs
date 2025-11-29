namespace Bimehcom.Core.Models.Base.Gateway.Get
{
    public class Gateway
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// عنوان درگاه
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// شتاب بودن
        /// </summary>
        public bool IsShetab { get; set; }

        /// <summary>
        /// آرم 
        /// </summary>
        public string LogoUrl { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// شناسه پرداخت
        /// </summary>
        public string FormulaPaymentId { get; set; }
    }
}

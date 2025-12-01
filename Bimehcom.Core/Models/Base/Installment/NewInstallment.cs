namespace Bimehcom.Core.Models.Base.Installment
{
    public class NewInstallment
    {
        /// <summary>
        /// درصد قسط
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// تعداد روز
        /// </summary>
        public int Days { get; set; }

        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
    }
}